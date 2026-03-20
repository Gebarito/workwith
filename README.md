# Work With!

Job vacancy site made with Asp.net core project with .NET10 and Razor pages.\
Personal project to learn and showcase skills.\
Name inspired by: https://www.workwithindies.com/. 

### Getting Started

Setup the connection string with your postgres database on `appsettings.json` or using secrets (recommended):
```sh
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=mydatabase;"
```

This project uses authentication with google api.

To setup:
1. Follow the instructions in https://console.cloud.google.com/apis to create an account and a project.
2. Copy and paste the Client Id and the Client Secret in appsettings or in the dotnet secrets:
```sh
dotnet user-secrets set "Authentication:Google:ClientId" "YOUR-CLIENT-ID"
dotnet user-secrets set "Authentication:Google:ClientSecret" "YOUR-CLIENT-SECRET"
```

> [!WARNING]
> It might be necessary to update the uri`s and urls based on the port that the project is running on your computer.

To run the project just use:
```sh
dotnet run
```

### Dependencies:
| Dependencies | Version |
|---           |---      |
| Microsoft.AspNetCore.Authentication.Google | 10.0.5 |
| Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore | 10.0.4 |
| Microsoft.AspNetCore.Identity.EntityFrameworkCore | 10.0.4 |
| Microsoft.AspNetCore.Identity.UI | 10.0.4 |
| Microsoft.EntityFrameworkCore.Design | 10.0.5 |
| Microsoft.EntityFrameworkCore.Tools | 10.0.4 |
| Npgsql.EntityFrameworkCore.PostgreSQL | 10.0.1 |


### Docs
- Manage external logins: https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/?view=aspnetcore-10.0&tabs=visual-studio
