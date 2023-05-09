-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2023 at 12:22 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos_system`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddCategory` (IN `catname` VARCHAR(50), IN `catdesc` VARCHAR(255))  BEGIN
INSERT INTO category (cat_id,cat_name,cat_description) VALUES (NULL,catname,catdesc);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddEmployee` (IN `uname` VARCHAR(50), IN `upass` VARCHAR(50), IN `roleid` INT)  BEGIN
INSERT INTO employee
VALUES(NULL,uname, upass,roleid);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddProduct` (IN `prodname` VARCHAR(50), IN `prodprice` DOUBLE, IN `prodstock` INT, IN `prodcategory` INT)  BEGIN
INSERT INTO product (prod_id,prod_name,prod_price,prod_stock,prod_category_id) VALUES (NULL,prodname,prodprice,prodstock,prodcategory);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateSale` (IN `saleamount` DOUBLE, IN `salediscount` INT, IN `saledate` DATE, IN `saletime` TIME, IN `salecashier` INT)  BEGIN
INSERT INTO sale (sale_id,sale_total_amount,sale_discount_percent,sale_date,
                  sale_time,sale_cashier_id) VALUES (NULL,saleamount,salediscount,saledate,saletime,salecashier);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateSaleProduct` (IN `sale` INT, IN `product` INT, IN `productquantity` INT)  BEGIN
INSERT INTO sale_product (sale_id,prod_id,prod_qty) VALUES (sale,product,productquantity);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteEmployee` (IN `empid` INT)  BEGIN
DELETE FROM employee WHERE employee.emp_id=empid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteProduct` (IN `prodid` INT)  BEGIN
DELETE FROM product where prod_id =prodid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUserAuth` (IN `uname` VARCHAR(50), IN `upass` VARCHAR(50))  BEGIN
SELECT ID,Username,Userrole FROM employee_details_view WHERE Username=uname AND Userpass=upass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateEmployee` (IN `uid` INT, IN `uname` VARCHAR(50), IN `upass` VARCHAR(50), IN `urole` INT)  BEGIN
UPDATE employee set
employee.emp_uname=uname,
employee.emp_upass=upass,
employee.emp_role_id=urole
WHERE
employee.emp_id= uid;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateProduct` (IN `prodid` INT, IN `prodname` VARCHAR(50), IN `prodprice` DOUBLE, IN `prodstock` INT)  BEGIN
UPDATE product set
product.prod_name=
CASE WHEN LENGTH(prodname)>0 THEN prodname ELSE product.prod_name END,product.prod_price=
CASE WHEN prodprice is not null THEN prodprice ELSE product.prod_price END,
product.prod_stock=
CASE WHEN prodstock is not null THEN prodstock ELSE product.prod_stock END
WHERE
product.prod_id = prodid;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `cat_id` int(11) NOT NULL,
  `cat_name` varchar(50) DEFAULT NULL,
  `cat_description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`cat_id`, `cat_name`, `cat_description`) VALUES
(2, 'Smartphones', 'Handheld mobile devices'),
(3, 'Laptops', 'Powerful and portable computers'),
(4, 'Computer Accessories', 'Keyboards, Mice, Headsets, etc.'),
(5, 'Gaming Consoles', 'Gaming consoles, handhelds, and console accessories.'),
(6, 'Kitchen Appliances', 'Kitchen sutff');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL,
  `emp_uname` varchar(50) DEFAULT NULL,
  `emp_upass` varchar(50) DEFAULT NULL,
  `emp_role_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_id`, `emp_uname`, `emp_upass`, `emp_role_id`) VALUES
