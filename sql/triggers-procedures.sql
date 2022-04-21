-- Quand on ajoute une participation (insert dans participer) (activité)
-- On vérifie que l'id de l'activité n'est pas à une date/heure d'une autre activité/session
-- -> (select concat(date, ' ', heure) from activite where numActivite = inserted.numActivite) not in (select concat(date, ' ', heure) from activite union select concat(date, ' ', heure) from session)


(select concat(date, ' ', heure) from activite where numActivite = inserted.numActivite) not in

select concat(date, ' ', heure) from activite
union
select concat(date, ' ', heure) from session;

go
create trigger ti_participer on participer instead of insert
as
begin

end;