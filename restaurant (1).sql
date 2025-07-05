-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2025 at 10:13 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `Cat_id` int(5) NOT NULL,
  `Cat_name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`Cat_id`, `Cat_name`) VALUES
(1, 'Chinese'),
(2, 'Burger'),
(3, 'Pizza'),
(4, 'Chowmein'),
(5, 'Dosa'),
(6, 'Uttapam');

-- --------------------------------------------------------

--
-- Table structure for table `menuitems`
--

CREATE TABLE `menuitems` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(25) NOT NULL,
  `Category` varchar(25) NOT NULL,
  `Price` int(6) DEFAULT NULL,
  `GST` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `menuitems`
--

INSERT INTO `menuitems` (`ItemID`, `ItemName`, `Category`, `Price`, `GST`) VALUES
(1, 'Cheese Burger', 'Burger', 50, 5),
(2, 'Veg Chowmein', 'Chowmein', 60, 5),
(3, 'Butter Chowmein', 'Chowmein', 80, 5),
(4, 'Paneer Chowmein', 'Chowmein', 90, 5),
(5, 'Chilli Garlic Chowmein', 'Chowmein', 80, 5),
(6, 'Paneer Dosa', 'Dosa', 100, 5),
(7, 'Rawa Paneer Dosa', 'Dosa', 130, 5),
(8, 'Butter Paneer Dosa', 'Dosa', 120, 5),
(9, 'Onion Uttapam', 'Uttapam', 80, 5),
(10, 'Onion Tomato Uttapam', 'Uttapam', 90, 5);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL,
  `Total_Item` int(5) NOT NULL,
  `TotalAmount` int(11) NOT NULL,
  `OrderDate` date NOT NULL DEFAULT current_timestamp(),
  `o_tableno` int(5) DEFAULT NULL,
  `Order_type` varchar(20) NOT NULL,
  `Customer_name` varchar(30) DEFAULT NULL,
  `Customer_Phone` varchar(15) DEFAULT NULL,
  `Payment_status` varchar(10) DEFAULT 'Not Paid',
  `Payment_method` varchar(12) DEFAULT NULL,
  `Paid_Amount` int(11) DEFAULT NULL,
  `Returned_Amount` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderID`, `Total_Item`, `TotalAmount`, `OrderDate`, `o_tableno`, `Order_type`, `Customer_name`, `Customer_Phone`, `Payment_status`, `Payment_method`, `Paid_Amount`, `Returned_Amount`) VALUES
(1001, 9, 1220, '2025-02-08', NULL, 'Home Delivery', 'Manish', '9875432546', 'Paid', 'Cash', 1250, 30),
(1002, 1, 52, '2025-02-08', 1, 'Dine in', NULL, NULL, 'Paid', 'UPI', 0, 0),
(1006, 2, 147, '2025-02-08', NULL, 'Home Delivery', 'Ravi Yadav', '9876543214', 'Paid', 'Cash', 147, 0),
(1007, 5, 409, '2025-02-08', NULL, 'Home Delivery', 'manish', '9658745855', 'Paid', 'Cash', 410, 1),
(1008, 2, 199, '2025-02-08', 1, 'Dine in', NULL, NULL, 'Not Paid', NULL, NULL, NULL),
(1009, 2, 189, '2025-02-10', NULL, 'Take away', NULL, NULL, 'Not Paid', NULL, NULL, NULL),
(1010, 2, 230, '2025-02-10', NULL, 'Take away', NULL, NULL, 'Not Paid', NULL, NULL, NULL),
(1011, 2, 231, '2025-02-10', NULL, 'Take away', NULL, NULL, 'Not Paid', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `role`) VALUES
(1, 'Cook'),
(2, 'Manager'),
(3, 'Waiter');

-- --------------------------------------------------------

--
-- Table structure for table `tables`
--

CREATE TABLE `tables` (
  `table_id` int(5) NOT NULL,
  `table_no` int(5) NOT NULL,
  `Available` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tables`
--

INSERT INTO `tables` (`table_id`, `table_no`, `Available`) VALUES
(1, 1, 0),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 1),
(6, 6, 1),
(7, 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `temp_orders`
--

CREATE TABLE `temp_orders` (
  `Order_id` int(11) NOT NULL,
  `ItemID` int(5) NOT NULL,
  `ItemName` varchar(25) NOT NULL,
  `Price` int(11) NOT NULL,
  `GST` int(3) NOT NULL,
  `Quantity` int(4) NOT NULL,
  `Amount` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `temp_orders`
--

INSERT INTO `temp_orders` (`Order_id`, `ItemID`, `ItemName`, `Price`, `GST`, `Quantity`, `Amount`) VALUES
(1003, 2, 'Veg Chowmein', 60, 5, 1, 63),
(1003, 3, 'Butter Chowmein', 80, 5, 1, 84),
(1007, 5, 'Chilli Garlic Chowmein', 80, 5, 1, 84),
(1007, 7, 'Rawa Paneer Dosa', 130, 5, 1, 136),
(1007, 2, 'Veg Chowmein', 60, 5, 3, 189),
(1008, 4, 'Paneer Chowmein', 90, 5, 1, 94),
(1008, 6, 'Paneer Dosa', 100, 5, 1, 105),
(1001, 6, 'Paneer Dosa', 100, 5, 1, 105),
(1002, 2, 'Veg Chowmein', 60, 5, 3, 189),
(1002, 7, 'Rawa Paneer Dosa', 130, 5, 1, 136),
(1009, 3, 'Butter Chowmein', 80, 5, 1, 84),
(1009, 6, 'Paneer Dosa', 100, 5, 1, 105),
(1010, 4, 'Paneer Chowmein', 90, 5, 1, 94),
(1010, 7, 'Rawa Paneer Dosa', 130, 5, 1, 136),
(1011, 6, 'Paneer Dosa', 100, 5, 1, 105),
(1011, 8, 'Butter Paneer Dosa', 120, 5, 1, 126);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(25) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Email` varchar(25) NOT NULL,
  `Phone_no` varchar(15) NOT NULL,
  `Role` varchar(20) NOT NULL,
  `Salary` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `Email`, `Phone_no`, `Role`, `Salary`) VALUES
(1, 'Abhishek', '123', 'abhishek@gmail.com', '9875432154', 'Admin', 0),
(2, 'Mohit', '123', 'mohit@gmail.com', '9876543215', 'Waiter', 123);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`Cat_id`);

--
-- Indexes for table `menuitems`
--
ALTER TABLE `menuitems`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tables`
--
ALTER TABLE `tables`
  ADD PRIMARY KEY (`table_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `Cat_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `menuitems`
--
ALTER TABLE `menuitems`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1012;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tables`
--
ALTER TABLE `tables`
  MODIFY `table_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
