-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2023 at 12:18 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eats2go`
--

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ID` int(11) NOT NULL,
  `itemName` varchar(50) DEFAULT NULL,
  `itemType` varchar(50) DEFAULT NULL,
  `itemCost` varchar(50) DEFAULT NULL,
  `itemQuantity` varchar(50) DEFAULT NULL,
  `itemExpiry` varchar(50) DEFAULT NULL,
  `itemReceivedDate` varchar(50) DEFAULT NULL,
  `itemSupplier` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ID`, `itemName`, `itemType`, `itemCost`, `itemQuantity`, `itemExpiry`, `itemReceivedDate`, `itemSupplier`) VALUES
(1, 'Tomato', 'Fruit', '88.00', '24', '07-1-23', '06-14-23', 'NutriAsia INC'),
(2, 'Chicken Breast', 'Ingredient', '137.00', '12', '07-2-23', '06-16-23', 'Magnolia'),
(4, 'Ground Beef', 'Meat', '300', '10', '09-23-23', '07-25-23', 'Meat Depot');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `ID` int(11) NOT NULL,
  `saleID` varchar(20) DEFAULT NULL,
  `soldItem` varchar(50) DEFAULT NULL,
  `saleCost` varchar(50) DEFAULT NULL,
  `soldQuantity` varchar(50) DEFAULT NULL,
  `saleDate` varchar(50) DEFAULT NULL,
  `seller` varchar(50) DEFAULT NULL,
  `buyer` varchar(50) DEFAULT NULL,
  `tax` varchar(50) DEFAULT NULL,
  `paymentType` varchar(50) DEFAULT NULL,
  `paymentChange` varchar(50) DEFAULT NULL,
  `saleSubTotal` varchar(50) DEFAULT NULL,
  `saleTotal` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
