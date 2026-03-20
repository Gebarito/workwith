# Work With!

Asp.net core project with .NET10 and Razor pages.


### Getting Started

This project uses authentication with google api.

To setup:
1. Follow the instructions in https://console.cloud.google.com/apis to create an account and a project.
2. Copy and paste the Client Id and the Client Secret in appsettings or in the dotnet secrets:
```sh
dotnet user-secrets set "Authentication:Google:ClientId" "CLIENT ID"
dotnet user-secrets set "Authentication:Google:ClientSecret" "CLIENT SECRET"
```

> [!WARNING]
> It might be necessary to update the uri`s and urls based on the port that the project is running on your computer.

To run the project just use:
```sh
dotnet run
```

