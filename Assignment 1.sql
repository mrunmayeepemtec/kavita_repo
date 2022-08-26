-------Assignment 1

/* Q. 1) Create 'stuent_db' database */

------CREATE DATABASE Student_db;

/* Q.2) Create following tables in database with proper data types */

/*
CREATE TABLE Student (
    ID INteger PRIMARY KEY,
    Name VARCHAR(255),
    Address VARCHAR(255),
    Phone VARCHAR(255),
    Email VARCHAR(255),
    Age INTEGER,
    SchoolID INTEGER,
    FOREIGN KEY (SchoolID) REFERENCES School (ID)
);
*/

/*
CREATE TABLE School (
    ID INTEGER PRIMARY KEY,
    Name VARCHAR(255),
    Address VARCHAR(255),
    Principal VARCHAR(255),
    Phone VARCHAR(255)
);
 */

----SELECT * FROM School;

------SELECT * FROM student;

/* Q> 4) add some dummy data */

/*
INSERT INTO School (ID, Name, Address, Principal, Phone)
VALUES
(1, 'SIBAR', 'Pune', 'Shine', '1234567890'),
(2, 'D.Y.Patil', 'Pune', 'Patil', '3456789982'),
(3, 'B.K.D', 'Latur', 'Patil', '2345678901'),
(4, 'MIT', 'Pune', 'Dake', '8907654321'),
(5, 'SIOM', 'Pune', 'Gutte', '3456789056');

*/

---------SELECT * FROM School;


/*

INSERT INTO Student (ID, Name, Address, Phone, Email, Age, SchoolID)
VALUES
(101, 'Kavita', 'Pune', '1234567667', 'kavita@123', 22, 1),
(102, 'Neha', 'Latur', '4567833222', 'neha@123', 25, 2),
(103, 'Prachi', 'Nashik0', '4522289873', 'prachi@123', 23, 3),
(104, 'Priyanka', 'Aurangabad', '234567883', 'priyanka@123', 24, 4),
(105, 'Rohini', 'Prali', '78889976778', 'rohini@123', 21, 5); 

*/

---------SELECT * FROM Student;
