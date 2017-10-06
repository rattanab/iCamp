-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 06, 2017 at 04:33 AM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 7.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `icamp`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity`
--

CREATE TABLE `activity` (
  `ActivityID` int(11) NOT NULL,
  `ActivityName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `activity`
--

INSERT INTO `activity` (`ActivityID`, `ActivityName`) VALUES
(1, 'Archery'),
(2, 'Boxing'),
(3, 'Gaga Game'),
(4, 'Horse Riding'),
(5, 'Tennis'),
(6, 'Swimming'),
(7, 'Waterpark'),
(8, 'Adventure Park'),
(9, 'Flag Football'),
(10, 'Basketball'),
(11, 'Beach Volleyball'),
(12, 'Painting'),
(13, 'Fashion Design'),
(14, 'Sculpture'),
(15, 'Print-Making'),
(16, 'Weaving'),
(17, 'Creative Writing'),
(18, 'Puppetry');

-- --------------------------------------------------------

--
-- Table structure for table `activity_selection`
--

CREATE TABLE `activity_selection` (
  `ActivitySelectionID` int(11) NOT NULL,
  `CamperID` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Activity1` int(11) DEFAULT NULL,
  `Activity2` int(11) DEFAULT NULL,
  `Activity3` int(11) DEFAULT NULL,
  `Activity4` int(11) DEFAULT NULL,
  `Activity5` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `activity_selection`
--

INSERT INTO `activity_selection` (`ActivitySelectionID`, `CamperID`, `Date`, `Activity1`, `Activity2`, `Activity3`, `Activity4`, `Activity5`) VALUES
(1, 1, '2017-10-07', 2, 5, 6, 10, 14);

-- --------------------------------------------------------

--
-- Table structure for table `camper`
--

CREATE TABLE `camper` (
  `CamperID` int(11) NOT NULL,
  `CamperName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CamperNickName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Bunk` int(11) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Nationality` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `MedicalNeed` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DietNeed` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Transport` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG1Name` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG1Contact` int(11) DEFAULT NULL,
  `PG1Email` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG2Name` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG2Contact` int(11) DEFAULT NULL,
  `PG2Email` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ActivitySelectionID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `camper`
--

INSERT INTO `camper` (`CamperID`, `CamperName`, `CamperNickName`, `Bunk`, `Age`, `Nationality`, `StartDate`, `EndDate`, `MedicalNeed`, `DietNeed`, `Transport`, `PG1Name`, `PG1Contact`, `PG1Email`, `PG2Name`, `PG2Contact`, `PG2Email`, `ActivitySelectionID`) VALUES
(1, 'Ross', 'Rick', 2, 25, 'English', '2017-10-06', '2017-10-13', 'NA', 'NA', 'Bus', 'Luke', 812345678, 'dad@mail.com', 'Jane', 86543210, 'mum@mail.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `camp_session`
--

CREATE TABLE `camp_session` (
  `SessionID` int(11) NOT NULL,
  `SessionName` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SessionDateStart` date NOT NULL,
  `SessionDateEnd` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `camp_session`
--

INSERT INTO `camp_session` (`SessionID`, `SessionName`, `SessionDateStart`, `SessionDateEnd`) VALUES
(1, 'Seesion 1', '2017-09-30', '2017-10-06'),
(2, 'Session 2', '2017-10-07', '2017-10-13'),
(3, 'Session 3', '2017-10-14', '2017-10-20'),
(4, 'Session 4', '2017-10-23', '2017-10-29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activity`
--
ALTER TABLE `activity`
  ADD PRIMARY KEY (`ActivityID`);

--
-- Indexes for table `activity_selection`
--
ALTER TABLE `activity_selection`
  ADD PRIMARY KEY (`ActivitySelectionID`),
  ADD KEY `CamperID` (`CamperID`),
  ADD KEY `Activity1` (`Activity1`),
  ADD KEY `Activity2` (`Activity2`),
  ADD KEY `Activity3` (`Activity3`),
  ADD KEY `Activity4` (`Activity4`),
  ADD KEY `Activity5` (`Activity5`);

--
-- Indexes for table `camper`
--
ALTER TABLE `camper`
  ADD PRIMARY KEY (`CamperID`),
  ADD KEY `ActivitySelectionID` (`ActivitySelectionID`);

--
-- Indexes for table `camp_session`
--
ALTER TABLE `camp_session`
  ADD PRIMARY KEY (`SessionID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activity`
--
ALTER TABLE `activity`
  MODIFY `ActivityID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `activity_selection`
--
ALTER TABLE `activity_selection`
  MODIFY `ActivitySelectionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `camper`
--
ALTER TABLE `camper`
  MODIFY `CamperID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `camp_session`
--
ALTER TABLE `camp_session`
  MODIFY `SessionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `activity_selection`
--
ALTER TABLE `activity_selection`
  ADD CONSTRAINT `activity_selection_ibfk_1` FOREIGN KEY (`CamperID`) REFERENCES `camper` (`CamperID`),
  ADD CONSTRAINT `activity_selection_ibfk_2` FOREIGN KEY (`Activity1`) REFERENCES `activity` (`ActivityID`),
  ADD CONSTRAINT `activity_selection_ibfk_3` FOREIGN KEY (`Activity2`) REFERENCES `activity` (`ActivityID`),
  ADD CONSTRAINT `activity_selection_ibfk_4` FOREIGN KEY (`Activity3`) REFERENCES `activity` (`ActivityID`),
  ADD CONSTRAINT `activity_selection_ibfk_5` FOREIGN KEY (`Activity4`) REFERENCES `activity` (`ActivityID`),
  ADD CONSTRAINT `activity_selection_ibfk_6` FOREIGN KEY (`Activity5`) REFERENCES `activity` (`ActivityID`);

--
-- Constraints for table `camper`
--
ALTER TABLE `camper`
  ADD CONSTRAINT `camper_ibfk_1` FOREIGN KEY (`ActivitySelectionID`) REFERENCES `activity_selection` (`ActivitySelectionID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
