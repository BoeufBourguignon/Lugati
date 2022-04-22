-- TRIGGERS
create trigger tiu_participer on participer 
after insert, update
as
begin
	declare cursParticiper cursor
	for
		select idParticipant, numActivite
		from inserted 
	declare @idParticipant int, @numActivite int
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
			throw 50001, 'Une personne ne peut pas participer à deux sessions ou activités en même temps', 0
		else 
			insert into participer (idParticipant, numActivite) values (@idParticipant, @numActivite)

		fetch next from cursParticiper into @idParticipant, @numActivite
	end
end
go

create trigger tiu_inscrire on inscrire 
after insert, update
as
begin
	declare cursParticiper cursor
	for
		select idParticipant, numSession
		from inserted 
	declare @idParticipant int, @numSession int
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
			throw 50001, 'Une personne ne peut pas participer à deux sessions ou activités en même temps', 0
		else 
			insert into inscrire(idParticipant, numSession) values (@idParticipant, @numSession)

		fetch next from cursParticiper into @idParticipant, @numSession
	end
end
go


--Procédure qui obtient le prix total à payer (sessions et activités comprises) pour un idParticipant passé en paramètres
create or alter procedure MontantTotalCongressiste (@idP int)
as
	select SUM(S.tarif) + SUM(A.tarif) as prixTotal
	from activite A
		join participer P ON P.numActivite = A.numActivite
		join inscrire I ON I.idParticipant = P.idParticipant
		join session S ON S.numSession = I.numSession
	where P.idParticipant = @idP
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
	select (nbPlaces - COUNT(A.idParticipant)) as nbPlaceDisponible
	from activite A
		left join participer P on P.numActivite = A.numActivite
	where A.numActivite = @numA
	group by A.nbPlaces
go