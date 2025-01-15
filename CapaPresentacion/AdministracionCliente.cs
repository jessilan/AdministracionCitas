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
    public partial class AdministracionCliente : Form
    {
        int posicion;
        public AdministracionCliente()
        {
            InitializeComponent();

            // Oculta notificación y botón
            notificacionLabel.Visible = false;
            aquiLabel.Visible = false;
            aquiLabel1.Visible = false;
            modificarButton.Enabled = false;

            dataGridView1.DataSource = ConsultaLogica.cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            int validarDato;

           /* 
            * Comprueba que el texto no este vacio, convierte el 
            * contenido en int y lo almacena en validar dato
            */
            if (!string.IsNullOrWhiteSpace(identificacionClienteTextBox.Text) && int.TryParse(identificacionClienteTextBox.Text, out validarDato))
            {
                /*
                 * Verifica que la coleccion cliente no este vacia, 
                 * se utiliza lambda para comprobar que algun valor no sean nulo y IdentificacionCliente
                 * sea igual a validarDato
                 */
                bool numeroIgual = ConsultaLogica.cliente != null && ConsultaLogica.cliente.Any(c => c != null
                && c.IdentificacionCliente == validarDato);

                // Si el IdentificacionCliente es igual a validarDato 
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
                    if (identificacionClienteTextBox.Text == null
                        || nombreClienteTextBox.Text == null
                        || primerApellidoClienteTextBox.Text == null
                        || segundoApellidoClienteTextBox.Text == null
                        || dateTimePicker1.Text == null
                        || generoClienteComboBox.SelectedItem == null)
                    {
                        // Notificación de error
                        notificacionLabel.Visible = true;
                        notificacionLabel.BackColor = Color.Salmon;
                        notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;

                    }
                    else
                    {
                        // Setea los campos de registro de usuario
                        nuevoCliente.IdentificacionCliente = Convert.ToInt32(identificacionClienteTextBox.Text);
                        nuevoCliente.NombreCliente = nombreClienteTextBox.Text;
                        nuevoCliente.Apellido1Cliente = primerApellidoClienteTextBox.Text;
                        nuevoCliente.Apellido2Cliente = segundoApellidoClienteTextBox.Text;
                        nuevoCliente.FechaNacimientoCliente = Convert.ToDateTime(dateTimePicker1.Text);

                        if (generoClienteComboBox.SelectedIndex == 0)
                        {
                            nuevoCliente.GeneroCliente = 'M';
                        }
                        else
                        {
                            if (generoClienteComboBox.SelectedIndex == 1)
                            {
                                nuevoCliente.GeneroCliente = 'F';
                            }
                            else
                            {
                                nuevoCliente.GeneroCliente = 'N';
                            }
                        }


                        // Envia el registro como parámetro al recorrido del arreglo para agregar el cliente
                        ConsultaLogica.agregarCliente(nuevoCliente);

                        // Carga el dataGriedView con los datos del arreglo
                        dataGridView1.DataSource = ConsultaLogica.cliente;

                        // Refresca
                        dataGridView1.Refresh();

                        // Muestra las notificaciones
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
                    // Muestra el boton de modificar y notificaciones
                    modificarButton.Enabled = true;
                    aquiLabel.Visible = true;
                    aquiLabel1.Visible = true;

                    // La posicion sera igual a la fila indicada por el usuario
                    posicion = dataGridView1.CurrentRow.Index;

                    // Se cargan los datos en los campos de registro
                    identificacionClienteTextBox.Text = dataGridView1[0, posicion].Value.ToString();
                    nombreClienteTextBox.Text = dataGridView1[1, posicion].Value.ToString();
                    primerApellidoClienteTextBox.Text = dataGridView1[2, posicion].Value.ToString();
                    segundoApellidoClienteTextBox.Text = dataGridView1[3, posicion].Value.ToString();
                    dateTimePicker1.Text = dataGridView1[4, posicion].Value.ToString();
                    generoClienteComboBox.SelectedItem = dataGridView1[5, posicion].Value.ToString();

                    // Oculta los campos que no deben ser editados
                    identificacionClienteTextBox.Enabled = false;
                    nombreClienteTextBox.Enabled = false;
                    primerApellidoClienteTextBox.Enabled = false;
                    segundoApellidoClienteTextBox.Enabled = false;

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
            if (identificacionClienteTextBox.Text == null
                || nombreClienteTextBox.Text == ""
                || primerApellidoClienteTextBox.Text == ""
                || segundoApellidoClienteTextBox.Text == ""
                || dateTimePicker1.Text == null
                || generoClienteComboBox.SelectedItem == null)
            {
                // Notificación de error
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;

            }
            else
            {
                
                // Carga los datos para poder ser modificados
                dataGridView1[4, posicion].Value = dateTimePicker1.Text;

                if (generoClienteComboBox.SelectedIndex == 0)
                {
                    dataGridView1[5, posicion].Value = 'M';
                }
                else
                {
                    if (generoClienteComboBox.SelectedIndex == 1)
                    {
                        dataGridView1[5, posicion].Value = 'F';
                    }
                    else
                    {
                        dataGridView1[5, posicion].Value = 'N';
                    }
                }

                // Refresca los datos
                dataGridView1.Refresh();

                // Muestra las notificaciones
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.GreenYellow;
                notificacionLabel.Text = Constantes.MODIFICADO;

                // Oculta el boton modificar y notificaciones
                modificarButton.Enabled = false;
                guardarButton.Enabled = true;
                aquiLabel.Visible = false;
                aquiLabel1.Visible = false;

                // Limpia los campos de registro
                identificacionClienteTextBox.Text = "";
                nombreClienteTextBox.Text = "";
                primerApellidoClienteTextBox.Text = "";
                segundoApellidoClienteTextBox.Text = "";
                generoClienteComboBox.Text = "";

                // Los campos pueden ser editados
                identificacionClienteTextBox.Enabled = true;
                nombreClienteTextBox.Enabled = true;
                primerApellidoClienteTextBox.Enabled = true;
                segundoApellidoClienteTextBox.Enabled = true;
            }

            dataGridView1.DataSource = ConsultaLogica.cliente;

        }
    }
}
