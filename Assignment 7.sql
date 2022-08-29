----------Assignment 7


-----------To solve below queries use “sales” database

-- USE sales_db;

/* Q. 1) Write a query that lists each order number followed by the name of the customer who made the
order. */

/*

SELECT orders.onum, customers.cname
FROM orders, customers
WHERE orders.cnum = customers.cnum;

*/



/* Q. 2) Write a query that gives the names of both the salesperson and the customer for each order along
with the order number. */

/*

SELECT sname, cname, onum
FROM orders o, customers c, salespeople s
WHERE o.snum=c.snum
  AND o.snum=s.snum;

*/

/* Q. 3) Write a query that produces all customers serviced by salespeople with a commission above 12%.
Output the customer’s name, the salesperson’s name, and the salesperson’s rate of commission. */

/*

select cname, sname, comm 
from customers c, salespeople s
where c.snum = s.snum
AND comm > .12;

*/


/* Q. 4) Write a query that calculates the amount of the salesperson’s commission on each order by a
customer with a rating above 100. */

/*

SELECT (amt * comm/100), comm
FROM salespeople
JOIN orders USING(snum)
JOIN customers USING(snum)
WHERE rating > 100;

*/

/* Q. 5) Write a query that produces all pairs of salespeople who are living in the same city.Exclude
combinations of salespeople with themselves as well as duplicate rows with the order reversed. */

/*

SELECT m.sname, n.sname, m.city
FROM salespeople m, salespeople n
WHERE m.city = n.city
  AND m.sname < n.sname;

  */


