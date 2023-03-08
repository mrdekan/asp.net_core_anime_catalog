To start the project, you will need a database and Cloudinary service for storing photos / videos.

1. Database creation
   - Create a database using SQL Server Management Studio
   - Find your database in SQL Server Object Explorer in Microsoft Visual Studio
   - Find your connection string in your database properties
2. Create a free account on Cloudinary
3. Create appsettings.json file and fill in the empty fields with your details (I added it to .gitignore as it contains the API-Secret from my Cloudinary)
   - Template for appsettings.json file
```
{
  "ConnectionStrings": {
    "DefaultConnection": "" //your connection to database string
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "CloudinarySettings": {
    "CloudName": "", //your Cloudname
    "ApiKey": "", //your API-Key
    "ApiSecret": "" //your API-Secret
  },
  "AllowedHosts": "*"
}
```
4. Write next commands in Package Manage Console and PowerShell
   - Package Manager Console
     - Create migration
     ```
     Add-Migration InitialCreate
     ```
     - Update your database
     ```
     Update-Database
     ```
   - PowerShell
     - Save seed data to database
     ```
     dotnet run seeddata
     ```
   - If you have any errors, then they may be due to the absence of EntityFramework.Tools (install it using the NuGet package manager)
5. If Visual Studio did not find the packages you need (for example, EntityFramework or Cloudinary), then install them using the NuGet package manager

