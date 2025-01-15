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
    public class Consulta
    {
        // Atributos
        private int numeroConsulta;
        private String descripcionConsulta;
        private char estadoConsulta;


        // Métodos get y set
        public int NumeroConsulta { get => numeroConsulta; set => numeroConsulta = value; }
        public string DescripcionConsulta { get => descripcionConsulta; set => descripcionConsulta = value; }
        public char EstadoConsulta { get => estadoConsulta; set => estadoConsulta = value; }

        public override string ToString()
        {
            return descripcionConsulta;
        }

    }
}
