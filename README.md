
# Web App

This is a simple Web Application to get to know your understanding of the Asp.Net Core and how its features work and how you utilize those. In this Task you need to create a simple login base app to perform a simple CRUD operation. 

Entities:
--------
- User 
	- (Base on the Identity User)
	- First Name, Last Name, IsActive
- Customer
	- Id, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax
- Order

	- Id, CustomerId, OrderDate, RequiredDate, ShipingAddress (Name, Address, City, Region, PostalCode, Country, etc) : include which feilds can be used for order

Requirements:

	- Create a simple application using the above Entities and tech stack. 
	- Layout doesn't matter but it should be presentable. 
	- User Identity Server for Login/Register with the User extra fields as mentioned above. 
	- CURD for both Customer and his orders. i would love to see the one-to-many relation implemented here. 



## Tech Stack

**Client:** MVC, Razor Pages

**Web framework:** ASP.NET Core 5

**ORM framework:** EF Core (Code First)

**Logging framework:** Serilog 

**DataBase:** MS SQL Server

**Authentication Server:** Identity Server

**Deployment Server:** Identity Server, IIS
  
## Deployment

To deploy this project run

```bash
  https://github.com/saddamakhtarly/WebApp
```

## Documentation

- [Documentation](https://linktodocumentation)
- https://www.youtube.com/watch?v=RDKfRecm0g8
- https://www.youtube.com/watch?v=PpqdsJDvcxY
- https://www.youtube.com/watch?v=B0_gM-wBlmE

- @*Adding BootStrap 5 CDN Links*@ in WebApp=>Pages=>Shared=>_Layout.cshtml
- Install Entity Framework Core (Code First Approach)
Sql Server
Tools for Migration
- Add Connection String into appsettings.json
- Crate Class of IdintityDbContext
- add DbContext in Startup.cs 
- add Authentication in Startup.cs 

- Create and Implement Register Prge
- Create and Implement Login Prge
- Change Navigation Menu in Layout
- Add Authorization in Home and Privacy Page
- Create and Implement Logout


Custom Identity UserTable