(1, 'Admin', '123', 1),
(2, 'Luke', '123', 2),
(3, 'Sam', '123', 3),
(5, 'Josh', '123', 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `employee_details_view`
-- (See below for the actual view)
--
CREATE TABLE `employee_details_view` (
`ID` int(11)
,`Username` varchar(50)
,`Userpass` varchar(50)
,`Userrole` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `prod_id` int(11) NOT NULL,
  `prod_name` varchar(50) DEFAULT NULL,
  `prod_price` double DEFAULT NULL,
  `prod_stock` int(11) DEFAULT NULL,
  `prod_category_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`prod_id`, `prod_name`, `prod_price`, `prod_stock`, `prod_category_id`) VALUES
(2, 'Asus Vivobook 15', 5600, 17, 3),
(3, 'Samsung Galaxy S20', 3000, 4, 2),
(4, 'Logitech G502 Gaming Mouse', 30, 50, 4),
(5, 'Razer Kraken Headset', 180, 50, 4),
(6, 'Glorious Model O Gaming Mouse', 350, 50, 4),
(7, 'Sony Playstation 5', 2000, 1000, 5),
(8, 'Microsoft Xbox Series X', 2500, 1000, 5),
(9, 'Nintendo Switch OLED', 600, 30, 5),
(10, 'Dell XPS 15', 3500, 59, 3);

-- --------------------------------------------------------

--
-- Stand-in structure for view `product_details_view`
-- (See below for the actual view)
--
CREATE TABLE `product_details_view` (
`ID` int(11)
,`Product` varchar(50)
,`Price` double
,`Stock` int(11)
,`Category` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `role_id` int(11) NOT NULL,
  `role_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`role_id`, `role_name`) VALUES
(1, 'Admin'),
(2, 'Manager'),
(3, 'Cashier');

-- --------------------------------------------------------

--
-- Table structure for table `sale`
--

CREATE TABLE `sale` (
  `sale_id` int(11) NOT NULL,
  `sale_total_amount` double DEFAULT NULL,
  `sale_discount_percent` int(11) DEFAULT NULL,
  `sale_date` date DEFAULT NULL,
  `sale_time` time DEFAULT NULL,
  `sale_cashier_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sale`
--

INSERT INTO `sale` (`sale_id`, `sale_total_amount`, `sale_discount_percent`, `sale_date`, `sale_time`, `sale_cashier_id`) VALUES
(2, 14200, 0, '2023-05-09', '06:18:00', 3),
(3, 112000, 0, '2023-05-09', '06:55:00', 3),
(4, 112000, 0, '2023-05-09', '06:57:00', 3),
(5, 60, 0, '2023-05-09', '07:26:00', 3),
(6, 120000, 0, '2023-05-09', '07:27:00', 3),
(7, 51300, 0, '2023-05-09', '10:48:00', 3);

-- --------------------------------------------------------

--
-- Stand-in structure for view `sale_details_view`
-- (See below for the actual view)
--
CREATE TABLE `sale_details_view` (
`ID` int(11)
,`Cashier` varchar(50)
,`Total` double
,`Discount Percentage` int(11)
,`Date` date
,`Time` time
);

-- --------------------------------------------------------

--
-- Table structure for table `sale_product`
--

CREATE TABLE `sale_product` (
  `sale_id` int(11) DEFAULT NULL,
  `prod_id` int(11) DEFAULT NULL,
  `prod_qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sale_product`
--

INSERT INTO `sale_product` (`sale_id`, `prod_id`, `prod_qty`) VALUES
(2, 2, 2),
(2, 3, 1),
(3, 2, 20),
(4, 2, 20),
(5, 4, 2),
(6, 3, 40),
(7, 2, 8),
(7, 3, 1),
(7, 10, 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `sale_products_view`
-- (See below for the actual view)
--
CREATE TABLE `sale_products_view` (
`ID` int(11)
,`Product` varchar(50)
,`Price` double
,`Quantity` int(11)
,`Total Amount` double
);

-- --------------------------------------------------------

--
-- Structure for view `employee_details_view`
--
DROP TABLE IF EXISTS `employee_details_view`;

CREATE VIEW `employee_details_view`  AS SELECT `employee`.`emp_id` AS `ID`, `employee`.`emp_uname` AS `Username`, `employee`.`emp_upass` AS `Userpass`, `role`.`role_name` AS `Userrole` FROM (`employee` join `role`) WHERE `employee`.`emp_role_id` = `role`.`role_id` ;

-- --------------------------------------------------------

--
-- Structure for view `product_details_view`
--
DROP TABLE IF EXISTS `product_details_view`;

CREATE VIEW `product_details_view`  AS SELECT `product`.`prod_id` AS `ID`, `product`.`prod_name` AS `Product`, `product`.`prod_price` AS `Price`, `product`.`prod_stock` AS `Stock`, `category`.`cat_name` AS `Category` FROM (`product` join `category`) WHERE `product`.`prod_category_id` = `category`.`cat_id` ;

-- --------------------------------------------------------

--
-- Structure for view `sale_details_view`
--
DROP TABLE IF EXISTS `sale_details_view`;

CREATE VIEW `sale_details_view`  AS SELECT `sale`.`sale_id` AS `ID`, `employee`.`emp_uname` AS `Cashier`, `sale`.`sale_total_amount` AS `Total`, `sale`.`sale_discount_percent` AS `Discount Percentage`, `sale`.`sale_date` AS `Date`, `sale`.`sale_time` AS `Time` FROM (`employee` join `sale`) WHERE `employee`.`emp_id` = `sale`.`sale_cashier_id` ;

-- --------------------------------------------------------

--
-- Structure for view `sale_products_view`
--
DROP TABLE IF EXISTS `sale_products_view`;

CREATE VIEW `sale_products_view`  AS SELECT `sale_product`.`sale_id` AS `ID`, `product`.`prod_name` AS `Product`, `product`.`prod_price` AS `Price`, `sale_product`.`prod_qty` AS `Quantity`, `product`.`prod_price`* `sale_product`.`prod_qty` AS `Total Amount` FROM (`sale_product` join `product`) WHERE `sale_product`.`prod_id` = `product`.`prod_id` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`cat_id`),
  ADD UNIQUE KEY `cat_name` (`cat_name`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`),
  ADD UNIQUE KEY `emp_uname` (`emp_uname`),
  ADD KEY `emp_role_id` (`emp_role_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`prod_id`),
  ADD UNIQUE KEY `prod_name` (`prod_name`),
  ADD KEY `prod_category_id` (`prod_category_id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`role_id`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `sale_cashier_id` (`sale_cashier_id`);

--
-- Indexes for table `sale_product`
--
ALTER TABLE `sale_product`
  ADD KEY `sale_id` (`sale_id`),
  ADD KEY `prod_id` (`prod_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `cat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `sale`
--
ALTER TABLE `sale`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`emp_role_id`) REFERENCES `role` (`role_id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`prod_category_id`) REFERENCES `category` (`cat_id`);

--
-- Constraints for table `sale`
--
ALTER TABLE `sale`
  ADD CONSTRAINT `sale_ibfk_1` FOREIGN KEY (`sale_cashier_id`) REFERENCES `employee` (`emp_id`);

--
-- Constraints for table `sale_product`
--
ALTER TABLE `sale_product`
  ADD CONSTRAINT `sale_product_ibfk_1` FOREIGN KEY (`sale_id`) REFERENCES `sale` (`sale_id`),
  ADD CONSTRAINT `sale_product_ibfk_2` FOREIGN KEY (`sale_id`) REFERENCES `sale` (`sale_id`),
  ADD CONSTRAINT `sale_product_ibfk_3` FOREIGN KEY (`prod_id`) REFERENCES `product` (`prod_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
