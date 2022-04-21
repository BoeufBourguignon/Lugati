---Jeu d'essai de la base de la gestion des congrés

INSERT INTO ligue (nomLigue,adresse,cp,ville)
VALUES
  ('Qatar Saint-Germain Football Club','24 rue du Commandant-Guilbaud ','75016','Paris'),
  ('Olympique de Marseille','3 Bd Michelet,','13008 ','Marseille'),
  ('Olympique lyonnais','196 Av. Paul Santy','69007','Lyon'),
  ('Real Madrid Club de Fútbol','Avenida Concha Espina 1 28036 Madrid','28025','Madrid'),
  ('Manchester City Football Club','Sportcity, Rowsley Street M11 3FF Manchester','78000','Manchester');


INSERT INTO hebergement (nomHebergement,adresse,ville,cp,tel,nbEtoile,prix)
VALUES
  ('La neige bleue','2 Place de l''ours','Bourges','84269','0712389864',2,61),
  ('Le chalet chaleureux','14 Allée Pilou-Pilou','Rodez','66754','0758036347',3,239),
  ('L''Auberge espagnole','1 Avenue de la paella','Dijon','74517','0207331058',3,200),
  ('Hôtel Ritz','15 Place Vendôme','Paris','75001','0322746834',1,100),
  ('Château de Versailles','Place d''Armes','Versailles','78000','0202171242',2,186);


INSERT INTO participant (nom,prenom,genre,idLigue,adresse,ville,cp,idHebergement)
VALUES
  ('Lucas','BOUCHET','H',2,'478-8671 Et, Av.','Pontarlier','01822',3),
  ('Thibaud','LECLERE','H',2,'3390 Vivamus St.','Belfort','93547',3),
  ('Gabriel','BOIG-SIMON','H',4,'P.O. Box 484, 2712 Aliquet, Road','Saint-Brès','46519',4),
  ('Dodo','PRESIDENT','H',3,'511-5155 Rhoncus. Avenue','Caen','24665',1),
  ('Nino','DIDIER','H',2,'732-6719 Lacus. St.','Brive-la-Gaillarde','57965',1),
  ('Odile','CROC','F',1,'Ap #633-6921 Maecenas St.','Montpellier','81954',5),
  ('Afida','TURNER','F',1,'851-907 Risus Road','Hénin-Beaumont','59715',4);

INSERT INTO session (libelle,tarif,nbPlaces,date,heure)
VALUES
  ('Session d’inauguration',26,64,'24-10-2021','11:53'),
  ('Evaluation psychologique du sportif',30,38,'8-4-2023','2:03'),
  ('Pratiques sportives et usages de drogues',23,37,'9-9-2021','9:48'),
  ('Le burnout sportif comparé au syndrome de surentraînement',23,45,'30-6-2021','1:43'),
  ('Courir en extérieur sous la pluie',27,29,'11-8-2021','2:22'),
  ('Le doppage dans les JO',29,63,'7-5-2021','1:03'),
  ('Le sport pour les nuls',33,17,'6-11-2022','11:48');

INSERT INTO activite (libelle,tarif,nbPlaces,date,heure)
VALUES
  ('Patinoire sur bois d''acacia brut',39,17,'31-1-2023','09:30'),
  ('Ouho',38,42,'7-10-2022','09:30'),
  ('Corde à sauter en extérieur',39,26,'16-10-2021','09:30'),
  ('Course de trottinettes',33,73,'28-2-2022','14:00'),
  ('Atelier mécanique',37,51,'8-2-2023','14:00'),
  ('Rénovation de livres',35,37,'17-4-2023','14:00'),
  ('Barbecue collectif',39,11,'6-10-2021','14:00');

INSERT INTO inscrire (numSession, idParticipant)
VALUES
    (1,1)
    (1,2)
    (3,3)
    (3,4)
    (4,5)
    (5,6)
    (6,7)

INSERT INTO participer (numActivite, idParticipant)
VALUES
    (1,1)
    (1,2)
    (2,3)
    (3,4)
    (4,5)
    (4,6)
    (5,7)