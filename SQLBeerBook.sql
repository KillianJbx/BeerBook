Use master;
GO

IF EXISTS( SELECT * FROM sys.databases WHERE name ='BeerBook')
BEGIN
    ALTER DATABASE BeerBook SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE  BeerBook
END
GO

CREATE DATABASE BeerBook;
GO
USE BeerBook;
GO

CREATE TABLE Categorie (
  Identifiant INT NOT NULL IDENTITY,
  Libelle NVARCHAR(45) NOT NULL,
  PRIMARY KEY (Identifiant));

CREATE TABLE Gamme (
  Identifiant INT NOT NULL IDENTITY,
  Libelle NVARCHAR(45) NOT NULL,
  PRIMARY KEY (Identifiant));

CREATE TABLE Beers (
  Identifiant INT NOT NULL IDENTITY,
  Libelle NVARCHAR(45) NOT NULL,
  TauxAlcool FLOAT(4) NOT NULL,
  DateProd INT NULL,
  IdentifiantCategorie INT  NOT NULL,
  IdentifiantGamme INT NOT NULL,
  Commentaire NVARCHAR(200)  NULL,

  PRIMARY KEY (Identifiant));

  
ALTER TABLE Beers
ADD CONSTRAINT FK_Beer_Categorie
  FOREIGN KEY (IdentifiantCategorie)
  REFERENCES Categorie (Identifiant)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE Beers
ADD CONSTRAINT FK_Beer_Gamme
  FOREIGN KEY (IdentifiantGamme)
  REFERENCES Gamme (Identifiant)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


DELETE FROM Beers;
DELETE FROM Gamme;
DELETE FROM Categorie;

SET IDENTITY_INSERT Categorie ON;
GO
INSERT INTO Categorie(Identifiant, Libelle) 
VALUES (1, 'Pale Ale'), (2, 'Blonde Ale'), (3, 'Brown Ale'), (4, 'Indian Pale Ale'), (5, 'Stout'), (6, 'Lambic'), (7, 'American standards'), (8, 'Pilsner'), (9, 'Bock'), (10, 'Malt Liquor');
GO
SET IDENTITY_INSERT Categorie OFF;
GO

SET IDENTITY_INSERT Gamme ON;
GO
INSERT INTO Gamme(Identifiant, Libelle) 
VALUES (1, 'Pas cher'), (2, 'Modérement cher'), (3, 'Cher'), (4, 'Dégustation');
GO
SET IDENTITY_INSERT Gamme OFF;
GO

SET IDENTITY_INSERT Beers ON;
GO
INSERT INTO Beers (Identifiant, Libelle, DateProd, TauxAlcool, IdentifiantCategorie,IdentifiantGamme, Commentaire) 
VALUES (1, 'Guinness', '1759', 4.2,5, 3, 'Robe noir opaque, chapeau de mousse beige compact, saveurs douces et torréfiées, ensemble sucré et malté.');
GO
SET IDENTITY_INSERT Beers OFF;
GO

Select Beers.Identifiant, Beers.Libelle, DateProd, TauxAlcool, Categorie.Libelle, IdentifiantGamme, Commentaire From Beers Inner Join Categorie on Beers.IdentifiantCategorie = Categorie.Identifiant
