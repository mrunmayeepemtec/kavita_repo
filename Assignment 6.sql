--------Assignment 6

-- USE sales_db;

-------To solve below queries use “sales” database

/* Q. 1) Write a query that counts the number of salespeople registering orders for each day. (If a
salesperson has more than one order on a given day, he or she should be counted only once.). */

/*

SELECT odate, snum, COUNT(*) AS total
FROM orders AS a
GROUP BY odate, snum;

*/


/* Q. 2) Write a query on the Customers table that will find the highest rating in each city. Put the output in
this form:
For the city (city), the highest rating is : (rating). */

/*

SELECT city, MAX(rating) AS Highest_rating
FROM customers
GROUP BY city;

*/

/* Q. 3) Write a query that totals the orders for each day and places the results in descending order. */

/*

SELECT odate, count(odate) AS total_orders
FROM orders
GROUP BY odate
ORDER BY total_orders  DESC;

*/

/* Q. 4) Write a query that selects the total amount in orders for each salesperson for whom this total is
greater than the amount of the largest order in the table. */

/*

SELECT sum(amt)
FROM orders
GROUP BY snum
HAVING sum(amt)>
  (SELECT max(amt)
   FROM orders);

*/

/* Q. 5) Write a query that selects the highest rating in each city. */

/*

SELECT city, MAX(rating) AS highest_rating
FROM customers 
GROUP BY city;

*/

/* Q. 6) Largest order taken by each salesperson with order value more than Rs.3000. */

/*

SELECT odate, snum, MAX(amt) AS largest_order
FROM orders
WHERE amt > 3000
GROUP BY odate, snum
ORDER BY odate,snum;

*/

/* Q. 7) Select each customer smallest order. */

/*

SELECT cnum, min(amt)
FROM orders
GROUP BY cnum;

*/

