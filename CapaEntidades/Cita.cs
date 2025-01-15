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
    public class Cita
    {

        // Atributos
        private int numeroCita;
        private DateTime fechaHoraCita;
        private Consulta consulta;
        private Cliente cliente;
        private Doctor doctor;


        // Métodos get y set
        public int NumeroCita { get => numeroCita; set => numeroCita = value; }
        public DateTime FechaHoraCita { get => fechaHoraCita; set => fechaHoraCita = value; }
        public Consulta Consulta { get => consulta; set => consulta = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }



    }
}
