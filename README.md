# Sistema de Biblioteca (Consola C#)

## Integrantes
- Ylemsirk Jafet Iberie Pichardo [2026-1095] (Integrante 1) – Menú principal, utilidades, reportes y README
- Nicole Jazmín Encarnación Padilla [2026-0710] (Integrante 2) – Gestión de libros
- Zahir Leonardo [2026-0786] (Integrante 3) – Gestión de socios
- Lisandro Muñoz Rosario [2026-1165] (Integrante 4) – Préstamos y devoluciones 

## Descripción
Aplicación de consola desarrollada en C# para administrar una biblioteca.
Permite registrar libros y socios, prestar y devolver libros, y consultar
un reporte de préstamos. Incluye validación de datos con `TryParse`,
menú con `do-while` + `switch`, y salida con formato de tabla.

## Requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 o superior
- Git

## Cómo ejecutarlo

```bash
git clone https://github.com/ylemsirk/biblioteca-equipo.git
cd biblioteca-equipo/Biblioteca
dotnet run
```

## Opciones del menú

| Opción | Función |
|---|---|
| 1 | Registrar libro |
| 2 | Listar libros |
| 3 | Registrar socio |
| 4 | Prestar libro |
| 5 | Devolver libro |
| 6 | Reporte de préstamos |
| 0 | Salir |

## Estructura del proyecto

| Archivo | Contenido | Responsable |
|---|---|---|
| `Program.cs` | Menú principal (`do-while` + `switch`) | Integrante 1 |
| `Utilidades.cs` | Lectura y validación con `TryParse` | Integrante 1 |
| `Reportes.cs` | Reporte de préstamos | Integrante 1 |
| `Datos.cs` | Clases y listas de datos | Integrante 1 |
| `GestionLibros.cs` | Registro, listado y búsqueda de libros | Integrante 2 |
| `GestionSocios.cs` | Registro y búsqueda de socios | Integrante 3 |
| `GestionPrestamos.cs` | Préstamos y devoluciones | Integrante 4 |

## Ejemplo de uso

1. Elegir `1` para registrar un libro (título, autor y stock).
2. Elegir `3` para registrar un socio.
3. Elegir `4` e ingresar el Id del libro y del socio para prestar.
4. Elegir `6` para ver el reporte de préstamos.
