---Jeu d'essai de la base de la gestion des congrés
use base_lugati;

INSERT INTO ligue (nomLigue,adresse,cp,ville)
VALUES
  ('Qatar Saint-Germain Football Club','24 rue du Commandant-Guilbaud ','75016','Paris'),
  ('Olympique de Marseille','3 Bd Michelet,','13008 ','Marseille'),
  ('Olympique lyonnais','196 Av. Paul Santy','69007','Lyon'),
  ('Real Madrid Club de Fútbol','Avenida Concha Espina 1 28036 Madrid','75000','Paris'),
  ('Manchester City Football Club','Sportcity, Rowsley Street M11 3FF Manchester','78000','Versailles');


INSERT INTO hebergement (nomHebergement,adresse,ville,cp,tel,nbEtoile,prix)
VALUES
  ('La neige bleue','2 Place de l''ours','Bourges','18000','0712389864',2,61),
  ('Le chalet chaleureux','14 Allée Pilou-Pilou','Rodez','12000','0758036347',3,239),
  ('L''Auberge espagnole','1 Avenue de la paella','Dijon','21000','0207331058',3,200),
  ('Hôtel Ritz','15 Place Vendôme','Paris','75001','0322746834',1,100),
  ('Château de Versailles','Place d''Armes','Versailles','78000','0202171242',2,186);


INSERT INTO participant (prenom,nom,genre,idLigue,adresse,ville,cp,idHebergement,acompte)
VALUES
  ('Lucas','BOUCHET','H',2,'1 rue de la roselière','Candyland','34130',3, 10),
  ('Thibaud','LECLERE','H',2,'4 bis rue des Campenottes','Bavans','25550',3, 10),
  ('Gabriel','BOIG-SIMON','H',4,'500 rue des aires','Saint-Brès','34670',4, 10),
  ('Dodo','PRESIDENT','H',3,'3 rue de la perte','Gigean','34770',1, 10),
  ('Nino','DIDIER','H',2,'26 rue Méjane','Olargues','34390',1, 10),
  ('Odile','CROC','F',1,'1 rue des Pertuisanes','Montpellier','34000',5, 10),
  ('Afida','TURNER','F',1,'11 rue de Biche','Woippy','57140',4, 10);


INSERT INTO session (libelle,tarif,nbPlaces,date,heure)
VALUES
  ('Session d’inauguration',26,64,'31-1-2023','09:00'),
  ('Evaluation psychologique du sportif',30,38,'08-04-2023','09:00'),
  ('Pratiques sportives et usages de drogues',23,37,'9-9-2021','14:30'),
  ('Le burnout sportif comparé au syndrome de surentraînement',23,45,'30-6-2021','09:00'),
  ('Courir en extérieur sous la pluie',27,29,'11-8-2021','14:30'),
  ('Le doppage dans les JO',29,63,'7-5-2021','14:30'),
  ('Le sport pour les nuls',33,17,'6-11-2022','14:30');


INSERT INTO activite (libelle,tarif,nbPlaces,date,heure)
VALUES
  ('Patinoire sur bois d''acacia brut',39,17,'31-1-2023','09:00'),
  ('Ouho',38,42,'7-10-2022','09:00'),
  ('Corde à sauter en extérieur',39,26,'16-10-2021','09:00'),
  ('Course de trottinettes',33,73,'28-2-2022','14:30'),
  ('Atelier mécanique',37,51,'8-2-2023','14:30'),
  ('Rénovation de livres',35,37,'17-4-2023','14:30'),
  ('Barbecue collectif',39,11,'6-10-2021','14:30');

DELETE FROM inscrire; DELETE FROM participer;

INSERT INTO inscrire (idParticipant, numSession)
VALUES
    (1,1),
    (2,1),
    (3,3),
    (4,3),
    (5,4),
    (6,5),
    (7,6);

INSERT INTO participer (idParticipant, numActivite)
VALUES
    (3,2),
    (4,3),
    (5,4),
    (6,4),
    (7,5);
