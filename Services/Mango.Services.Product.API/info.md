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

# 1 - Product API - Basic Setup

    Crea proyecto webapi net6.0
    Se instalaor librerias necesarias
    Se configuro connectionstring
    Se configuro dbcontext
    Se inyecto context  al program.cs
    Se creo modelo
    Se ejecuto primera migración

# 2 - Product API - Advanced Setup

    Crear Dto (Create , reponse)
    Crear interfaz de repo
    Crear automapper
    Inyectar automapper a program.cs
    Crear repo
    Inyectar repo a program.cs
    Crear controlador
    Crear semillero de productos (Opcional)
    Agregar Azure Storage Exploer for images (Opcional)
    Probar Crud Product
    Configurar Product API en proyecto web.
