# Guía de Integración - Gestor de Tareas para Docentes

## 📋 Estructura Creada

Se han creado los siguientes archivos:

1. **Models/Tarea.cs** - Modelo de datos para las tareas
2. **Services/TareaService.cs** - Servicio que gestiona las tareas en memoria
3. **GestorTareas.cs** - Formulario completo para gestionar tareas

## 🔧 Cómo integrar en tu proyecto

### Paso 1: Crear las carpetas (si no existen)
En tu proyecto en Visual Studio:
- Click derecho en `SistemaAcademico1` → New Folder → `Models`
- Click derecho en `SistemaAcademico1` → New Folder → `Services`

### Paso 2: Agregar los archivos
- Copiar `Models/Tarea.cs` a la carpeta Models
- Copiar `Services/TareaService.cs` a la carpeta Services
- Copiar `GestorTareas.cs` a la raíz de SistemaAcademico1

### Paso 3: Abrir el formulario desde DashboardPrincipal
En tu archivo `DashboardPrincipal.cs`, agrega un botón para abrir el Gestor de Tareas:

```csharp
Button btnGestorTareas = new Button
{
    Text = "📋 Gestor de Tareas",
    Location = new Point(100, 200),
    Size = new Size(200, 50),
    Font = new Font("Segoe UI", 12, FontStyle.Bold),
    BackColor = Color.FromArgb(132, 78, 255),
    ForeColor = Color.White
};
btnGestorTareas.Click += (s, e) => 
{
    GestorTareas gestorTareas = new GestorTareas();
    gestorTareas.Show();
};
Controls.Add(btnGestorTareas);
```

## 📊 Funcionalidades

### ✅ Crear Tarea
- Ingresa título, descripción, fecha de entrega, selecciona tema
- Adjunta un archivo (opcional)
- Haz clic en "✅ Crear Tarea"

### 🔄 Actualizar Tarea
- Selecciona una tarea del DataGridView (tabla)
- Modifica los campos que desees
- Haz clic en "🔄 Actualizar"

### 🗑️ Eliminar Tarea
- Selecciona una tarea del DataGridView
- Haz clic en "🗑️ Eliminar"
- Confirma la eliminación

### 🔔 Estadísticas
- La campanita muestra: **Tareas subidas: X | Completadas: Y**
- Se actualiza automáticamente con cada acción

## 📁 Estructura del Modelo Tarea

```csharp
public class Tarea
{
    public int Id { get; set; }                    // ID único
    public string Titulo { get; set; }             // Título de la tarea
    public string Descripcion { get; set; }        // Descripción completa
    public DateTime FechaEntrega { get; set; }     // Fecha límite
    public string RutaArchivo { get; set; }        // Ruta del archivo adjunto
    public string TemaAsociado { get; set; }       // Ciclos, Variables, etc.
    public DateTime FechaCreacion { get; set; }    // Cuándo se creó
    public bool Completada { get; set; }           // ¿Está completada?
}
```

## 🎨 Personalización

### Cambiar colores
En `GestorTareas.cs`, busca las líneas con `Color.FromArgb()`:
- `Color.FromArgb(132, 78, 255)` - Púrpura (header y botones principales)
- `Color.FromArgb(76, 175, 80)` - Verde (crear)
- `Color.FromArgb(33, 150, 243)` - Azul (actualizar)
- `Color.FromArgb(244, 67, 54)` - Rojo (eliminar)
- `Color.FromArgb(255, 152, 0)` - Naranja (limpiar)

### Agregar más temas
En `GestorTareas.cs`, en el ComboBox de temas:
```csharp
cmbTema.Items.AddRange(new string[] { 
    "Ciclos", 
    "Variables", 
    "Condicionales", 
    "Algoritmos", 
    "Funciones",    // ← Agregar aquí
    "Arreglos",     // ← O aquí
    "General" 
});
```

## 💾 Nota sobre persistencia

Las tareas se guardan **solo en memoria** durante la ejecución de la aplicación.
Si deseas guardar en archivo o base de datos, puedes:

1. **Guardar en JSON**: Modifica `TareaService.cs` para serializar a JSON
2. **Guardar en base de datos**: Cambia `List<Tarea>` por operaciones de BD

## 🚀 Próximas mejoras sugeridas

- [ ] Mostrar tareas a los estudiantes (crear vista read-only)
- [ ] Permitir que estudiantes descarguen archivos adjuntos
- [ ] Agregar búsqueda/filtro de tareas
- [ ] Mostrar avisos de tareas próximas a vencer
- [ ] Historial de tareas completadas

---

**¡Listo! Ya puedes integrar el Gestor de Tareas en tu Sistema Académico.**
