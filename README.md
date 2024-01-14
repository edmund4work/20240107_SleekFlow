# 20240107_SleekFlow
# Sleekflow Software Engineer Project  **Objective:** Develop a scalable and well-designed TODO list API application that allows users to manage their TODOs, demonstrating your backend development skills, API design expertise, and software engineering best practices.


# Info
1) This project is using .net core 7 , so need to install sdk 7 
2) This project's database is using MySQL
3) that is some plug-in needed : 
3.1) Microsoft.EntityFrameworkCore (7.0.15)
3.2) Microsoft.EntityFrameworkCore.SqlServer (7.0.15)
4) 2 API are able to call: 
4.1) API to get all list of Todo
curl --location 'https://localhost:7119/api/todo/getFullList' \
--header 'Content-Type: application/json' \
--data '{
  "statusIDSelected": [
    1,
    2
  ],
  "dueDateFrom": "2024-01-14T14:21:46.857Z",
  "dueDateTo": "2024-01-14T14:21:46.857Z"
}'
4.2) API CRUD for Todo
curl --location 'https://localhost:7119/api/todo/crud' \
--header 'Content-Type: application/json' \
--data '{
  "action": "string", 
  "todoData": {
    "id": 0, 
    "name": "string",
    "description": "string",
    "dueDate": "2024-02-14 15:30", 
    "statusID": 0, 
    "priority": 0, 
    "CreatedID" : 1, 
    "UpdatedID" : 1
  }
}'


# SQL Reference
1) Create Database in local
2) if using MySQL can look for mySQLScript.sql to create table and insert some default data
3) if using tSQL, can look for tSQLScript.sql to create table and insert some default data

# What can added 
1) put in async 
2) put in tags filter
3) put in completed date, delete date and discontinued date
4) put in sample data of Tags
5) currently this is for 1 person use, may impletement to multiple user.