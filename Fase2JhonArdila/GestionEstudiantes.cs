using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2JhonArdila
{
    internal class GestionEstudiantes
    {
        public string Identificacion {  get; set; }
        public string NombreDelEstudiante { get; set; }
        public string Genero { get; set; }
        public int clasesRecibidas { get; set; }
        public decimal costoPorClase { get; set; }
        public string instrumento { get; set; }
        public DateTime fechaDeRegistro { get; set; }


        // Calcular el costo total del curso de música
        public decimal costoTotalCurso()
        {
            return clasesRecibidas * costoPorClase;
        }
    }
}
