# Guía Completa - Módulo de Tareas

## 📚 Descripción General

Se ha creado un **sistema completo de gestión de tareas** para el Sistema Académico con dos vistas:

1. **GestorTareas.cs** - Panel de control para docentes (crear, editar, eliminar)
2. **VisorTareasEstudiante.cs** - Vista de solo lectura para estudiantes (visualizar, descargar, completar)

---

## 🎯 Características Implementadas

### ✅ Para Docentes (GestorTareas.cs)
- ✔️ Crear nuevas tareas con todos los campos
- ✔️ Editar tareas existentes
- ✔️ Eliminar tareas
- ✔️ Adjuntar archivos (PDF, código, etc.)
- ✔️ Seleccionar tema asociado
- ✔️ 🔔 Campanita con estadísticas: tareas subidas vs completadas
- ✔️ Interfaz editable con validaciones

### ✅ Para Estudiantes (VisorTareasEstudiante.cs)
- ✔️ **Vista de solo lectura** de todas las tareas
- ✔️ **Búsqueda por título/descripción** - campo de texto en tiempo real
- ✔️ **Filtro por tema** - ComboBox con todas las opciones
- ✔️ **Filtro por estado** - Todas, Pendientes, Completadas, Próximas a vencer
- ✔️ **Avisos de tareas próximas a vencer** - Muestra en rojo si faltan ≤3 días
- ✔️ **Descarga de archivos adjuntos** - Botón "📥 Descargar"
- ✔️ **Marcar tareas como completadas** - Botón "✅ Completar"
- ✔️ **Historial de tareas completadas** - Pestaña "✅ Historial Completadas"
- ✔️ **Detalles de tarea** - Panel con información completa

---

## 🔧 Cómo Integrar en tu Proyecto

### Paso 1: Copiar archivos
Los archivos ya están en el repositorio:
- `SistemaAcademico1/VisorTareasEstudiante.cs`
- `SistemaAcademico1/Models/TareaCompletada.cs`
- (Ya existían: `GestorTareas.cs`, `Models/Tarea.cs`, `Services/TareaService.cs`)

### Paso 2: Integrar en MenuEstructura (Para Estudiantes)
En tu `MenuEstructura.cs`, agrega un botón en el constructor:

```csharp
Button btnMisTareas = new Button
{
    Text = "📚 Mis Tareas",
    Location = new Point(100, 200),
    Size = new Size(200, 50),
    Font = new Font("Segoe UI", 12, FontStyle.Bold),
    BackColor = Color.FromArgb(76, 175, 80),
    ForeColor = Color.White,
    FlatStyle = FlatStyle.Flat
};
btnMisTareas.Click += (s, e) => 
{
    VisorTareasEstudiante visor = new VisorTareasEstudiante();
    visor.Show();
    Hide();
};
Controls.Add(btnMisTareas);
```

### Paso 3: Integrar en tu MenuEstructuraDocente (Para Docentes)
En tu nuevo formulario para docentes, agrega:

```csharp
Button btnGestorTareas = new Button
{
    Text = "📋 Gestor de Tareas",
    Location = new Point(100, 150),
    Size = new Size(250, 50),
    Font = new Font("Segoe UI", 12, FontStyle.Bold),
    BackColor = Color.FromArgb(132, 78, 255),
    ForeColor = Color.White,
    FlatStyle = FlatStyle.Flat
};
btnGestorTareas.Click += (s, e) => 
{
    GestorTareas gestor = new GestorTareas();
    gestor.Show();
    Hide();
};
Controls.Add(btnGestorTareas);
```

---

## 📊 Funcionalidades Detalladas

### 🔍 Búsqueda y Filtrado (Estudiante)

```
┌─────────────────────────────────────────────┐
│ Buscar: [___________]  Tema: [Ciclos ▼]    │
│ Estado: [Todas ▼]  🧹 Limpiar               │
│ 🔔 Avisos: 2 tareas próximas a vencer      │
└─────────────────────────────────────────────┘
```

