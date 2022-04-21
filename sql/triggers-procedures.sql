-- Quand on ajoute une participation (insert dans participer) (activit�)
-- On v�rifie que l'id de l'activit� n'est pas � une date/heure d'une autre activit�/session
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