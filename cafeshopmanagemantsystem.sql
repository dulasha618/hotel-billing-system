-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 19, 2023 at 11:15 AM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cafeshopmanagemantsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminlogin`
--

CREATE TABLE `adminlogin` (
  `id` int(11) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `adminlogin`
--

INSERT INTO `adminlogin` (`id`, `user_name`, `password`) VALUES
(1, 'Indushani', '5678');

-- --------------------------------------------------------

--
-- Table structure for table `cashierinfo`
--

CREATE TABLE `cashierinfo` (
  `caid` int(11) NOT NULL,
  `cpicture` blob NOT NULL,
  `cashier_name` varchar(45) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cashierinfo`
--

INSERT INTO `cashierinfo` (`caid`, `cpicture`, `cashier_name`, `telephone`, `user_name`, `password`) VALUES
(1, '', 'Dulash', '0705908618', 'dulasha', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `catid` int(11) NOT NULL,
  `category_name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`catid`, `category_name`) VALUES
(1, 'Soup'),
(2, 'Shawarma'),
(3, 'Salads'),
(4, 'Smoothies'),
(5, 'Burgers'),
(6, 'Submarine'),
(7, 'Fresh Juice'),
(8, 'Hot & Cold beverages'),
(9, 'MilkShakes'),
(10, 'Bubble Tea'),
(11, 'fresh Juice');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cusid` int(11) NOT NULL,
  `price` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `changes` double NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `oid` int(11) NOT NULL,
  `prid` int(11) NOT NULL,
  `product_name` varchar(30) NOT NULL,
  `category` int(11) NOT NULL,
  `price` double NOT NULL,
  `order_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `prid` int(11) NOT NULL,
  `picture` blob NOT NULL,
  `product_name` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  `category` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`prid`, `picture`, `product_name`, `price`, `category`) VALUES
(1, '', 'Cream Of Vegetable', '200', 'Soup'),
(2, '', 'Cream Of Chicken', '250', 'Soup'),
(3, '', 'Hot & Spicy Seafood', '270', 'Soup'),
(4, '', 'Vegetable Shawarma', '230', 'Shawarma'),
(5, '', 'Vegetable & Egg Shawarma', '250', 'Shawarma'),
(6, '', ' Chicken Shawarma', '300', 'Shawarma'),
(7, '', 'Beef Shawarma', '300', 'Shawarma'),
(8, '', 'Seafood Shawarma', '350', 'Shawarma'),
(9, '', 'Garden Salad', '200', 'Salads'),
(10, '', 'Caesar Salad', '300', 'Salads'),
(11, '', 'Tuna Melon Potato Salad', '350', 'Salads'),
(12, '', 'Mango', '250', 'Smoothies'),
(13, '', 'Pineapple', '250', 'Smoothies'),
(14, '', 'Papaya', '200', 'Smoothies'),
(15, '', 'Vegetable Burger', '280', 'Burgers'),
(16, '', 'Chicken Burger', '300', 'Burgers'),
(17, '', 'Beef Burger', '300', 'Burgers'),
(18, '', 'Crab Burger', '350', 'Burgers'),
(19, '', 'London Burger', '400', 'Burgers'),
(20, '', 'Chicken Submarine', '350', 'Submarine'),
(21, '', 'Beef Submarine', '350', 'Submarine'),
(22, '', 'Seafood Submarine', '400', 'Submarine'),
(23, '', 'Lime Juice', '150', 'Fresh Juice'),
(24, '', 'Papaya Juice', '150', 'Fresh Juice'),
(25, '', 'Pineapple Juice', '150', 'Fresh Juice'),
(26, '', 'Mango ', '150', 'Fresh Juice'),
(27, '', 'Mixed Fruit Juice', '150', 'Fresh Juice'),
(28, '', 'Orange Juice', '150', 'Fresh Juice'),
(29, '', 'Plain Tea', '60', 'Hot & Cold beverages'),
(30, '', 'Tea with Milk', '100', 'Hot & Cold beverages'),
(31, '', 'Nescafe', '150', 'Hot & Cold beverages'),
(32, '', 'Hot chocolate', '180', 'Hot & Cold beverages'),
(33, '', 'Iced Coffee', '180', 'Hot & Cold beverages'),
(34, '', 'Vanila', '250', 'MilkShakes'),
(35, '', 'Chocolate', '250', 'MilkShakes'),
(36, '', 'Strawberry', '250', 'MilkShakes'),
(37, '', 'Street Shake', '300', 'MilkShakes');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adminlogin`
--
ALTER TABLE `adminlogin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cashierinfo`
--
ALTER TABLE `cashierinfo`
  ADD PRIMARY KEY (`caid`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`catid`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cusid`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`oid`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`prid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adminlogin`
--
ALTER TABLE `adminlogin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `cashierinfo`
--
ALTER TABLE `cashierinfo`
  MODIFY `caid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `catid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `oid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `prid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
