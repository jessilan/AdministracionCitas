using System;
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
    public partial class RegistroConsulta : Form
    {
        int posicion;

        public RegistroConsulta()
        {
            InitializeComponent();
            // Oculta notificacion y el boton de modificar
            notificacionLabel.Visible = false;
            aquiLabel.Visible = false;
            modificarButton.Enabled = false;
            dataGridView1.DataSource = ConsultaLogica.consulta;

        }

        private void guardarButton_Click_2(object sender, EventArgs e)
        {
            Consulta tipoConsulta = new Consulta();
            int validarDato;

           /* 
            * Comprueba que el texto no este vacio, convierte el 
            * contenido en int y lo almacena en validar dato
            */
            if (!string.IsNullOrWhiteSpace(numeroTextBox.Text) && int.TryParse(numeroTextBox.Text, out validarDato))
            {
                /*
                 * Verifica que la coleccion consulta no este vacia, 
                 * se utiliza lambda para comprobar que algun valor no sean nulo y NumeroConsulta
                 * sea igual a validarDato
                 */
                bool numeroIgual = ConsultaLogica.consulta != null && ConsultaLogica.consulta.Any(c => c != null
                && c.NumeroConsulta == validarDato);

                // Si el NumeroConsulta es igual a validarDato 
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
                          || descripcionTextBox.Text == ""
                          || estadoComboBox.SelectedItem == null)
                    {
                        // Notificación de error
                        notificacionLabel.Visible = true;
                        notificacionLabel.BackColor = Color.Salmon;
                        notificacionLabel.Text = Constantes.NOTIFICACION_ERROR;

                    }
                    else
                    {
                        //Setea los campos
                        tipoConsulta.NumeroConsulta = Convert.ToInt32(numeroTextBox.Text);
                        tipoConsulta.DescripcionConsulta = descripcionTextBox.Text;

                        // Valida que el estado sea guardado como char
                        if (estadoComboBox.SelectedIndex == 0)
                        {
                            tipoConsulta.EstadoConsulta = 'A';
                        }
                        else
                        {
                            tipoConsulta.EstadoConsulta = 'I';
                        }

                        // Envia tipoConsulta por parametro al método agregar
                        ConsultaLogica.agregar(tipoConsulta);

                        // Llena los datos
                        dataGridView1.DataSource = ConsultaLogica.consulta;
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
                notificacionLabel.Text = Constantes.NUMERO_CONSULTA_EXCEPCION;
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
                    // Oculta los botones o muestra notificación y botones
                    modificarButton.Enabled = true;
                    notificacionLabel.Visible = false;
                    guardarButton.Enabled = false;
                    aquiLabel.Visible = true;

                    //La posicion es igual a la seleccionada en el DataGriedView1
                    posicion = dataGridView1.CurrentRow.Index;

                    // Carga los datos en los campos de registro
                    numeroTextBox.Text = dataGridView1[0, posicion].Value.ToString();
                    descripcionTextBox.Text = dataGridView1[1, posicion].Value.ToString();
                    estadoComboBox.SelectedItem = dataGridView1[2, posicion].Value.ToString();

                    // Oculta los campos que no deben editarse y muestra el que si
                    numeroTextBox.Enabled = false;
                    descripcionTextBox.Enabled = false;
                    estadoComboBox.Enabled = true;
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

        private void modificarButton_Click_1(object sender, EventArgs e)
        {
            if (estadoComboBox.SelectedItem == null)
            {
                // Muestra notificaciones 
                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.Salmon;
                notificacionLabel.Text = Constantes.ESTADO_EXCEPCION;
            }
            else
            {
                if (estadoComboBox.SelectedIndex == 0)
                {
                    dataGridView1[2, posicion].Value = 'A';
                }
                else
                {
                    dataGridView1[2, posicion].Value = 'I';
                }

                // Refresca los datos
                dataGridView1.Refresh();

                notificacionLabel.Visible = true;
                notificacionLabel.BackColor = Color.GreenYellow;
                notificacionLabel.Text = Constantes.MODIFICADO;


                // Los campos pueden ser llenados
                numeroTextBox.Enabled = true;
                descripcionTextBox.Enabled = true;
                estadoComboBox.Enabled = true;

                // Los campos se limpian
                numeroTextBox.Text = "";
                descripcionTextBox.Text = "";
                estadoComboBox.Text = "";

                // Muestra el boton guardar
                guardarButton.Enabled = true;

                // Oculta boton nuevo, modificar y notficaciones
                aquiLabel.Visible = false;
                modificarButton.Enabled = false;

            }

            dataGridView1.DataSource = ConsultaLogica.consulta;
        }

    }
}
