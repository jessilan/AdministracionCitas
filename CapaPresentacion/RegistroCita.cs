using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

/* UNED III Cuatrimestre
 * Proyecto #1 - Desarrollo de herramienta de escritorio 
 *               que permita la administración de citas a dentistas.
 * Estudiante: Jessica Hernández Rosales
 * Fecha de inicio: 28/09/2023
 */

namespace CapaPresentacion
{
    public partial class RegistroCita : Form
    {
        public RegistroCita()
        {
            InitializeComponent();

            // Oculta notificación
            notificacionLabel.Visible = false;

            // Carga el comboBox con las consultas
            tipoConsultaComboBox.DisplayMember = "ToString";
            tipoConsultaComboBox.DataSource = ConsultaLogica.consulta;

            // LLama el método que muestra el comboBox con los doctores activos
            doctorActivo();

            // Carga el comboBox con los clientes
            clienteComboBox.DisplayMember = "ToString";
            clienteComboBox.DataSource = ConsultaLogica.cliente;

            dataGridView1.DataSource = ConsultaLogica.cita;
        }

        public void doctorActivo()
        {
            // Recorre el arreglo para comprobar doctores activos
            foreach (Doctor d in ConsultaLogica.doctor)
            {
                // Si el contenido no es vacio y EstadoDoctor es igual a A
                if (d != null && d.EstadoDoctor == 'A')
                {
                    // Agrega el objeto completo al ComboBox
                    doctorComboBox.Items.Add(d);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validarDato;

           /* 
            * Comprueba que el texto no este vacio, convierte el 
            * contenido en int y lo almacena en validar dato
            */
            if (!string.IsNullOrWhiteSpace(numeroTextBox.Text) && int.TryParse(numeroTextBox.Text, out validarDato))
            {
                /*
                 * Verifica que la coleccion cita no este vacia, 
                 * se utiliza lambda para comprobar que algun valor no sean nulo y NumeroCita
                 * sea igual a validarDato
                 */
                bool numeroIgual = ConsultaLogica.cita != null && ConsultaLogica.cita.Any(c => c != null
                && c.NumeroCita == validarDato);

                // Si el NumeroCita es igual a validarDato
                if (numeroIgual)
                {
                    // Muestra notificación de error
                    notificacionLabel.Visible = true;
                    notificacionLabel.BackColor = Color.Salmon;
                    notificacionLabel.Text = Constantes.NUMERO_EXISTE;

                }
                else
                {

                    // Valida el ingreso de datos nulos
                    if (numeroTextBox.Text == ""
                        || dateTimePicker1.Text == ""
                        || tipoConsultaComboBox.SelectedItem == null
                        || doctorComboBox.SelectedItem == null
                        || clienteComboBox.SelectedItem == null)
                    {
                        // Notificación de error
                        notificacionLabel.Visible = true;
                        notificacionLabel.BackColor = Color.Salmon;
                        notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;
                    }
                    else
                    {
                        Cita cita = new Cita();

                        //Setea los campos
                        cita.NumeroCita = Convert.ToInt32(numeroTextBox.Text);
                        cita.FechaHoraCita = Convert.ToDateTime(dateTimePicker1.Value);
                        cita.Consulta = (Consulta)tipoConsultaComboBox.SelectedItem;
                        cita.Doctor = (Doctor)doctorComboBox.SelectedItem;
                        cita.Cliente = (Cliente)clienteComboBox.SelectedItem;

                        // Hace una busqueda en la colección cita que verifica si existe la fechaHora
                        var fecha = ConsultaLogica.cita.Where(x => x != null
                        && x.FechaHoraCita == dateTimePicker1.Value).ToList();

                        // Hace una busqueda en la colección cita que verifica si existe el doctor 
                        var doctor = ConsultaLogica.cita.Where(x => x != null
                        && x.Doctor == doctorComboBox.SelectedItem).ToList();

                       /* Si existe fecha y existe doctor No se puede registrar
                        * una cita a la misma hora con el mismo doctor
                        */
                        if (fecha.Any() && doctor.Any())
                        {
                            // Notificación de error
                            notificacionLabel.Visible = true;
                            notificacionLabel.BackColor = Color.Salmon;
                            notificacionLabel.Text = Constantes.CITA_EXCEPCION;
                        }
                        else
                        {
                            // Envia el registro como parámetro al recorrido del arreglo para agregar la cita
                            ConsultaLogica.agregarCita(cita);

                            dataGridView1.DataSource = ConsultaLogica.cita;

                            // Notificación de afirmación
                            notificacionLabel.Visible = true;
                            notificacionLabel.BackColor = Color.GreenYellow;
                            notificacionLabel.Text = Constantes.NOTIFICACION_AFIRMACION;
                        }
                    }
                }
            }
            else
            {
                // Notificación de error
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.NUMERO_CITA_EXCEPCION;
            }

        }

    }

}
