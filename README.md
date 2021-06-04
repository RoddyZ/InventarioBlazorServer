# InventarioBlazorServer
Una aplicación web que emula un inventario de una tienda
La aplicación fue creada usando ASP NET CORE Blazor Server, el cual es un framework que permite correr aplicaciones por lado del servidor.
La app está acoplada a una base de datos, dicha base de datos se crea en el código de la aplicación por lo cual se debe aplicar la respectiva migración.
Para gestionar los datos de esta manera se usó el paquete NuGet Microsoft.EntityFrameworkCore.SqlServer
Esta aplicación sigue el modelo de tres capas: Capa de negocio, capa de datos y capa de presentación.

Nota: El string de conexión se debe configurar en DataAccess --> InventaryContext.cs --> Línea 28

Autor: 

Roddy Zamora: https://www.linkedin.com/in/roddy-steeven-zamora-rodr%C3%ADguez-58a116167/


