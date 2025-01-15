using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* @author: jessilan
 * Fecha de inicio: 28/09/2023
 */

namespace CapaEntidades
{
    public class Doctor
    {

        // Atributos
        private int identificacionDoctor;
        private String nombreDoctor;
        private String apellido1Doctor;
        private String apellido2Doctor;
        private char estadoDoctor;

        // Métodos get y set
        public int IdentificacionDoctor { get => identificacionDoctor; set => identificacionDoctor = value; }
        public string NombreDoctor { get => nombreDoctor; set => nombreDoctor = value; }
        public string Apellido1Doctor { get => apellido1Doctor; set => apellido1Doctor = value; }
        public string Apellido2Doctor { get => apellido2Doctor; set => apellido2Doctor = value; }
        public char EstadoDoctor { get => estadoDoctor; set => estadoDoctor = value; }

        public override string ToString()
        {
            return nombreDoctor + " " + apellido1Doctor + " " + apellido2Doctor;
        }
    }
}
