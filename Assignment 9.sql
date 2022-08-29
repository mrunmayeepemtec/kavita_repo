--------Assignment 9

--------use "sales" database to solve below queries.

-- USE sales_db;

/* Q. 1) Create an index that will enable a user to pull orders for ‘1990-10-03’ out of the Orders table
quickly. */

/*
CREATE index d_order
ON orders(odate);

*/


/* Q. 2) If the Orders table has already been created, how can you force the onum field to be unique
(assume all current values are unique)? */


/*

CREATE UNIQUE INDEX abc 
ON orders(onum);

*/

/* Q. 3) Create an index that would permit salesperson to retrieve his orders. */

/*

CREATE INDEX ord_snum 
ON orders(snum);

*/

/* Q. 4) Let us assume that each salesperson is to have only one customer of a given rating, and that this is
currently the case. Create an index that enforces it. */

/*

CREATE INDEX cust_s_c_r 
ON customers(snum, cnum, rating);

*/

/* Q. 5) Create an index to speed up searching order on a given date by given customer. */

/*

CREATE INDEX ord_cnum
ON orders(cnum);

*/