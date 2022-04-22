create database RubricaDB

create table Indirizzo
(
 id int identity(1,1) primary key,
 tipologia varchar(80),
 via varchar(80),
 citta varchar(80),
 cap varchar(80),
 provincia varchar(80),
);

create table Contatto 
(
 Id int identity(1,1) primary key,
 Nome varchar(80),
 Cognome Varchar(80),
 idIndirizzo int FOREIGN KEY REFERENCES Indirizzo(id)
);