- **Campo de búsqueda**: Filtra en tiempo real por título, descripción
- **ComboBox de tema**: Ciclos, Variables, Condicionales, Algoritmos, General
- **ComboBox de estado**: Todas, Pendientes, Completadas, Próximas a vencer
- **Botón Limpiar**: Resetea todos los filtros

### 🚨 Sistema de Avisos

El sistema detecta automáticamente:
- **Próximas a vencer**: Tareas con ≤3 días restantes (fondo amarillo)
- **Vencidas**: Tareas con fecha pasada (fondo rojo)
- **Aviso en campanita**: "⚠️ 2 tarea(s) próxima(s) a vencer: Ciclo For, Variables"

### 📥 Descarga de Archivos

```csharp
// El botón "📥 Descargar" permite:
1. Seleccionar ubicación de descarga
2. Copiar archivo desde ruta original
3. Confirmar descarga exitosa
```

### ✅ Completar Tareas

- Selecciona una tarea
- Haz clic en "✅ Completar"
- Se guarda en historial con fecha y hora
- Se mueve a la pestaña "Historial Completadas"

### 📋 Historial de Completadas

Pestaña separada que muestra:
- ID de la tarea
- Título
- Tema
- Fecha de entrega original
- Fecha y hora de completación

---

## 🎨 Colores y Estilos

| Elemento | Color RGB | Uso |
|----------|-----------|-----|
| Púrpura | 132, 78, 255 | Headers, botones principales |
| Verde | 76, 175, 80 | Acciones positivas (Crear, Completar) |
| Azul | 33, 150, 243 | Acciones secundarias (Descargar) |
| Rojo | 244, 67, 54 | Advertencias, eliminar |
| Naranja | 255, 152, 0 | Limpiar, adicionales |
| Amarillo | 255, 255, 200 | Próximas a vencer (fondo fila) |
| Rojo claro | 255, 200, 200 | Tareas vencidas (fondo fila) |

---

## 🔄 Flujo de Datos

```
TareaService (en memoria)
├── Crear Tarea
├── Actualizar Tarea
├── Eliminar Tarea
├── Obtener Tareas
└── Marcar como Completada

Docente (GestorTareas)
└── Crea/Edita/Elimina tareas en TareaService

Estudiante (VisorTareasEstudiante)
├── Lee tareas desde TareaService (solo lectura)
├── Busca y filtra
├── Descarga archivos
└── Marca como completadas
```

---

## 📝 Estructura de Clases

### Tarea (Model)
```csharp
public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaEntrega { get; set; }
    public string RutaArchivo { get; set; }
    public string TemaAsociado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Completada { get; set; }
}
```

### TareaCompletada (Model)
```csharp
public class TareaCompletada
{
    public int IdTarea { get; set; }
    public string Titulo { get; set; }
    public string TemaAsociado { get; set; }
    public DateTime FechaEntrega { get; set; }
    public DateTime FechaCompletada { get; set; }
}
```

---

## 🚀 Próximas Mejoras Sugeridas

- [ ] Guardar historial en base de datos
- [ ] Enviar notificaciones por correo
- [ ] Estadísticas de desempeño del estudiante
- [ ] Comentarios entre docente y estudiante
- [ ] Calificación de tareas completadas
- [ ] Exportar historial a PDF

---

## 🐛 Troubleshooting

### Las tareas no aparecen
- Asegúrate de que `TareaService.CrearTarea()` fue llamado
- Verifica que el formulario se abre después de crear tareas

### Error al descargar archivo
- Verifica que la ruta del archivo sea válida
- Asegúrate de que el archivo aún existe

### Filtros no funcionan
- Revisa que el nombre del tema coincida exactamente
- Usa el botón "🧹 Limpiar" para resetear

---

**¡Sistema de tareas completamente funcional! 🎉**
