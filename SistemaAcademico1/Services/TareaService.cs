using System;
using System.Collections.Generic;
using System.Linq;
using SistemaAcademico1.Models;

namespace SistemaAcademico1.Services
{
    public static class TareaService
    {
        private static List<Tarea> tareas = new List<Tarea>();
        private static int proximoId = 1;

        /// <summary>
        /// Crea una nueva tarea y la agrega a la lista en memoria
        /// </summary>
        public static Tarea CrearTarea(string titulo, string descripcion, DateTime fechaEntrega, string rutaArchivo, string temaAsociado)
        {
            var tarea = new Tarea(titulo, descripcion, fechaEntrega, rutaArchivo, temaAsociado)
            {
                Id = proximoId++
            };
            tareas.Add(tarea);
            return tarea;
        }

        /// <summary>
        /// Obtiene todas las tareas
        /// </summary>
        public static List<Tarea> ObtenerTodasLasTareas()
        {
            return new List<Tarea>(tareas);
        }

        /// <summary>
        /// Obtiene una tarea por ID
        /// </summary>
        public static Tarea ObtenerTareaPorId(int id)
        {
            return tareas.FirstOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// Obtiene tareas por tema
        /// </summary>
        public static List<Tarea> ObtenerTareasPorTema(string tema)
        {
            return tareas.Where(t => t.TemaAsociado == tema).ToList();
        }

        /// <summary>
        /// Actualiza una tarea existente
        /// </summary>
        public static bool ActualizarTarea(int id, string titulo, string descripcion, DateTime fechaEntrega, string rutaArchivo, string temaAsociado)
        {
            var tarea = ObtenerTareaPorId(id);
            if (tarea == null)
                return false;

            tarea.Titulo = titulo;
            tarea.Descripcion = descripcion;
            tarea.FechaEntrega = fechaEntrega;
            tarea.RutaArchivo = rutaArchivo;
            tarea.TemaAsociado = temaAsociado;
            return true;
        }

        /// <summary>
        /// Elimina una tarea por ID
        /// </summary>
        public static bool EliminarTarea(int id)
        {
            var tarea = ObtenerTareaPorId(id);
            if (tarea == null)
                return false;

            tareas.Remove(tarea);
            return true;
        }

        /// <summary>
        /// Obtiene la cantidad de tareas subidas
        /// </summary>
        public static int ObtenerCantidadTareas()
        {
            return tareas.Count;
        }

        /// <summary>
        /// Obtiene la cantidad de tareas completadas
        /// </summary>
        public static int ObtenerCantidadTareasCompletadas()
        {
            return tareas.Count(t => t.Completada);
        }

        /// <summary>
        /// Marca una tarea como completada
        /// </summary>
        public static bool MarcarTareaComoCompletada(int id)
        {
            var tarea = ObtenerTareaPorId(id);
            if (tarea == null)
                return false;

            tarea.Completada = true;
            return true;
        }

        /// <summary>
        /// Limpia todas las tareas (útil para reiniciar la aplicación)
        /// </summary>
        public static void LimpiarTodasLasTareas()
        {
            tareas.Clear();
            proximoId = 1;
        }
    }
}
