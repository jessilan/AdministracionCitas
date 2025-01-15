using CapaEntidades;
using CapaLogica;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/* @author: jessilan
 * Fecha de inicio: 28/09/2023
 */

namespace CapaPresentacion
{
    public partial class AdministracionDoctor : Form
    {
        int posicion;
        public AdministracionDoctor()
        {
            InitializeComponent();

            // Oculta notificacion y boton
            notificacionLabel.Visible = false;
            modificarButton.Enabled = false;
            dataGridView1.DataSource = ConsultaLogica.doctor;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            int validarDato;

           /* 
            * Comprueba que el texto no este vacio, convierte el 
            * contenido en int y lo almacena en validar dato
            */
            if (!string.IsNullOrWhiteSpace(identificacionDoctorTextBox.Text) && int.TryParse(identificacionDoctorTextBox.Text, out validarDato))
            {
                /*
                 * Verifica que la coleccion doctor no este vacia, 
                 * se utiliza lambda para comprobar que algun valor no sean nulo y IdentificacionDoctor
                 * sea igual a validarDato
                 */
                bool numeroIgual = ConsultaLogica.doctor != null && ConsultaLogica.doctor.Any(c => c != null
                && c.IdentificacionDoctor == validarDato);

                // Si el IdentificacionDoctor es igual a validarDato 
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
                    if (identificacionDoctorTextBox.Text == null
                          || nombreDoctorTextBox.Text == ""
                          || primerApellidoDoctorTextBox.Text == ""
                          || segundoApellidoDoctorTextBox.Text == ""
                          || estadoDoctorComboBox.SelectedItem == null)
                    {
                        // Notificación de error
                        notificacionLabel.Visible = true;
                        notificacionLabel.BackColor = Color.Salmon;
                        notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;

                    }
                    else
                    {
                        //Setea los campos
                        doctor.IdentificacionDoctor = Convert.ToInt32(identificacionDoctorTextBox.Text);
                        doctor.NombreDoctor = nombreDoctorTextBox.Text;
                        doctor.Apellido1Doctor = primerApellidoDoctorTextBox.Text;
                        doctor.Apellido2Doctor = segundoApellidoDoctorTextBox.Text;

                        if (estadoDoctorComboBox.SelectedIndex == 0)
                        {
                            doctor.EstadoDoctor = 'A';
                        }
                        else
                        {
                            doctor.EstadoDoctor = 'I';
                        }

                        // Envia el registro como parámetro al recorrido del arreglo para agregar el doctor
                        ConsultaLogica.agregarDoctor(doctor);

                        // Llena los datos
                        dataGridView1.DataSource = ConsultaLogica.doctor;
                        dataGridView1.Refresh();


                        // Notificación de afirmación
                        notificacionLabel.Visible = true;
                        notificacionLabel.BackColor = Color.GreenYellow;
                        notificacionLabel.Text = Constantes.NOTIFICACION_AFIRMACION;
                    }
                }
            }
            else
            {
                // Notificación de error
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.NUMERO_IDENTIFICACION_EXCEPCION;
            }       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Valida que al seleccionar una fila vacia no se caiga el programa

            // Si la fila y columna son mayor o igual a 0 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                // Celda es igual a las filas y columnas del DataGridView, se accede por indice
                DataGridViewCell celda = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                /* Si celda es diferente de null, verifica que la cadena no este vacia,
                 * convierte el valor de la celda a string para evitar una excepcion
                 */
                if (celda.Value != null && !string.IsNullOrEmpty(celda.Value.ToString()))
                {
                    modificarButton.Enabled = true;
                    notificacionLabel.Visible = false;

                    // La posicion sera igual a la fila indicada por el usuario
                    posicion = dataGridView1.CurrentRow.Index;

                    // Se cargan los datos en los campos de registro
                    identificacionDoctorTextBox.Text = dataGridView1[0, posicion].Value.ToString();
                    nombreDoctorTextBox.Text = dataGridView1[1, posicion].Value.ToString();
                    primerApellidoDoctorTextBox.Text = dataGridView1[2, posicion].Value.ToString();
                    segundoApellidoDoctorTextBox.Text = dataGridView1[3, posicion].Value.ToString();
                    estadoDoctorComboBox.Text = dataGridView1[4, posicion].Value.ToString();

                    identificacionDoctorTextBox.Enabled = false;
                    estadoDoctorComboBox.Enabled = false;

                    // Oculta el boton guardar
                    guardarButton.Enabled = false;

                }
                else
                {
                    // Muestra notificaciones 
                    notificacionLabel.Visible = true;
                    notificacionLabel.BackColor = Color.Salmon;
                    notificacionLabel.Text = Constantes.CELDA_VACIA;
                }
            }

        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            // Valida el ingreso de datos nulos
            if (identificacionDoctorTextBox.Text == null
                || nombreDoctorTextBox.Text == ""
                || primerApellidoDoctorTextBox.Text == ""
                || segundoApellidoDoctorTextBox.Text == ""
                || estadoDoctorComboBox.SelectedItem == null)
            {
                // Notificación de error
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;

            }
            else
            {
                dataGridView1[1, posicion].Value = nombreDoctorTextBox.Text;
                dataGridView1[2, posicion].Value = primerApellidoDoctorTextBox.Text;
                dataGridView1[3, posicion].Value = segundoApellidoDoctorTextBox.Text;


                // Refresca los datos
                dataGridView1.Refresh();

                // Muestra las notificaciones
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.GreenYellow;
                notificacionLabel.Text = Constantes.MODIFICADO;

                // Limpia los campos de registro
                identificacionDoctorTextBox.Text = "";
                nombreDoctorTextBox.Text = "";
                primerApellidoDoctorTextBox.Text = "";
                segundoApellidoDoctorTextBox.Text = "";
                estadoDoctorComboBox.Text = "";


                identificacionDoctorTextBox.Enabled = true;
                estadoDoctorComboBox.Enabled = true;
                modificarButton.Enabled = false;
                guardarButton.Enabled = true;
            }

            dataGridView1.DataSource = ConsultaLogica.doctor;
        }
    }
}
