USE master;
DROP DATABASE IF EXISTS base_lugati;

CREATE DATABASE base_lugati;
USE base_lugati;


CREATE TABLE ligue (
    idLigue int NOT NULL IDENTITY,
    nomLigue varchar(100),
    adresse varchar(50),
    cp varchar(5),
    ville varchar(50),
    CONSTRAINT pk_idLigue PRIMARY KEY (idLigue),
);

CREATE TABLE hebergement (
    idHebergement int NOT NULL IDENTITY,
    nomHebergement varchar(30),
    adresse varchar(50),
    ville varchar(30),
    cp varchar(5),
    tel varchar(10),
    nbEtoile int,
    prix int,
    CONSTRAINT pk_idHebergement PRIMARY KEY (idHebergement)
);

CREATE TABLE participant (
    idParticipant int NOT NULL IDENTITY,
    nom varchar(30),
    prenom varchar(30),
    genre char,
	idLigue int,
    adresse varchar(50),
    ville varchar(30),
    cp varchar(5),
	idHebergement int,
    acompte decimal(5,2) default 0,
    CONSTRAINT pk_idParticipant PRIMARY KEY (idParticipant),
	CONSTRAINT fk_participant_idLigue FOREIGN KEY (idLigue) REFERENCES ligue(idLigue),
	CONSTRAINT fk_participant_idHebergement FOREIGN KEY (idHebergement) REFERENCES hebergement(idHebergement)
);

CREATE TABLE session (
    numSession int NOT NULL IDENTITY,
    libelle varchar(100),
    tarif int,
    nbPlaces int,
    date date,
    heure varchar(5) CHECK (heure IN('09:00','14:30')),
    CONSTRAINT pk_numSession PRIMARY KEY (numSession)
);


CREATE TABLE activite (
    numActivite int NOT NULL IDENTITY,
    libelle varchar(100),
    tarif int,
    nbPlaces int,
    date date,
    heure varchar(5) CHECK (heure IN('09:00','14:30')),
    CONSTRAINT pk_numActivite PRIMARY KEY (numActivite)
);


CREATE TABLE participer (
    numActivite int,
    idParticipant int,
    CONSTRAINT pk_numActivite_idParticipant PRIMARY KEY (numActivite,idParticipant),
    CONSTRAINT fk_participer_numActivite FOREIGN KEY (numActivite) REFERENCES activite(numActivite),
    CONSTRAINT fk_participer_idParticipant FOREIGN KEY (idParticipant) REFERENCES participant(idParticipant)
);

CREATE TABLE inscrire (
    numSession int,
    idParticipant int,
    CONSTRAINT pk_numSession_idParticipant PRIMARY KEY (numSession, idParticipant),
    CONSTRAINT fk_inscrire_numSession FOREIGN KEY (numSession) REFERENCES session(numSession),
    CONSTRAINT fk_inscrire_idParticipant FOREIGN KEY (idParticipant) REFERENCES participant(idParticipant)
);

IF NOT EXISTS
    (SELECT name
     FROM sys.sql_logins
     WHERE name = 'LugatiApp')
BEGIN
	CREATE LOGIN LugatiApp WITH PASSWORD = 'b4n4n3';
END

CREATE USER LugatiApp FOR LOGIN LugatiApp;
--Droits tables
GRANT INSERT, UPDATE, DELETE, SELECT ON ligue TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON activite TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON hebergement TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON inscrire TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON participant TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON participer TO LugatiApp;
GRANT INSERT, UPDATE, DELETE, SELECT ON session TO LugatiApp;
