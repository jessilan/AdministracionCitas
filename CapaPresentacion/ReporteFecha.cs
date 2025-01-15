using CapaLogica;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/* UNED III Cuatrimestre
 * Proyecto #1 - Desarrollo de herramienta de escritorio 
 *               que permita la administración de citas a dentistas.
 * Estudiante: Jessica Hernández Rosales
 * Fecha de inicio: 28/09/2023
 */

namespace CapaPresentacion
{
    public partial class ReporteFecha : Form
    {
        public ReporteFecha()
        {
            InitializeComponent();
            notificacionLabel.Visible = false;
        }
        private void buscarButton_Click(object sender, EventArgs e)
        {
            // Hace la busqueda tomando la colección cita para buscar la fecha proporcionada por el usuario
            var fecha = ConsultaLogica.cita.Where(x => x != null
                    && x.FechaHoraCita == fechaBuscar.Value).ToList();

            // Comprueba si el elemento esta en la colección
            if (fecha.Any())
            {
                // Llena el dataGridView con el elemento encontrado
                dataGridView1.DataSource = fecha;
            }
            else
            {
                // Limpia el dataGridView1
                dataGridView1.Columns.Clear();

                // Si no se encontraron citas, muestra la notificación de error.
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = "No se encontraron citas para la fecha seleccionada.";
            }

        }
    }
}
