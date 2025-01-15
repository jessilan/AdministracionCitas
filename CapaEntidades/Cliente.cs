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
    public class Cliente
    {
        // Atributos
        private int identificacionCliente;
        private String nombreCliente;
        private String apellido1;
        private String apellido2;
        private DateTime fechaNacimientoCliente;
        private char generoCliente;


        // Métodos get y set
        public int IdentificacionCliente { get => identificacionCliente; set => identificacionCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1; set => apellido1 = value; }
        public string Apellido2Cliente { get => apellido2; set => apellido2 = value; }
        public DateTime FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public char GeneroCliente { get => generoCliente; set => generoCliente = value; }

        public override string ToString()
        {
            return identificacionCliente + " " + nombreCliente + " " + apellido1 + " " + apellido2;
        }
    }
}
