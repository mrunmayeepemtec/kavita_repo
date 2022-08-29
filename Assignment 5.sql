------------Assignment 5

----USE hr_DB;

------------------To solve below queries use "hr" database.

/* Q. 1) Display first name and last name after converting the first letter of each name to upper case and
the rest to lower case. */

/*

SELECT UPPER(SUBSTRING(FIRST_NAME, 1, 1)) + LOWER(SUBSTRING(FIRST_NAME, 2, Len(FIRST_NAME)-1)) AS First_name,
UPPER(SUBSTRING(LAST_NAME, 1, 1)) + LOWER(SUBSTRING(LAST_NAME, 2, Len(LAST_NAME)-1)) AS Last_name
FROM employees;

*/

/* Q. 2) Display the first word in job title. */

/*

SELECT SUBSTRING(JOB_TITLE, 1, 1)
FROM jobs;

*/

/* Q. 3) Display the length of first name for employees where last name contain character ‘b’ after 3rd
position. */

/*

SELECT FIRST_NAME, LAST_NAME
FROM employees 
WHERE LAST_NAME LIKE '___b';

 */

/* Q. 4) Display first name in upper case and email address in lower case for employees where the first
name and email address are same irrespective of the case. */

/*

SELECT UPPER(FIRST_NAME) AS first_name, LOWER(EMAIL) AS email 
FROM employees 
WHERE UPPER(FIRST_NAME) = UPPER(EMAIL);

*/


/* Q. 5) Display first name, salary, and round the salary to thousands. */

/*

SELECT FIRST_NAME, SALARY, ROUND(SALARY, 1000)
FROM employees;

*/

/* Q. 6) Display employee ID and the date on which he ended his previous job. */

/*

SELECT EMPLOYEE_ID, MAX(END_DATE)
FROM job_history
GROUP BY EMPLOYEE_ID;

*/

/* Q. 7) Display first name and date of first salary of the employees. */

/*

SELECT FIRST_NAME, DATEADD(MONTH, 01, HIRE_DATE)
FROM employees;
*/

/* Q. 8) Display first name and experience of the employees. */

/*

SELECT FIRST_NAME, DATEDIFF(year, HIRE_DATE, GETDATE()) AS experience
FROM employees;

*/

/* Q. 9) Display first name of employees who joined in 2001. */

/*

SELECT FIRST_NAME, HIRE_DATE 
FROM EMPLOYEES 
WHERE YEAR(HIRE_DATE) = '2001';

*/

/* Q. 10) Display employees who joined in the current year. */

/*

SELECT * FROM employees
WHERE YEAR(HIRE_DATE) = 2022;

*/

/* Q. 11) Display the number of days between system date and 1st January 2011. */

/*

SELECT DATEDIFF(DAY, '2011-01-01', GETDATE());

*/
/* Q. 12) Display number of employees joined after 15th of the month. /*

/*

SELECT COUNT(EMPLOYEE_ID) AS NO_OF_Employee
FROM employees
WHERE DAY(HIRE_DATE) > 15;

*/

/* Q. 13) Display third highest salary of employees. */

/*

SELECT * FROM employees
WHERE SALARY = (SELECT MIN(SALARY)
                FROM employees
                WHERE SALARY IN
                (SELECT DISTINCT TOP 3
                SALARY FROM employees
                ORDER BY SALARY DESC))

*/