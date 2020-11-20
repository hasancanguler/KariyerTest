# KariyerTest

**Q-1 [Algorithm]**

Write a function that checks whether a given sequence of characters is a palindrome. A palindrome is a phrase which reads the same backward and forward. 

**Sample argument:** “ABCDCBA”

**Sample output:**  true

**A-1**

Please [click](https://github.com/hasancanguler/KariyerTest/blob/main/KariyerTest/Palindrome.cs) for Palindrome Metod


**Q-2 [Algorithm]**

 Write a function that find and count if Array contains duplicates?
 
**Sample argument:** "1, 2, 3, 5, 2, 3, 4, 1, 1"

**Sample output:** 1 -> Count:3, 2 -> Count: 2, 3 -> Count: 2, 4 -> Count: 1, 5 -> Count:1

**A-2**

Please [click](https://github.com/hasancanguler/KariyerTest/blob/main/KariyerTest/ArrayFunctions.cs) for ArrayFunctions Metod

**Q-3 [SQL Statement]** 

With the given table below, write a query that lists the result data.

**A-3**

```SQL
Select M.Id as ManagerId,M.Name as ManagerName,AVG(P.salary) as Avarage_Salary_Under_Manager 
From Emplooyes P
inner join Emplooyes M on P.ParentId = M.Id
group by M.Id,M.Name
Order by 3 desc
 ```

**Q-4 [Problem Resolving]** 

You have a web page that execute a SQL statement and export an Excel file from related SQL result. But for large tables, this SQL takes too long, and users get timeout from this web page.
How can you resolve this problem? What steps do you follow to solve this problem?

**A-4**

Firstly, I would create a clustered index on SQL related by that table. After that, I would move the SQL query that is running slowly to a stored procedure. Finally, I would check the SQL query for whether is this joins correctly or not.

**Q-5 [Keywords] And A-5**

Please write (or tell) something about below terms.

**Index (SQL) :** Indexes use to qualify and order our data and it organises our data as an optimum. In this way, we find some data quickly. It earns time and performance.  There are two types of index.  Clustered index orders data as physically. Non-Clustered Index keeps order reference.

**View (SQL) :** Views keep queries. We can combine our SQL queries in a view and we can call just a view rather than complex query.

**Transaction (SQL) :** A transaction ensures that more than one SQL process. For example, we have four processes which are required to do but the third process did not run successfully. We have to rollback first and second process. If we use a transaction for all four processes, the transaction makes rollback or commit steps for us. The transaction gives data integrity.

**Execution Plan (SQL) :** I know but I have never used.

**Cookie vs Session (Web) :** Some temporary data may are wanted to store during the browse a web page such as login info or user's basket. We can use cookie or session for this action. Cookies keep info on users local pc however sessions keep info server's memory.

**Cache (Web) :** A cache is another temporary info related to a web page. There is some third party application for managing cache such as Redis.

**Dictionary (C#, Java etc) :** Dictionary is a class which is a store a list as a key and value. It runs like an array, on the other hand, even it can store class in there.

**string vs StringBuilder :** String is a value type variable. StringBuilder is a class using for joining different variables.

**JSON vs XML :** JSON keeps data lightly but XML needs more please than JSON. Generally, JSON uses with restful services, XML uses with  SOAP.

**Web Service (REST, SOAP) :** Web Service is one of a communication type. Rest and SOAP are types of web service.  Rest can call simply with URL address which uses GET, POST, PUT etc. methods however SOAP uses with a service reference 

**Ajax :** Ajax provides that running server-side methods on client-side. 

**HTTP GET vs POST vs PUT :** Get uses to getting data. it can call with any browser. Post uses to insert data, it includes required data in form-data in a body part. Put uses to update data.

**Struct vs Class :** Struct runs like a little class but the most important difference is that struct is a value-type and class is a reference-type.

**Interface vs Abstract class :** Abstract classes is a base class for member class but interfaces decide rules. It's mean that abstract classes extent classes. Also, abstract classes can include methods but interfaces can not include any method.

**Public vs Protected vs Private vs Internal :** This is an access modifier for class or method. The public is accessible from anywhere. The protected is accessible from just the same class or inheritance class. The private is accessible from just the same class. The Internal is accessible from the same project itself.

**MVC :** There are two types of MVC description. One of them MVC as a design pattern. This is consists of layers such as Model-Viewer-Controller. Another type is project type. This is MVC as a project type. This project type consists of controllers, views and model parts.

**ORM :** ORM is a helper for programmers to making a relation between database and programs. Thanks to ORM we can access database object in a project as a class. Especially, entity framework is a best friend to .Net developer.

**Dependency Injection :** DI is the most difficult of solid principles but one of the most important. DI aims loosely coupled through interfaces. For example, when you call an object if you call this object with new tags directly, the object and other object depend on each other. But if you call object with an interface which is implemented, you turn dependency as the reverse. 
