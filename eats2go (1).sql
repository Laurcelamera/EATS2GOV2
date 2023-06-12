-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2023 at 07:22 PM
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
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `ID` int(11) NOT NULL,
  `ItemName` varchar(50) DEFAULT NULL,
  `itemType` varchar(50) DEFAULT NULL,
  `itemPrice` varchar(50) DEFAULT NULL,
  `itemQuantity` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`ID`, `ItemName`, `itemType`, `itemPrice`, `itemQuantity`) VALUES
(1, 'EATS2GO Taco', 'Food', '60.00', '10'),
(2, 'EATS2GO Pita Wraps', 'Food', '78.00', '6'),
(3, 'Lemonade', 'Drink', '55.00', '10'),
(4, 'EATS2GO Sandwich', 'food', '25.00', '15'),
(6, 'Buko Juice', 'Drink', '15.00', '10');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `id` int(11) NOT NULL,
  `item_name` varchar(255) DEFAULT NULL,
  `price` double DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `transaction_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`id`, `item_name`, `price`, `quantity`, `transaction_date`) VALUES
(25, 'EATS2GO Pita Wraps', 69, 1, '2023-06-11 18:31:50'),
(26, 'EATS2GO Sandwich', 35, 1, '2023-06-11 18:31:50'),
(27, 'EATS2GO Pita Wraps', 69, 1, '2023-06-11 18:46:03'),
(28, 'EATS2GO CHICKEN PESTO', 110, 1, '2023-06-11 18:57:32'),
(29, 'CORN DOG', 59, 1, '2023-06-11 18:57:32'),
(30, 'EATS2GO Pita Wraps', 69, 1, '2023-06-11 19:00:31'),
(31, 'EATS2GO Sandwich', 35, 1, '2023-06-11 19:00:31'),
(32, 'HALO-HALO', 150, 1, '2023-06-11 19:13:07'),
(33, 'HALO-HALO', 150, 1, '2023-06-11 19:22:56'),
(34, 'CARAMEL SUNDAE', 40, 1, '2023-06-11 19:22:56'),
(35, 'BUKO JUICE', 25, 1, '2023-06-11 20:26:16'),
(36, 'HALO-HALO', 150, 2, '2023-06-11 20:26:45'),
(37, 'EGG DROP SANDWICH', 80, 1, '2023-06-12 07:35:48'),
(38, 'EATS2GO CHICKEN PESTO', 110, 1, '2023-06-12 07:35:48'),
(39, 'BUKO JUICE', 25, 1, '2023-06-12 07:36:47'),
(40, 'CRANBERRY JUICE', 45, 1, '2023-06-12 07:36:47'),
(41, 'CARAMEL SUNDAE', 40, 1, '2023-06-12 07:37:26'),
(42, 'STRAWBERRY SUNDAE', 40, 1, '2023-06-12 07:37:26'),
(43, 'BUTTER TARTS', 30, 1, '2023-06-12 07:37:26'),
(44, 'EATS2GO Sandwich', 35, 2, '2023-06-12 07:38:18'),
(45, 'CORN DOG', 59, 2, '2023-06-12 07:38:18'),
(46, 'BUKO JUICE', 25, 1, '2023-06-12 17:20:16'),
(47, 'CRANBERRY JUICE', 60, 1, '2023-06-12 17:20:16'),
(48, 'BUKO JUICE', 25, 2, '2023-06-12 17:41:00'),
(49, 'HALO-HALO', 150, 1, '2023-06-12 17:41:26'),
(50, 'STRAWBERRY SUNDAE', 40, 1, '2023-06-12 17:41:26'),
(51, 'EATS2GO Pita Wraps', 69, 1, '2023-06-12 18:32:13'),
(52, 'EATS2GO Sandwich', 35, 1, '2023-06-12 18:32:13'),
(53, 'EATS2GO Pita Wraps', 69, 2, '2023-06-12 18:36:06'),
(54, 'EATS2GO CHICKEN PESTO', 110, 1, '2023-06-12 18:36:06'),
(55, 'CORN DOG', 59, 5, '2023-06-12 18:39:59'),
(56, 'EATS2GO Pita Wraps', 69, 1, '2023-06-12 18:41:33'),
(57, 'EATS2GO Sandwich', 35, 1, '2023-06-12 18:41:33'),
(58, 'EATS2GO Pita Wraps', 69, 1, '2023-06-12 18:44:18'),
(59, 'EATS2GO Pita Wraps', 69, 1, '2023-06-12 18:46:15'),
(60, 'CORN DOG', 59, 1, '2023-06-12 18:46:15'),
(61, 'HALO-HALO', 150, 1, '2023-06-12 18:51:06'),
(62, 'CARAMEL SUNDAE', 40, 1, '2023-06-12 18:51:06'),
(63, 'HALO-HALO', 150, 1, '2023-06-12 18:51:46'),
(64, 'BUTTER TARTS', 30, 5, '2023-06-12 18:51:47'),
(65, 'BUKO JUICE', 25, 2, '2023-06-12 18:56:16'),
(66, 'EATS2GO Pita Wraps', 69, 1, '2023-06-12 18:58:21'),
(67, 'EATS2GO Sandwich', 35, 1, '2023-06-12 18:58:21'),
(68, 'HALO-HALO', 150, 1, '2023-06-12 19:49:45'),
(69, 'CARAMEL SUNDAE', 40, 1, '2023-06-12 19:49:46'),
(70, 'BUKO JUICE', 25, 10, '2023-06-13 00:56:21'),
(71, 'EATS2GO TACO', 70, 10, '2023-06-13 00:57:02');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
