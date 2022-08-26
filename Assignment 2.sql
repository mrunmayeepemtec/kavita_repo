---------Assignment 2

/* Q.1) Create 'product_db' database */

--------CREATE DATABASE Product_db;

---------USE Product_db;

/* Q. 2) create following tables */

/* categories: id(PK), title, description */

/*

CREATE TABLE Categories (
    ID INTEGER PRIMARY KEY,
    Title VARCHAR(255),
    Description VARCHAR(255)
);

*/

-------SELECT * FROM Categories;

/* products: id(PK), title, price, description, category(FK), company */

/*
CREATE TABLE Products(
--     ID INTEGER PRIMARY KEY,
--     Title VARCHAR(25),
--     Price DECIMAL(10, 2),
--     Description VARCHAR(100), 
--     CategoryID INTEGER,
--     FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
-- );


*/

----------SELECT * FROM Products;

/* orders: id(PK), total, date */

/*

CREATE TABLE Orders(
    ID INTEGER PRIMARY KEY,
    Total DECIMAL(10, 2),
    Date DATE
);
*/

--------SELECT * FROM Orders;

/* order_details: id(PK), orderID(FK), productID(FK), quantity, price, totalPrice, discount */

/*

CREATE TABLE Order_details(
    ID INTEGER PRIMARY KEY,
    OrderID INTEGER,
    FOREIGN KEY (OrderID) REFERENCES Orders(ID),
    ProductID INTEGER,
    FOREIGN KEY (ProductID) REFERENCES Products (ID),
    Quantity INTEGER,
    Price DECIMAL(10, 2),
    TotalPrice DECIMAL(10, 2),
    Discount INTEGER
);
*/

-----------SELECT * FROM Order_details;

/* Q> 4) Add Some Dummy Data */

/*

INSERT INTO Categories(ID, Title, Description)
VALUES
(1, 'Home & Kitchen', 'To Store, Prepare & Cook Food'),
(2, 'Beauty & Personal Care', 'Anything done for you thas of a personal nature'),
(3, 'Toys & Games', 'Think Large'),
(4, 'Clothing', 'Keeping infectious away from the body'),
(5, 'Shoes', 'Most famous shoe brand in the world'),
(6, 'Jewelry', 'Highest brand in terms of resale'),
(7, 'Health', 'Boosts Immunity'),
(8, 'Sports', 'Pursued for goals'),
(9, 'Arts', 'Also Called Visual Art'),
(10, 'Books', 'Recording Information in the form of Writing or Images');

*/



------------SELECT * FROM Categories;

/*

INSERT INTO Products(ID, Title, Price, Description, CategoryID) 
VALUES
(1, 'Microwave', 20.00, 'To Store, Prepare & Cook Food', 1),
(2, 'Moisturisers', 15.00, 'Anything done for you thas of a personal nature', 2),
(3, 'Barbie Doll', 17.00, 'Think Large', 3),
(4, 'Cotton Dress', 50.00, 'Keeping infectious away from the body', 4),
(5, 'Footwear', 80.00, 'Most famous shoe brand in the world', 5),
(6, 'Necklace', 90.00, 'Highest brand in terms of resale', 6),
(7, 'Coconut Water', 89.00, 'Boosts Immunity', 7),
(8, 'Sticks', 67.00, 'Pursued for goals', 8),
(9, 'Drawing Paer', 78.00, 'Also Called Visual Art', 9),
(10, 'A Throne', 45.00, 'Recording Information in the form of Writing or Images', 10);

*/

-----SELECT * FROM Products;

/*

INSERT INTO Orders (ID, Total, Date)
VALUES
(1, 100.00, '2022-01-01'),
(2, 75.00, '2022-02-02'),
(3, 85.00, '2022-03-03'),
(4, 250.00, '2022-04-04'),
(5, 400.00, '2022-05-05'),
(6, 450.00, '2022-06-06'),
(7, 445.00, '2022-07-07'),
(8, 335.00, '2022-08-08'),
(9, 390.00, '2022-09-09'),
(10, 225.00, '2022-10-10');

*/

-------------SELECT * FROM Orders;

/*

INSERT INTO Order_details(ID, OrderID, ProductID, Quantity, Price, TotalPrice, Discount)
VALUES
(1, 1, 1, 5, 20.00, 100.00, 10),
(2, 2, 2, 5, 15.00, 75.00, 10),
(3, 3, 3, 5, 17.00, 85.00, 10),
(4, 4, 4, 5, 50.00, 250.00, 10),
(5, 5, 5, 5, 80.00, 400.00, 10),
(6, 6, 6, 5, 90.00, 450.00, 10),
(7, 7, 7, 5, 89.00, 445.00, 10),
(8, 8, 8, 5, 67.00, 335.00, 10),
(9, 9, 9, 5, 78.00, 390.00, 10),
(10, 10, 10, 5, 45.00, 225.00, 10);

*/

----------------SELECT * FROM Order_details;






