using CapaEntidades;
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
    public partial class ReporteDoctor : Form
    {
        public ReporteDoctor()
        {
            InitializeComponent();
            notificacionLabel.Visible = false;

            doctorComboBox.DisplayMember = "ToString";
            doctorComboBox.DataSource = ConsultaLogica.doctor;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedItem != null)
            {
                ConsultaLogica.buscarDoctor((Doctor)doctorComboBox.SelectedItem);

                dataGridView1.DataSource = ConsultaLogica.cita.Where(x => x != null 
                && x.Doctor == doctorComboBox.SelectedItem).ToList();
            }
            else
            {
                // Notificación de error
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.NO_DATOS;
            }

        }
    }
}
