Online Examination System

It’s an online examination website implemented using MVC and The Database created using SQL Server.
The project consists of 
Entity-Relationship Diagram (ERD):
Design the ERD to represent entities like students, courses, instructors, exams, questions, answers, etc. Establish relationships between these entities.
2. Backup:
Set up a regular backup plan for the database. This can be achieved through SQL Server Management Studio (SSMS) or a scheduled task.
3. Desktop Application:
Create a desktop application to manage the online exam system. Use a programming language such as C# or Java to develop the application.
4. SQL Database Dictionary (Documentation):
Document the database structure, including tables, relationships, and attributes. Explain the purpose of each table and field. This will serve as a guide for future developers and administrators.
5. Stored Procedures:
Write stored procedures for various operations like inserting, updating, deleting, and selecting data. Stored procedures can be used for complex queries and business logic.
6. Exam Generation:
Develop functionality to generate exams dynamically. Store exam details in the database, including questions, choices, and correct answers.
7. Exam Answers:
Capture and store students' answers during the exam.
8. Exam Correction:
Implement logic to correct exams and calculate grades based on correct answers.
9. Reports:
9.1. Student Information by Department No:
Write a stored procedure to fetch student information based on the department number.
9.2. Grades of a Student in All Courses:
Create a stored procedure to retrieve grades for a student based on their ID.
9.3. Courses and Student Count per Instructor:
Develop a stored procedure to get courses and the number of students per course for a given instructor.
9.4. Topics of a Course:
Implement a stored procedure to fetch topics for a given course.
9.5. Questions and Choices in an Exam:
Create a stored procedure to return questions and choices for a specific exam.
9.6. Student Answers in an Exam:
Write a stored procedure to get student answers for a specific exam and student.
10. Crystal Report, Report Builder, SSRS:
Integrate Crystal Report, Report Builder, and SSRS to generate visual reports based on the stored procedures.
11. Readme and Project Description:
Create a comprehensive readme file that includes:
Overview of the project
Installation instructions
Configuration details
Usage guide
Dependencies
Contributors
License information
Contact information
Important Considerations:
Ensure proper error handling and security measures.
Test the system thoroughly before deployment.
Document any third-party tools or libraries used.
Keep the system modular for easy maintenance and future enhancements.
Remember to adapt and customize these steps based on your specific requirements and technologies used.
Online Examination System

Users of the system:
1-	Instructor
Roles: 
1- Create the exam for each department, He has to choose 	the course ,Number of MCQ, Number of True or false 		questions, Date and time of the exam and its duration. 
2- He can view the exams created for all departments
2-	Student
Roles:
1- Once after Login :
Student can view all his current exams with different status. 
(Submitted with grade “Succeeded or Failed”, 				Unavailable,Missed,Available and he could take it as long as 	the exam time hasn’t passed)
2- Take the exam if its time has come , if the exam is missed 	he can’t access it .
If the exam time hasn’t come yet , it will be shown as 		unavailable yet .
If the duration of the exam has finished it will be submitted 	automatically , even if there are questions that hasn’t been 	answered yet in this case this question will be marked by 0.
After the exam submitted either automatically or by clicking 	on submit-button he will be redirected to the main exams 	      	page.

Technologies used:
-MVC : 
The Model-View-Controller (MVC) architecture divides a software application into three interconnected components. The Model manages data and business logic, the View handles the user interface and presentation, and the Controller acts as an intermediary that manages user input and updates the Model and View accordingly. This separation enhances maintainability, scalability, and flexibility in software development.
-Entity framework:
The Entity Framework architecture divides a software application into three components: Model (data and business logic), View (user interface and presentation), and Controller (Entity Framework itself). The Model manages database interactions, the View displays data, and the Controller facilitates communication between the Model and View. This separation enhances maintainability, scalability, and flexibility in data-driven software development.


-Bootstrap:
Bootstrap is a front-end framework that divides web development into three components: Model (HTML structure and content), View (CSS styling and presentation), and Controller (Bootstrap framework). The Model represents webpage content, the View provides styling and layout, and Bootstrap serves as the Controller, offering pre-built components and styles. This separation enhances design consistency, responsiveness, and development efficiency in web projects.

Languages used:
-C#
-Transact-SQL
-HTML, CSS and JavaScript

Tools used:
-Visual Studio
-SQL server Management Studio
-SQL Profiler




