using System;
using CapaEntidades;

/* @author: jessilan
 * Fecha de inicio: 28/09/2023
 */

namespace CapaLogica
{
    public class ConsultaLogica
    {
        public static Consulta[] consulta = new Consulta[10];
        public static Cliente[] cliente = new Cliente[20];
        public static Doctor[] doctor = new Doctor[20];
        public static Cita[] cita = new Cita[20];

        /*
         * Recorre el arreglo para agregar nuevo tipos de consulta
         */
        public static void agregar(Consulta tipoConsulta)
        {
            //Recorre el arreglo
            for (int i = 0; i < consulta.Length; i++)
            {
                if (consulta[i] == null)
                {
                    consulta[i] = tipoConsulta;
                    
                    break;
                }   
            }
        }

        /*
         * Recorre el arreglo para agregar nuevo clientes
         */
        public static void agregarCliente(Cliente nuevoCliente)
        {
            for (int i = 0; i < cliente.Length; i++)
            {
                if (cliente[i] == null)
                {
                    cliente[i] = nuevoCliente;
                    break;
                }
            }

        }

        /*
         * Recorre el arreglo para agregar nuevo doctores
         */
        public static void agregarDoctor(Doctor nuevoDoctor)
        {
            for (int i = 0; i < doctor.Length; i++)
            {
                if (doctor[i] == null)
                {
                    doctor[i] = nuevoDoctor;
                    break;
                }
            }

        }

        /*
        * Recorre el arreglo para agregar nueva cita
        */
        public static void agregarCita(Cita nuevaCita)
        {
            for (int i = 0; i < cita.Length; i++)
            {
                if (cita[i] == null)
                {
                    cita[i] = nuevaCita;
                    break;
                }
            }

        }

        /*
        * Recorre el arreglo para buscar un doctor
        */
        public static void buscarDoctor(Doctor doctor)
        {
            for (int i = 0; i < cita.Length; i++)
            {
                if (cita[i] != null) 
                {
                    cita[i].Doctor.Equals(doctor);
                }
            }
        }

        /*
        * Recorre el arreglo para buscar un cliente
        */
        public static void buscarCliente(Cliente cliente)
        {
            for (int i = 0; i < cita.Length; i++)
            {
                if (cita[i] != null)
                {
                    cita[i].Cliente.Equals(cliente);
                }
            }
        }

    }

    /*
     * Mensajes de error o afirmación para interaactuar con el usuario
     */
    public class Constantes
    {
        public static String NOTIFICACION_ERROR = "Debe llenar todos los campos";
        public static String NOTIFICACION_AFIRMACION = "¡Guardado con éxito!";
        public static String NO_DATOS = "No hay datos registrados";
        public static String ESTADO_EXCEPCION = "Debe seleccionar el estado";
        public static String NUMERO_CONSULTA_EXCEPCION = "El número de consulta es inválido, digitelo de nuevo";
        public static String NUMERO_IDENTIFICACION_EXCEPCION = "La identificación es inválida, digitela de nuevo";
        public static String NUMERO_CITA_EXCEPCION = "El número de cita es inválido, digitelo de nuevo";
        public static String NUMERO_EXISTE = "El número ya se encuentra registrado, digite otro";
        public static String CITA_EXCEPCION = "El doctor ya posee una cita a esa hora";
        public static String MODIFICADO = "Modificado exitosamente";
        public static String CELDA_VACIA = "La celda seleccionada esta vacía";
    }
}
