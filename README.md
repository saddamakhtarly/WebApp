
# Web App

Technologies: 
--------
	- ASP.NET Core 5, 
	- EF Core (Code First), 
	- MVC/Razor Pages (both if needed), 
	- MS SQL Server, 
	- Logging using Serilog to a File. 
	- Identity Server for User Management

Task:
--------
	- This is a simple task to get to know your understanding of the Asp.Net Core and how its features work and how you utilize those. In this Task you need to create a simple login base app to perform a simple CRUD operation. 

Entities:
--------
User (Base on the Identity User)
	- First Name, Last Name, IsActive
Customer
	- Id, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax
Order
	- Id, CustomerId, OrderDate, RequiredDate, ShipingAddress (Name, Address, City, Region, PostalCode, Country, etc) : include which feilds can be used for order

Requirements:
--------
	- Create a simple application using the above Entities and tech stack. 
	- Layout doesn't matter but it should be presentable. 
	- User Identity Server for Login/Register with the User extra fields as mentioned above. 
	- CURD for both Customer and his orders. i would love to see the one-to-many relation implemented here. 

Submitting the Task:
--------
	- Upload it to GitHub as a public repo and share the link with me. I should be able to download it then run it without any issues. (of-course i will be updating the Connection String to point to my sql server)

