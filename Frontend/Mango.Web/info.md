# Comandos

## Ejecución

    dotnet run
    dotnet build
    dotnet clean

## Migraciones

    dotnet ef migrations add InitialCreate
    dotnet ef migrations add MyMigration
    dotnet ef database update

## Installs

    dotnet tool install --global dotnet-ef
    dotnet new webapi -f net6.0 --dry-run
    dotnet new webapi -f net6.0

    dotnet add package Microsoft.EntityFrameworkCore --version 6.0.3
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.3
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.3

# Referencias

    https://www.nuget.org/
    https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools

# 2 - Product API - Advanced Setup

Agregar connextionstring de API Producto
Crear clase SD para manejar Variables de API
Crear Interfaz de servicio
Crear Dto. (Los mismos que se crearon en el API.)
