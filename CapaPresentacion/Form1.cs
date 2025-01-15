using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/* @author: jessilan
 * Fecha de inicio: 28/09/2023
 */

namespace CapaPresentacion
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();

            // Oculta el submenú
            submenuPanel.Visible = false;
        }

        // Método que abre los formularios en el panelDatos.
        private void carga (Object Form)
        {
            /* Determina la existencia de controles
             * en el panelDatos, si es asi elimina el primer.
             */
            if (this.panelDatos.Controls.Count > 0) 
                this.panelDatos.Controls.RemoveAt(0);

            // Asignacion a la variable f un objeto de tipo Form
            Form f = Form as Form;

            // El panel no es principal
            f.TopLevel = false;

            // El formulario se ajustara al panel
            f.Dock = DockStyle.Fill;

            // Se agrega el panel 
            this.panelDatos.Controls.Add(f);

            // Almacena datos de referencia
            this.panelDatos.Tag = f;

            // El formulario es visible
            f.Show(); 
        }

        // Método que invoca el anterior y muestra los formularios.
        private void button2_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            submenuPanel.Visible = false;
            carga(new RegistroConsulta());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            submenuPanel.Visible = false;
            carga(new RegistroCita());       
        }


        private void botonSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administracionClienteBoton_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            submenuPanel.Visible = false;
            carga(new AdministracionCliente());
        }

        private void administracionDoctorBoton_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            submenuPanel.Visible = false;
            carga(new AdministracionDoctor());
        }

        private void reporteFechaBoton_Click(object sender, EventArgs e)
        {
            if (submenuPanel.Visible == true)
            {
                submenuPanel.Visible = false;
            }
            else
            {
                submenuPanel.Visible = true;
            }
        }

        private void reporteFechaButton_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            carga(new ReporteFecha());
        }

        private void reporteDoctorButton_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            carga(new ReporteDoctor());
        }

        private void reporreClienteButton_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            carga(new ReporteCliente());
        }

        /******************** METODOS QUE PERMITEN EL MOVIMIENTO DE LA PANTALLA ********************/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // El movimiento funciona en los paneles inciales, se puede adaptar a los demas forms
        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void encabezadoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
