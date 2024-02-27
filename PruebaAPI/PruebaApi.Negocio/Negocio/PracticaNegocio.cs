using PruebaApi.Negocio.Interface;
using PruebaAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApi.Negocio.Negocio
{
    public class PracticaNegocio : IPracticaNegocio
    {
        public PruebaJson PracticaJson()
        {
            PruebaJson pruebaJson = new()
            {
                Clase = "Matematicas",
                Docente = new DatosDocente()
                {
                    Nombre = "Pedro Gutierrez",
                    Edad = "50",
                    Email = "pruebas@gmail.com",
                    Telefono = 3125263121
                },
                Estudiantes = new List<Estudiante>
                {
                    new()
                    {
                        PrimerApellido = "Perez",
                        SegundoApellido = "Gonzalez",
                        PrimerNombre = "Pepe",
                        SegundoNombre = "Kiko"
                    },
                    new()
                    {
                        PrimerApellido = "Gutierrez",
                        SegundoApellido = "Gonzalez",
                        PrimerNombre = "Ramon",
                        SegundoNombre = ""
                    },
                    new()
                    {
                        PrimerApellido = "Florez",
                        SegundoApellido = "Gonzalez",
                        PrimerNombre = "Jairo",
                        SegundoNombre = "Andres"
                    },
                    new()
                    {
                        PrimerApellido = "Sanchez",
                        SegundoApellido = "Urrutia",
                        PrimerNombre = "Andres",
                        SegundoNombre = "Felipe"
                    }

                }
            };
            pruebaJson.CantidadEstudiantes = pruebaJson.Estudiantes.Count().ToString();
            return pruebaJson;
        }
    }
}
