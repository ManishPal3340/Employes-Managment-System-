# Employes-Managment-System-
Employee CRUD Operation using C# and ADO.NET Console-based application to perform Create, Read, Update, and Delete operations on Employee records using SQL Server and ADO.NET.

##  📖 Project Description

This is a console-based CRUD application developed using C# and ADO.NET.
The project allows users to Insert, View, Update, and Delete Employee records from a SQL Server database.

It is designed especially for freshers to understand:

Database connectivity

ADO.NET architecture

SQL operations using C#

🛠️ Technologies Used

C#

ADO.NET

SQL Server

Visual Studio

.NET Framework / .NET Core

### 🗂️ Database Details

Database Name: Company
Table Name: Employee

CREATE TABLE Employee (
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    EmpAge INT,
    EmpDept VARCHAR(50),
    EmpSalary INT
);

#### ⚙️ Features

Insert new employee record

View all employee records

Update employee details

Delete employee record

Menu-driven console application

Uses parameterized queries (SQL Injection safe)

▶️ How to Run the Project

Open Visual Studio

Create a Console Application

Copy the provided C# code into Program.cs

Update SQL Server connection string if required

Create database & table in SQL Server

Run the project

##### 📂 Project Structure
EmployeeCRUD
│
├── Program.cs
└── README.md

🧠 ADO.NET Concepts Used

SqlConnection

SqlCommand

SqlDataReader

ExecuteNonQuery()

Parameterized Queries

CRUD Operations

###### 💬 Sample Menu Output
====== Employee CRUD ======
1. Insert
2. View
3. Update
4. Delete
5. Exit
