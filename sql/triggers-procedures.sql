use base_lugati;
go

-- TRIGGERS
-- Vérification qu'une personne ne participe pas à deux sessions/activités en même temps lors de l'ajout d'une activité
create or alter trigger ti_participer on participer 
instead of insert
as
begin
	declare cursParticiper cursor
	for
		select idParticipant, numActivite
		from inserted 
	declare @idParticipant int, @numActivite int
	open cursParticiper
	fetch next from cursParticiper into @idParticipant, @numActivite
	while(@@FETCH_STATUS = 0)
	begin
		declare @dateActivite varchar(30)
		set @dateActivite = (
			select concat(date, ' ', heure) 
			from activite 
			where numActivite = @numActivite
		)

		if(@dateActivite IN (
				select concat(date, ' ', heure) from activite a join participer p on a.numActivite = p.numActivite and p.idParticipant = @idParticipant
				union
				select concat(date, ' ', heure) from session s join inscrire i on i.numSession = s.numSession and i.idParticipant = @idParticipant)
			)
			throw 50001, 'Le participant ne peut pas participer à l''activité . Il a déjà quelque chose de prévu à cette heure là ce jour.', 1;
		else
			insert into participer (idParticipant, numActivite) values (@idParticipant, @numActivite)

		fetch next from cursParticiper into @idParticipant, @numActivite
	end
	close cursParticiper
	deallocate cursParticiper
end
go

-- Pareil mais lors d'un ajout d'une session
create or alter trigger ti_inscrire on inscrire 
instead of insert
as
begin
	declare cursParticiper cursor
	for
		select idParticipant, numSession
		from inserted 
	declare @idParticipant int, @numSession int
	open cursParticiper
	fetch next from cursParticiper into @idParticipant, @numSession
	while(@@FETCH_STATUS = 0)
	begin
		declare @dateSession varchar(30)
		set @dateSession = (
			select concat(date, ' ', heure) 
			from session 
			where numSession = @numSession
		)

		if(@dateSession IN (
				select concat(date, ' ', heure) from activite a join participer p on a.numActivite = p.numActivite and p.idParticipant = @idParticipant
				union
				select concat(date, ' ', heure) from session s join inscrire i on i.numSession = s.numSession and i.idParticipant = @idParticipant)
			)
			throw 50002, 'Le participant ne peut pas participer à la session . Il a déjà quelque chose de prévu à cette heure là ce jour.', 1;
		else 
			insert into inscrire(idParticipant, numSession) values (@idParticipant, @numSession)

		fetch next from cursParticiper into @idParticipant, @numSession
	end
	close cursParticiper
	deallocate cursParticiper
end
go 


--Procédure qui obtient le prix total à payer (sessions et activités comprises) pour un idParticipant passé en paramètres
create or alter procedure MontantTotalCongressiste (@idP int)
as
	SELECT prix + ISNULL(SUM(A.tarif), 0) + ISNULL(SUM(S.tarif), 0) as prixTotal
	FROM participant Pt
		JOIN hebergement H ON H.idHebergement = Pt.idHebergement
		LEFT JOIN participer P ON P.idParticipant = Pt.idParticipant
		LEFT JOIN activite A ON A.numActivite = P.numActivite
		LEFT JOIN inscrire I ON I.idParticipant = Pt.idParticipant
		LEFT JOIN session S ON S.numSession = I.numSession
	WHERE Pt.idParticipant = @idP
	GROUP BY Pt.idParticipant, prix
go

--Le nombre de places disponibles à une session donnée;
create or alter procedure NbPlaceParSession (@numS int)
as
	select (nbPlaces - COUNT(I.idParticipant)) as nbPlaceDisponible
	from session S
		left join inscrire I on S.numSession = I.numSession
	where S.numSession = @numS
	group by S.nbPlaces
go

--Procédure qui obtient le nombre de places dispo pour un idActivite passé en paramètres
create or alter procedure NbPlaceParActivite (@numA int)
as
	select (nbPlaces - COUNT(P.idParticipant)) as nbPlaceDisponible
	from activite A
		left join participer P on P.numActivite = A.numActivite
	where A.numActivite = @numA
	group by A.nbPlaces
go


--Droits
GRANT EXEC ON NbPlaceParActivite TO LugatiApp;
GRANT EXEC ON NbPlaceParSession TO LugatiApp;
GRANT EXEC ON MontantTotalCongressiste TO LugatiApp;
