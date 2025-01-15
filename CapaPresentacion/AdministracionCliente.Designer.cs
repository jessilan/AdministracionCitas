namespace CapaPresentacion
{
    partial class AdministracionCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLabel = new System.Windows.Forms.Label();
            this.identificacionLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.primerApellidoLabel = new System.Windows.Forms.Label();
            this.segundoApellidoLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.generoLabel = new System.Windows.Forms.Label();
            this.generoClienteComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.identificacionClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.notificacionLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modificarLabel = new System.Windows.Forms.Label();
            this.modificarButton = new System.Windows.Forms.Button();
            this.aquiLabel = new System.Windows.Forms.Label();
            this.aquiLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel.Location = new System.Drawing.Point(186, 19);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(221, 25);
            this.tituloLabel.TabIndex = 9;
            this.tituloLabel.Text = "Registro de clientes";
            // 
            // identificacionLabel
            // 
            this.identificacionLabel.AutoSize = true;
            this.identificacionLabel.Location = new System.Drawing.Point(28, 90);
            this.identificacionLabel.Name = "identificacionLabel";
            this.identificacionLabel.Size = new System.Drawing.Size(70, 13);
            this.identificacionLabel.TabIndex = 10;
            this.identificacionLabel.Text = "Identificación";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(299, 90);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 11;
            this.nombreLabel.Text = "Nombre";
            // 
            // primerApellidoLabel
            // 
            this.primerApellidoLabel.AutoSize = true;
            this.primerApellidoLabel.Location = new System.Drawing.Point(28, 122);
            this.primerApellidoLabel.Name = "primerApellidoLabel";
            this.primerApellidoLabel.Size = new System.Drawing.Size(75, 13);
            this.primerApellidoLabel.TabIndex = 12;
            this.primerApellidoLabel.Text = "Primer apellido";
            // 
            // segundoApellidoLabel
            // 
            this.segundoApellidoLabel.AutoSize = true;
            this.segundoApellidoLabel.Location = new System.Drawing.Point(28, 152);
            this.segundoApellidoLabel.Name = "segundoApellidoLabel";
            this.segundoApellidoLabel.Size = new System.Drawing.Size(89, 13);
            this.segundoApellidoLabel.TabIndex = 13;
            this.segundoApellidoLabel.Text = "Segundo apellido";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(299, 122);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(106, 13);
            this.fechaLabel.TabIndex = 14;
            this.fechaLabel.Text = "Fecha de nacimiento";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(301, 152);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(42, 13);
            this.generoLabel.TabIndex = 15;
            this.generoLabel.Text = "Género";
            // 
            // generoClienteComboBox
            // 
            this.generoClienteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.generoClienteComboBox.BackColor = System.Drawing.Color.White;
            this.generoClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoClienteComboBox.FormattingEnabled = true;
            this.generoClienteComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.generoClienteComboBox.Items.AddRange(new object[] {
            "Masculino (M)",
            "Femenino (F)",
            "No especificado (N)"});
            this.generoClienteComboBox.Location = new System.Drawing.Point(411, 145);
            this.generoClienteComboBox.Name = "generoClienteComboBox";
            this.generoClienteComboBox.Size = new System.Drawing.Size(104, 21);
            this.generoClienteComboBox.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 3, 14, 49, 51, 0);
            // 
            // identificacionClienteTextBox
            // 
            this.identificacionClienteTextBox.Location = new System.Drawing.Point(119, 83);
            this.identificacionClienteTextBox.Name = "identificacionClienteTextBox";
            this.identificacionClienteTextBox.Size = new System.Drawing.Size(164, 20);
            this.identificacionClienteTextBox.TabIndex = 18;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.Location = new System.Drawing.Point(349, 83);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(164, 20);
            this.nombreClienteTextBox.TabIndex = 19;
            // 
            // primerApellidoClienteTextBox
            // 
            this.primerApellidoClienteTextBox.Location = new System.Drawing.Point(119, 115);
            this.primerApellidoClienteTextBox.Name = "primerApellidoClienteTextBox";
            this.primerApellidoClienteTextBox.Size = new System.Drawing.Size(164, 20);
            this.primerApellidoClienteTextBox.TabIndex = 20;
            // 
            // segundoApellidoClienteTextBox
            // 
            this.segundoApellidoClienteTextBox.Location = new System.Drawing.Point(119, 145);
            this.segundoApellidoClienteTextBox.Name = "segundoApellidoClienteTextBox";
            this.segundoApellidoClienteTextBox.Size = new System.Drawing.Size(164, 20);
            this.segundoApellidoClienteTextBox.TabIndex = 21;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(424, 215);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(91, 23);
            this.guardarButton.TabIndex = 22;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(28, 250);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(63, 13);
            this.notificacionLabel.TabIndex = 23;
            this.notificacionLabel.Text = "Notificacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 123);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // modificarLabel
            // 
            this.modificarLabel.AutoSize = true;
            this.modificarLabel.BackColor = System.Drawing.Color.White;
            this.modificarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modificarLabel.Location = new System.Drawing.Point(28, 301);
            this.modificarLabel.Name = "modificarLabel";
            this.modificarLabel.Size = new System.Drawing.Size(463, 16);
            this.modificarLabel.TabIndex = 25;
            this.modificarLabel.Text = "Seleccione el cliente que desea editar (fecha nacimiento-género).";
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(327, 215);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(91, 23);
            this.modificarButton.TabIndex = 26;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // aquiLabel
            // 
            this.aquiLabel.AutoSize = true;
            this.aquiLabel.BackColor = System.Drawing.Color.White;
            this.aquiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aquiLabel.ForeColor = System.Drawing.Color.Red;
            this.aquiLabel.Location = new System.Drawing.Point(521, 147);
            this.aquiLabel.Name = "aquiLabel";
            this.aquiLabel.Size = new System.Drawing.Size(22, 18);
            this.aquiLabel.TabIndex = 27;
            this.aquiLabel.Text = "**";
            // 
            // aquiLabel1
            // 
            this.aquiLabel1.AutoSize = true;
            this.aquiLabel1.BackColor = System.Drawing.Color.White;
            this.aquiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aquiLabel1.ForeColor = System.Drawing.Color.Red;
            this.aquiLabel1.Location = new System.Drawing.Point(521, 116);
            this.aquiLabel1.Name = "aquiLabel1";
            this.aquiLabel1.Size = new System.Drawing.Size(22, 18);
            this.aquiLabel1.TabIndex = 28;
            this.aquiLabel1.Text = "**";
            // 
            // AdministracionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 529);
            this.Controls.Add(this.aquiLabel1);
            this.Controls.Add(this.aquiLabel);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.modificarLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.segundoApellidoClienteTextBox);
            this.Controls.Add(this.primerApellidoClienteTextBox);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(this.identificacionClienteTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.generoClienteComboBox);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.segundoApellidoLabel);
            this.Controls.Add(this.primerApellidoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.identificacionLabel);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionCliente";
            this.Text = "AdministracionCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label identificacionLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label primerApellidoLabel;
        private System.Windows.Forms.Label segundoApellidoLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.ComboBox generoClienteComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox identificacionClienteTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox primerApellidoClienteTextBox;
        private System.Windows.Forms.TextBox segundoApellidoClienteTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Label notificacionLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label modificarLabel;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Label aquiLabel;
        private System.Windows.Forms.Label aquiLabel1;
    }
}