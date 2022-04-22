-- TRIGGERS

-- Quand on ajoute une participation (insert dans participer) (activit�)
-- On v�rifie que l'id de l'activit� n'est pas � une date/heure d'une autre activit�/session
-- -> (select concat(date, ' ', heure) from activite where numActivite = inserted.numActivite) not in (select concat(date, ' ', heure) from activite union select concat(date, ' ', heure) from session)


--(select concat(date, ' ', heure) from activite where numActivite = inserted.numActivite) not in

--select concat(date, ' ', heure) from activite
--union
--select concat(date, ' ', heure) from session;

go
create trigger ti_participer on participer 
instead of insert
as
begin
	declare cursParticiper
	for
		select idParticipant, numActivite
		from inserted 
	declare @idParticipant int, @numActivite int
	fetch next from cursParticiper into @idParticipant, @numActivite
	while(@@FETCH_STATUS = 0)
	begin
		declare @dateActivite varchar(20)

		fetch next from cursParticiper into @idParticipant, @numActivite
	end
end
go