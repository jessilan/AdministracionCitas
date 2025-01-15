namespace CapaPresentacion
{
    partial class RegistroConsulta
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
            this.components = new System.ComponentModel.Container();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.notificacionLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modificarLabel = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.aquiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(135, 127);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(143, 20);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(31, 102);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(44, 13);
            this.numeroLabel.TabIndex = 1;
            this.numeroLabel.Text = "Número";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(31, 134);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 2;
            this.descripcionLabel.Text = "Descripción";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(31, 164);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(98, 13);
            this.estadoLabel.TabIndex = 3;
            this.estadoLabel.Text = "Estado de consulta";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.estadoComboBox.BackColor = System.Drawing.Color.White;
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Activo(A)",
            "Inactivo(I)"});
            this.estadoComboBox.Location = new System.Drawing.Point(135, 156);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(70, 21);
            this.estadoComboBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 138);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(135, 95);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(143, 20);
            this.numeroTextBox.TabIndex = 6;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel.Location = new System.Drawing.Point(119, 21);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(318, 25);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Registro de tipos de consulta";
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(51, 246);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(63, 13);
            this.notificacionLabel.TabIndex = 9;
            this.notificacionLabel.Text = "Notificacion";
            // 
            // modificarLabel
            // 
            this.modificarLabel.AutoSize = true;
            this.modificarLabel.BackColor = System.Drawing.Color.White;
            this.modificarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modificarLabel.Location = new System.Drawing.Point(51, 287);
            this.modificarLabel.Name = "modificarLabel";
            this.modificarLabel.Size = new System.Drawing.Size(286, 16);
            this.modificarLabel.TabIndex = 10;
            this.modificarLabel.Text = "Seleccione la cunsulta a editar (estado).";
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(320, 205);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 12;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click_2);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(239, 205);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(75, 23);
            this.modificarButton.TabIndex = 13;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click_1);
            // 
            // aquiLabel
            // 
            this.aquiLabel.AutoSize = true;
            this.aquiLabel.BackColor = System.Drawing.Color.White;
            this.aquiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aquiLabel.ForeColor = System.Drawing.Color.Red;
            this.aquiLabel.Location = new System.Drawing.Point(211, 156);
            this.aquiLabel.Name = "aquiLabel";
            this.aquiLabel.Size = new System.Drawing.Size(22, 18);
            this.aquiLabel.TabIndex = 14;
            this.aquiLabel.Text = "**";
            // 
            // RegistroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 500);
            this.Controls.Add(this.aquiLabel);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.modificarLabel);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroConsulta";
            this.Text = "RegistroConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label notificacionLabel;
        private System.Windows.Forms.Label modificarLabel;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Label aquiLabel;
    }
}