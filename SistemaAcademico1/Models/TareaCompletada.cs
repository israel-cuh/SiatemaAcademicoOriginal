using System;

namespace SistemaAcademico1.Models
{
    public class TareaCompletada
    {
        public int IdTarea { get; set; }
        public string Titulo { get; set; }
        public string TemaAsociado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCompletada { get; set; }
    }
}
