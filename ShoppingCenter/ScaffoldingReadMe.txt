# Application for a shopping center.

An application for managing a shopping center for the administrator and an application for customers.

The application was written in C# using SQL Server.

# Launching the application.

1. Clone the github repository.
2. Open appsettings.json.
3. Change DATA SOURCE to your database server name.
4. Add migration and upate database
   add-migration yourtext
   update-database
5. Open application.

Main functionalities.
Anyone can register.
The administrator role is assigned manually.
That's how we get the role: 

DECLARE @userId nvarchar(450);
DECLARE @roleId nvarchar(450);
DECLARE @userName nvarchar(256);

set @userName = 'adminemail';
set @userId = (select Id from AspNetUsers where [UserName]=@userName);
set @roleId = (select Id from AspNetRoles where [Name]='admin');
insert into AspNetUserRoles values(@userId,@roleId);

In this place 'adminemail' enter the email to which the administrator will be assigned.

The admin has the option to create a store, edit a store and delete a store and create a new item, delete, buy and edit it.

The customer has the option of registering and logging in. He can browse stores and products and purchase them.

# Application Programming Interface

The application has an Api for the Item entity.

# Unit tests

The tests were carried out for the most important functions of the ApiItemController.
