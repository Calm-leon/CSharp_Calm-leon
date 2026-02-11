# Sistema de Reservación de Restaurante - 10 Mesas

## 📋 Descripción

Un sistema simple de gestión de reservaciones basado en consola para un restaurante con 10 mesas. La aplicación permite a los usuarios iniciar sesión como clientes registrados o registrarse como nuevos para hacer reservaciones de cena.

---

## 🎯 Objetivo

Crear un sistema de reservaciones funcional que:
- Valide usuarios registrados y les proporcione acceso
- Gestione registros de nuevos usuarios con nombres únicos
- Mantenga un límite de capacidad de 10 reservaciones (una por mesa)
- Muestre todas las reservaciones confirmadas cuando el restaurante alcance su capacidad máxima

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# .NET
- **Tipo**: Aplicación de Consola (.NET Core/Framework)
- **Runtime**: .NET 6.0 o superior
- **IDE**: Visual Studio / Visual Studio Code

---

## 📁 Estructura del Proyecto

```
Restaurant10TablesReservationSystem/
├── Restaurant10TablesReservationSystem.sln      # Archivo de solución de Visual Studio
└── Restaurant10TablesReservationSystem/          # Carpeta del proyecto principal
    ├── Program.cs                                # Lógica principal de la aplicación
    └── Restaurant10TablesReservationSystem.csproj # Configuración del proyecto
```

---

## ⚙️ Cómo Ejecutar

### Requisitos Previos
- .NET 6.0 o superior instalado
- Visual Studio o Visual Studio Code con extensión de C#

### Ejecutar la Aplicación

**Opción 1: Usando Visual Studio**
1. Abre `Restaurant10TablesReservationSystem.sln`
2. Presiona `F5` o haz clic en "Ejecutar" para iniciar la aplicación
3. Sigue los avisos de la consola

**Opción 2: Usando la Línea de Comandos**
```bash
cd Restaurant10TablesReservationSystem\Restaurant10TablesReservationSystem
dotnet run
```

**Opción 3: Usando Visual Studio Code**
1. Abre la carpeta del proyecto en VS Code
2. Abre la terminal y ejecuta: `dotnet run`

---

## 🎮 Cómo Usar

1. **Inicia la aplicación** - Verás el mensaje de bienvenida
2. **Cuando se te solicite**, ingresa `true` si eres un usuario registrado o `false` para registrarte
3. **Si eres usuario registrado**:
   - Ingresa tu nombre de usuario exacto
   - El sistema verifica si existes
   - Si se encuentra, serás bienvenido nuevamente
4. **Si eres nuevo usuario**:
   - Ingresa un nombre de usuario que recuerdes
   - Tu reservación será confirmada con un número de mesa
5. **El proceso se repite** hasta que todas las 10 mesas estén reservadas
6. **Pantalla final** muestra todos los clientes de la cena con sus mesas asignadas

### Ejemplo de Interacción
```
Welcome to the best restaurant in the world!

--------------------------------------
Are you a registered user? (true/false)
false
Please enter and remember your User Name:
Juan García
✓ User registered successfully!
  User Name: Juan García
  Table: 1/10
```

---

## 📚 Conceptos Clave Demostrados

### Programación Orientada a Objetos (POO)
- **Encapsulación**: Uso de constantes y nomenclatura de variables significativa
- **Modularidad**: Flujo lógico claro en el programa principal
- **Gestión de Estado**: Seguimiento de reservaciones y datos de usuarios

### Lógica de Negocio
- **Validación de Datos**: Verificación de registros duplicados
- **Autenticación de Usuario**: Distinción entre usuarios registrados y nuevos
- **Persistencia de Datos**: Almacenamiento temporal de información de reservaciones

### Fundamentos de C#
- **Arreglos**: Almacenamiento dinámico de nombres de usuarios
- **Control de Flujo**: Ciclos y sentencias condicionales
- **Manipulación de Cadenas**: Manejo y formato de entrada del usuario
- **Entrada/Salida**: Interacciones basadas en consola
- **Manejo de Errores**: Validación de entrada con `TryParse`

---

## 🔍 Mejoras de Calidad de Código

Esta versión incluye:
- **Comentarios Claros**: Documentación comprehensiva de la funcionalidad
- **Variables Semánticas**: Nombres significativos (ej. `currentReservationCount` en lugar de `arrayCurrentIndex`)
- **Validación de Entrada**: Análisis seguro de entrada de usuario con `TryParse`
- **Seguridad Nula**: Verificación de null-check y trim en cadenas
- **Mejor UX**: Salida mejorada de consola con separadores visuales
- **Constantes**: Números mágicos reemplazados con constantes nombradas
- **Interpolación de Cadenas**: Sintaxis moderna de C# para salida más limpia

---

## 📝 Mejoras Futuras (Opcional)

Posibles mejoras sin cambiar la arquitectura principal:
- Agregar seguimiento de fecha/hora de reservación
- Implementar persistencia simple basada en archivos (guardar/cargar reservaciones)
- Agregar información del tamaño del grupo por reservación
- Incluir funcionalidad de cancelación de reservaciones
- Agregar búsqueda de reservaciones por fecha o nombre de cliente

---

## 📄 Licencia

Este proyecto se proporciona tal cual con fines educativos.

---

## 📧 Soporte

Para preguntas o problemas, consulta los comentarios en `Program.cs`.

---

**Última Actualización**: Febrero 2026  
**Versión**: 1.1 (Mejorado con documentación y mejoras de calidad del código)
