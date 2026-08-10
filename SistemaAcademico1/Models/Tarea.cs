using System;

namespace SistemaAcademico1.Models
{
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

        public Tarea()
        {
            FechaCreacion = DateTime.Now;
            Completada = false;
        }

        public Tarea(string titulo, string descripcion, DateTime fechaEntrega, string rutaArchivo, string temaAsociado)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaEntrega = fechaEntrega;
            RutaArchivo = rutaArchivo;
            TemaAsociado = temaAsociado;
            FechaCreacion = DateTime.Now;
            Completada = false;
        }
    }
}
