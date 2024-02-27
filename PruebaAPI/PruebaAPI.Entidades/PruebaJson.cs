namespace PruebaAPI.Entidades
{
    public class PruebaJson
    {
        public string? Clase { get; set; }
        public string?  CantidadEstudiantes { get; set; }
        public DatosDocente? Docente { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}
