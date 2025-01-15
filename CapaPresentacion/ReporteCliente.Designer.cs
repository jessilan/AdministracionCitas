namespace CapaPresentacion
{
    partial class ReporteCliente
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
            this.fechaLabel = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citasLabel = new System.Windows.Forms.Label();
            this.notificacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel.Location = new System.Drawing.Point(149, 35);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(304, 25);
            this.tituloLabel.TabIndex = 31;
            this.tituloLabel.Text = "Reporte de citas por cliente";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(47, 116);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(83, 13);
            this.fechaLabel.TabIndex = 32;
            this.fechaLabel.Text = "Doctor a buscar";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.clienteComboBox.BackColor = System.Drawing.Color.White;
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clienteComboBox.Location = new System.Drawing.Point(136, 108);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(144, 21);
            this.clienteComboBox.TabIndex = 33;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(300, 106);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 34;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // citasLabel
            // 
            this.citasLabel.AutoSize = true;
            this.citasLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.citasLabel.Location = new System.Drawing.Point(31, 217);
            this.citasLabel.Name = "citasLabel";
            this.citasLabel.Size = new System.Drawing.Size(126, 16);
            this.citasLabel.TabIndex = 36;
            this.citasLabel.Text = "Citas registradas";
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(47, 177);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(63, 13);
            this.notificacionLabel.TabIndex = 37;
            this.notificacionLabel.Text = "Notificacion";
            // 
            // ReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.citasLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteCliente";
            this.Text = "ReporteCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label citasLabel;
        private System.Windows.Forms.Label notificacionLabel;
    }
}