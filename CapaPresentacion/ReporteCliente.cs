using CapaEntidades;
using CapaLogica;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/* @author: jessilan
 * Fecha de inicio: 28/09/2023
 */

namespace CapaPresentacion
{
    public partial class ReporteCliente : Form
    {
        public ReporteCliente()
        {
            InitializeComponent();
            notificacionLabel.Visible = false;

            clienteComboBox.DisplayMember = "ToString";
            clienteComboBox.DataSource = ConsultaLogica.cliente;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (clienteComboBox.SelectedItem != null)
            {
                ConsultaLogica.buscarCliente((Cliente)clienteComboBox.SelectedItem);
                dataGridView1.DataSource = ConsultaLogica.cita.Where(x => x != null
                && x.Cliente == clienteComboBox.SelectedItem).ToList();
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
