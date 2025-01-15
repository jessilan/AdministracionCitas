namespace CapaPresentacion
{
    partial class RegistroCita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.tipoConsultaComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citasLabel = new System.Windows.Forms.Label();
            this.notificacionLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel.Location = new System.Drawing.Point(213, 19);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(189, 25);
            this.tituloLabel.TabIndex = 11;
            this.tituloLabel.Text = "Registro de citas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número de cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doctor";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(139, 98);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(143, 20);
            this.numeroTextBox.TabIndex = 18;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(418, 216);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 23;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoConsultaComboBox
            // 
            this.tipoConsultaComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tipoConsultaComboBox.BackColor = System.Drawing.Color.White;
            this.tipoConsultaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoConsultaComboBox.FormattingEnabled = true;
            this.tipoConsultaComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tipoConsultaComboBox.Location = new System.Drawing.Point(139, 131);
            this.tipoConsultaComboBox.Name = "tipoConsultaComboBox";
            this.tipoConsultaComboBox.Size = new System.Drawing.Size(143, 21);
            this.tipoConsultaComboBox.TabIndex = 24;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.doctorComboBox.BackColor = System.Drawing.Color.White;
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.doctorComboBox.Location = new System.Drawing.Point(139, 168);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(143, 21);
            this.doctorComboBox.TabIndex = 25;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.clienteComboBox.BackColor = System.Drawing.Color.White;
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clienteComboBox.Location = new System.Drawing.Point(372, 136);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(145, 21);
            this.clienteComboBox.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 154);
            this.dataGridView1.TabIndex = 27;
            // 
            // citasLabel
            // 
            this.citasLabel.AutoSize = true;
            this.citasLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.citasLabel.Location = new System.Drawing.Point(29, 285);
            this.citasLabel.Name = "citasLabel";
            this.citasLabel.Size = new System.Drawing.Size(464, 16);
            this.citasLabel.TabIndex = 28;
            this.citasLabel.Text = "Se debe seleccionar la tabla para actualizar las citas registradas";
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(45, 244);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(61, 13);
            this.notificacionLabel.TabIndex = 29;
            this.notificacionLabel.Text = "notificacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy H:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 3, 8, 15, 0, 0);
            // 
            // RegistroCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 483);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.citasLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.tipoConsultaComboBox);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroCita";
            this.Text = "RegistroCita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.ComboBox tipoConsultaComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label citasLabel;
        private System.Windows.Forms.Label notificacionLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}