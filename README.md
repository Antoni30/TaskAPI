# API FULL en C# con .NET 8 - Estudiante y Tarea
Este proyecto proporciona una API RESTful desarrollada en C# con .NET 8 que gestiona las entidades de Estudiante y Tarea. La API utiliza JSON Web Tokens (JWT) para autenticar todas las solicitudes, garantizando así la seguridad de la aplicación.

## Estructura del Proyecto
La estructura del proyecto sigue las mejores prácticas de diseño de API y consta de los siguientes directorios:

- Controllers: Contiene los controladores de la API para manejar las solicitudes HTTP.
- Data: Contiene la conexion a la base de datos.
- Migration: Define todas las migraciones que se realizo ala base de datos
- Models: Define las entidades del dominio, en este caso, Estudiante y Tarea.
- appsettings.json: Archivo de configuración para la aplicación, que puede incluir configuraciones de conexión a base de datos y configuraciones de JWT.
- Program.cs: Configuración del middleware, inyección de dependencias y configuración de JWT.

## Despliegue y Uso
1. Clona el repositorio:
```PowerShell
git clone https://github.com/Antoni30/TaskAPI
```
2. Ejecuta la aplicación:
```PowerShell
dotnet run
```
# Algunas consideraciones
Si la base de datos falla o no se encuetra entrar al apartado de la terminar de paqueterias de Nugnet y colocar:
```PowerShell
Add-Migration InitialCreate
Update-Database
```
Para  realizar cualquier peticion a nuestra api se tiene que logear en  **api/Login** el cual nos devolver un token.
Este Token lo debes incluir en **todas las cabezera**  de toda peticion a realizar.
Se proporciona un usuario:
```JSON
{
  "userName": "Antoni",
  "password": "123456"
}
```
## Consideraciones Finales
Este proyecto sirve como una base sólida para desarrollar API RESTful en C# con .NET 8, utilizando JWT para autenticar todas las solicitudes. 
Personaliza y expande el proyecto según los requisitos específicos de tu aplicación, manteniendo las mejores prácticas de desarrollo y seguridad. Asegúrate de manejar adecuadamente las excepciones y de

