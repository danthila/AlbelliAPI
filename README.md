This project's EF processed in code first approach.
I have also uploaded a sample database dump.

Assumptions & Decisions Made 

Considering the requirement I have created very basic Database/Tables 
In a practical scenario, we would have header & details tables for order.
Assumed that product types were already added 
I have used the latest  SQL Server Express 
Notes 
Update the db connection string in appsettings.json

"ConnectionStrings": {
    "DefaultConnection": "server=<your db connection string"
  },


