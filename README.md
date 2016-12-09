# csharp-soft-tech-oct-2016-blog

[C# Blog doc. file with instructions](https://softuni.bg/trainings/resources/officedocument/11424/blog-advanced-functionality-exercises-software-technologies-october-2016) | [Software Technologies - октомври 2016](https://softuni.bg/trainings/1430/software-technologies-october-2016)

Fully-functional Blog system in ASP.NET MVC with SQL Server database using Entity Framework and MVC

### Overview

ASP.MVC - This is a web application framework developed by Microsoft, which implements the model–view–controller (MVC) pattern, with which you should already be familiar with. In other words, this gives you a bare bone working web app (you will see that you can start it immediately after creating the project) out of the box, on top of which you can build your own app. Consider it our foundation.
Entity Framework - Basically, this gives you a way to interact with a database by making you see database objects (tables) as classes (It is analogous to Doctrine, which you have already used but is very different). Once familiar with object-oriented programming you should appreciate how handy this is.
SQL - Query language used for managing a database. In our case, Entity Framework will take care of this.

### SQL Server Installation

[Windows 7/XP - Инсталиране на MSSQL Server](https://softuni.bg/trainings/resources/officedocument/11376/windows-7-xp-mssql-server-installation-software-technologies-october-2016)

From the Microsoft SQL Server 2014 Express download site download the SQLLocalDB 2014 and Management Studio 2014 installers from: https://www.microsoft.com/en-us/download/details.aspx?id=42299.

- `sqllocaldb versions` - show versions of LocalDB that you have already installed
- `sqllocaldb info` - show list of LocalDB instances
- `sqllocaldb info MSSQLLocalDB` - check the version and other info for certain instance

Start instance of MSQLLocalDB:
```
C:\Users\PC>sqllocaldb s MSSQLLocalDB
LocalDB instance "MSSQLLocalDB" started.
```


