# Gestion d’inventaire – C# & SQL Server

## Description
Application simple de gestion d’inventaire développée en C# avec SQL Server.
Projet académique réalisé dans le cadre du DEC Techniques de l’informatique (Collège LaSalle).

## Fonctionnalités
- Ajouter un produit
- Modifier un produit
- Supprimer un produit
- Afficher la liste des produits

## Technologies utilisées
- C# (WinForms)
- SQL Server
- ADO.NET
- Visual Studio

## Structure (prévue)
- `Models/` : classes (ex. Produit)
- `Data/` : connexion et accès BD
- `Database/` : script SQL
- `Screenshots/` : captures d’écran

## Base de données
Table `Produits` :
- Id (int, PK)
- Nom (varchar)
- Quantite (int)
- Prix (decimal)

Le script de création se trouvera dans le dossier `Database/script.sql`.

## Objectif pédagogique
- Pratiquer le CRUD
- Comprendre la connexion à une base de données
- Structurer un projet C# de façon claire

- ## Captures d’écran
![Interface](Screenshots/interface.png)
![Ajout produit](Screenshots/ajout-produit.png)
![Liste produits](Screenshots/liste-produits.png)

