# Online Examination System
## Overview
The Online Examination System is a web-based platform designed to facilitate the creation, management, and evaluation of exams for educational institutions. It employs the Model-View-Controller (MVC) architecture, utilizes Entity Framework for data handling, and incorporates Bootstrap for responsive design. This system provides functionalities for both instructors and students, ensuring a seamless and efficient examination process.

# Features
- Instructors
  - Create Exams: Define exams for each department, specifying course, number of MCQs, true/false questions, date, time, and duration.
  - View Exams: Access and manage all created exams across departments.
- Students
  - View Exams: Check current exams with statuses such as submitted, unavailable, missed, and available.
  - Take Exams: Participate in exams when the scheduled time arrives. Automatic submission occurs when the exam duration ends.
- Reports
  - Student Information by Department: Fetch student data based on department number.
  - Student Grades: Retrieve grades for a student across all courses.
  - Course and Student Count: Get courses and student count per instructor.
  - Course Topics: Fetch topics for a specific course.
  - Exam Details: Return questions and choices for a specific exam.
  - Student Exam Answers: Retrieve student answers for a specific exam.
# Technologies Used
## Architecture
- MVC (Model-View-Controller): Enhances maintainability, scalability, and flexibility by separating application components.
- Entity Framework: Simplifies database interactions and management of data-driven applications.
- Bootstrap: Provides responsive design and consistency in UI/UX.
## Languages
- C#
- Transact-SQL
- HTML, CSS, JavaScript
## Tools
- Visual Studio
- SQL Server Management Studio
- SQL Profiler
# Database Design
## Entity-Relationship Diagram (ERD)
The ERD represents entities such as students, courses, instructors, exams, questions, and answers, with established relationships among them to ensure data integrity and efficient querying.

## Backup
Regular backups are set up using SQL Server Management Studio (SSMS) or scheduled tasks to ensure data safety and recovery.

## Stored Procedures
Stored procedures are implemented for operations like inserting, updating, deleting, and selecting data. These procedures support complex queries and business logic.
