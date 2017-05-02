-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 30 Mars 2017 à 09:21
-- Version du serveur :  10.1.16-MariaDB
-- Version de PHP :  5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bibliomanga`
--

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--
CREATE DATABASE bibliomanga;
USE bibliomanga;

CREATE TABLE `categorie` (
  `idCat` int(11) NOT NULL,
  `libelle_cat` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `categorie`
--

INSERT INTO `categorie` (`idCat`, `libelle_cat`) VALUES
(1, 'shonen'),
(2, 'seinen');

-- --------------------------------------------------------

--
-- Structure de la table `definir`
--

CREATE TABLE `definir` (
  `idType` int(11) NOT NULL,
  `idManga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `definir`
--

INSERT INTO `definir` (`idType`, `idManga`) VALUES
(1, 1),
(2, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `manga`
--

CREATE TABLE `manga` (
  `idManga` int(11) NOT NULL,
  `nomManga` varchar(45) DEFAULT NULL,
  `synopsis` longtext,
  `imageManga` varchar(100) DEFAULT NULL,
  `StatutManga` tinyint(1) DEFAULT NULL,
  `DateParutionManga` date DEFAULT NULL,
  `idCat` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `manga`
--

INSERT INTO `manga` (`idManga`, `nomManga`, `synopsis`, `imageManga`, `StatutManga`, `DateParutionManga`, `idCat`) VALUES
(1, 'one piece', 'le roi des pirates blabla ', NULL, 0, '1997-07-17', 1),
(2, 'hokuto no ken', 'la vengeance hokuto de cuisine hokuto de salle a manger', NULL, 1, '1988-01-01', 2);

-- --------------------------------------------------------

--
-- Structure de la table `tome`
--

CREATE TABLE `tome` (
  `idTome` int(11) NOT NULL,
  `numeroTome` int(11) NOT NULL,
  `TitreTome` varchar(255) DEFAULT NULL,
  `ResumerTome` longtext,
  `ImageCouvertureTome` varchar(255) DEFAULT NULL,
  `DateAchatTome` date DEFAULT NULL,
  `idManga` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `tome`
--

INSERT INTO `tome` (`idTome`, `numeroTome`, `TitreTome`, `ResumerTome`, `ImageCouvertureTome`, `DateAchatTome`, `idManga`) VALUES
(1, 1, 'le grand départ', 'luffy par a l''aventure', NULL, NULL, 1),
(2, 2, 'un nouveau membre', 'arrivée de usopp', NULL, NULL, 1),
(3, 1, 'l''héritier du hukuto', 'ken le héritier de houto shin ken ', NULL, NULL, 2);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `idType` int(11) NOT NULL,
  `libelle_Type` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `type`
--

INSERT INTO `type` (`idType`, `libelle_Type`) VALUES
(1, 'aventure'),
(2, 'action');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`idCat`);

--
-- Index pour la table `definir`
--
ALTER TABLE `definir`
  ADD PRIMARY KEY (`idType`,`idManga`),
  ADD KEY `FK_definir_idManga` (`idManga`);

--
-- Index pour la table `manga`
--
ALTER TABLE `manga`
  ADD PRIMARY KEY (`idManga`),
  ADD KEY `FK_Manga_idCat` (`idCat`);

--
-- Index pour la table `tome`
--
ALTER TABLE `tome`
  ADD PRIMARY KEY (`idTome`),
  ADD KEY `FK_Tome_idManga` (`idManga`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`idType`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `idCat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `manga`
--
ALTER TABLE `manga`
  MODIFY `idManga` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `tome`
--
ALTER TABLE `tome`
  MODIFY `idTome` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `type`
--
ALTER TABLE `type`
  MODIFY `idType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `definir`
--
ALTER TABLE `definir`
  ADD CONSTRAINT `FK_definir_idManga` FOREIGN KEY (`idManga`) REFERENCES `manga` (`idManga`),
  ADD CONSTRAINT `FK_definir_idType` FOREIGN KEY (`idType`) REFERENCES `type` (`idType`);

--
-- Contraintes pour la table `manga`
--
ALTER TABLE `manga`
  ADD CONSTRAINT `FK_Manga_idCat` FOREIGN KEY (`idCat`) REFERENCES `categorie` (`idCat`);

--
-- Contraintes pour la table `tome`
--
ALTER TABLE `tome`
  ADD CONSTRAINT `FK_Tome_idManga` FOREIGN KEY (`idManga`) REFERENCES `manga` (`idManga`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
