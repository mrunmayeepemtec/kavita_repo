------------Assignment 8

--------------To solve below queries use "sales" database

-------------USE sales_db;

/* Q. 1) Write a query that uses a subquery to obtain all orders for the customer named Cisneros. Assume
you do not know his customer number (cnum). */

/*

SELECT cnum, onum AS all_orders
FROM  orders
WHERE cnum = (SELECT cnum
    FROM customers
    WHERE cname = 'Cisneros');

*/

/* Q. 2) Write a query that uses a subquery to obtain all orders for the customer named Cisneros. Assume
you do not know his customer number (cnum). */

/*

SELECT cname, rating
FROM customers
WHERE cnum IN (SELECT cnum
    FROM orders
    WHERE amt > (SELECT avg(amt)
    FROM orders));

*/

/* Q. 3) Write a query that selects the total amount in orders for each salesperson for whom this total is
greater than the amount of the largest order in the table. */

/*

SELECT sum(amt)
FROM orders
GROUP BY snum
HAVING sum(amt) > (SELECT max(amt)
        FROM orders);

*/

/* Q. 4) Write a query that selects all customers whose ratings are equal to or greater than ANY of Serres. */

/*

SELECT * 
FROM customers
WHERE rating >= ANY (SELECT rating
    FROM customers
    WHERE snum IN
    (SELECT snum
    FROM salespeople
    WHERE sname = 'Serres'));

*/

/* Q. 5) Write a query using ANY or ALL that will find all salespeople who have no customers located in their city. *

/*

 SELECT *
 FROM salespeople
 WHERE city = ANY
    (SELECT city
    FROM customers);

*/

/* Q. 6) Write a query that selects all orders for amounts greater than any for the customers in London. */

/*

SELECT *
FROM orders
WHERE amt > ANY
    (SELECT amt
    FROM orders
    WHERE cnum IN
    (SELECT cnum
    FROM customers
    WHERE city = 'LONDON'));

/*

/* Q. 7) Extract all the orders of Motika. */

/*

SELECT onum 
FROM orders
WHERE snum = (SELECT snum 
            FROM salespeople 
            WHERE sname = 'MOTIKA');
    
*/

/* Q. 8) Find all the order attribute to salespeople servicing customers in London. */

/*

SELECT snum, cnum 
FROM orders
WHERE cnum IN (SELECT cnum
            FROM customers WHERE city = 'LONDON');

*/

/* Q. 9) Find names and numbers of all salesperson who have more than one customer. */

/*

SELECT sname, snum
FROM salespeople
WHERE snum in (SELECT snum
            FROM customers 
            GROUP BY snum
            HAVING COUNT (snum) > 1);

*;

/* Q. 10)  Find salespeople number,name and city who have multiple customers. */

/*

SELECT snum, sname, city
FROM salespeople
WHERE snum IN (SELECT snum
FROM customers 
GROUP BY snum
HAVING COUNT(*) > 1);

*/

/* Q. 11) Select customers who have a greater rating than any other customer in Rome. */

/*

SELECT cname
FROM customers
WHERE city = 'ROME' AND 
            rating > (SELECT MAX(rating)
            FROM customers
            WHERE city != 'Rome');

*/

/* Q. 12) Select all orders that had amounts that were greater that at least one of the orders from ‘1990-10-04’ . */

/*

SELECT onum, amt
FROM orders
WHERE odate != '1990-10-04' AND
amt > (SELECT MIN(amt)
        FROM orders
        WHERE odate = '1990-10-04');
*/

/* Q. 13) Find all orders with amounts smaller than any amount for a customer in San Jose. */

/*

SELECT onum, amt
FROM orders
WHERE amt < (SELECT MAX(amt)
    FROM orders, customers
    WHERE city = 'San Jose' AND
    orders.cnum = customers.cnum);

*/

/* Q. 14)  Select those customers whose rating are higher than every customer in Paris */

/*

SELECT * FROM customers
WHERE rating > ANY (SELECT
                    rating FROM customers
                    WHERE city = 'Paris');

*/






