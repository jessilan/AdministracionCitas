namespace CapaPresentacion
{
    partial class ReporteDoctor
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
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
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
            this.tituloLabel.Location = new System.Drawing.Point(157, 34);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(301, 25);
            this.tituloLabel.TabIndex = 30;
            this.tituloLabel.Text = "Reporte de citas por doctor";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(57, 128);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(83, 13);
            this.fechaLabel.TabIndex = 31;
            this.fechaLabel.Text = "Doctor a buscar";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.doctorComboBox.BackColor = System.Drawing.Color.White;
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.doctorComboBox.Location = new System.Drawing.Point(146, 120);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(150, 21);
            this.doctorComboBox.TabIndex = 32;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(322, 120);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 33;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // citasLabel
            // 
            this.citasLabel.AutoSize = true;
            this.citasLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.citasLabel.Location = new System.Drawing.Point(32, 220);
            this.citasLabel.Name = "citasLabel";
            this.citasLabel.Size = new System.Drawing.Size(126, 16);
            this.citasLabel.TabIndex = 35;
            this.citasLabel.Text = "Citas registradas";
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(57, 180);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(63, 13);
            this.notificacionLabel.TabIndex = 36;
            this.notificacionLabel.Text = "Notificacion";
            // 
            // ReporteDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.citasLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDoctor";
            this.Text = "ReporteDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label citasLabel;
        private System.Windows.Forms.Label notificacionLabel;
    }
}