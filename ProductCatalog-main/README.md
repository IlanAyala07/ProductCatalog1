# Proyecto: Catálogo de Productos

## Objetivo
Crear una aplicación .NET MAUI con SQLite y Entity Framework Core que permita realizar CRUD sobre los catálogos de productos y sus categorías, sin relaciones configuradas.

---

## Entidades
- **Product** (Id (PK)*: GUID,  Name*:string,  Description*:string,  Price*:decimal (2 decimal positions),  Image:byte[],  IsActive:bool - default true)
- **Category** (Id(PK)*:int,  Name*:string,  IsActive:bool - default true)
- **Supplier** (Id(PK)*:int,  Name*:string,  Email:string,  Phone:string (maxlength 13), IsActive:bool - default true)
- **Brand** (Id(PK)*:int,  Name*:string,  IsActive:bool - default true)

---

## Instrucciones
1. Crear el modelo de datos con las cuatro entidades mencionadas.
2. Configurar cada modelo a través del model builder en el DataContext  
3. Generar los CRUD completos (Create, Read, Update, Delete) para cada entidad.
   > El Delete deberá hacer un soft delete y se deberán recuperar únicamente los registros activos.
4. En `Product`, agregar el campo **Image** (tipo `byte[]?`), solo en el modelo y la base de datos.  
   >  No implementar funcionalidad para cargar o mostrar imágenes.  
5. Usar **SQLite local** como base de datos.  
6. Verificar desde la interfaz que los CRUD funcionen correctamente.
7. Todas las ramas deberán estar mezcladas en main y se deberán corregir los conflictos que llegasen a surgir puesto que **la versión de la aplicación que se probará será la que se encuentre en la rama principal.**

---

## Evaluación
| Criterio | Descripción | Porcentaje |
|-----------|-------------|-------------|
| Modelo de datos | Creación y configuración correcta de entidades y DbContext | 20% |
| Funcionalidad CRUD | Crear, mostrar, editar y eliminar registros en SQLite | 40% |
| Interfaz MAUI | Diseño funcional y navegación adecuada | 20% |
| Pruebas y validación | Verificar funcionamiento general de CRUD | 10% |
| Organización del equipo | Reparto de tareas, uso de Git y coordinación | 10% |

**Total: 100%**
