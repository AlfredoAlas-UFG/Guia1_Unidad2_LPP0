namespace Ejercicio_1.Models
{
    public class Alumno
    {
        public string carnet { get; set; } = "";
        public string nombre { get; set; } = "";
        public string apellido { get; set; } = "";
        public string asignatura { get; set; } = "";
        public float[] calificacionesArray { get; set; } = new float[3];
    }
}
