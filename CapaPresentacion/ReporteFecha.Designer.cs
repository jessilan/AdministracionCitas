namespace CapaPresentacion
{
    partial class ReporteFecha
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
            this.fechaLabel = new System.Windows.Forms.Label();
            this.fechaBuscar = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.citasLabel = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.notificacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(50, 128);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(81, 13);
            this.fechaLabel.TabIndex = 0;
            this.fechaLabel.Text = "Fecha a buscar";
            // 
            // fechaBuscar
            // 
            this.fechaBuscar.CustomFormat = "dd/MM/yyyy H:mm";
            this.fechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaBuscar.Location = new System.Drawing.Point(137, 122);
            this.fechaBuscar.Name = "fechaBuscar";
            this.fechaBuscar.Size = new System.Drawing.Size(141, 20);
            this.fechaBuscar.TabIndex = 20;
            this.fechaBuscar.Value = new System.DateTime(2023, 10, 3, 8, 15, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel.Location = new System.Drawing.Point(154, 34);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(291, 25);
            this.tituloLabel.TabIndex = 29;
            this.tituloLabel.Text = "Reporte de citas por fecha";
            // 
            // citasLabel
            // 
            this.citasLabel.AutoSize = true;
            this.citasLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.citasLabel.Location = new System.Drawing.Point(28, 219);
            this.citasLabel.Name = "citasLabel";
            this.citasLabel.Size = new System.Drawing.Size(126, 16);
            this.citasLabel.TabIndex = 30;
            this.citasLabel.Text = "Citas registradas";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(299, 118);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 31;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // notificacionLabel
            // 
            this.notificacionLabel.AutoSize = true;
            this.notificacionLabel.Location = new System.Drawing.Point(50, 179);
            this.notificacionLabel.Name = "notificacionLabel";
            this.notificacionLabel.Size = new System.Drawing.Size(63, 13);
            this.notificacionLabel.TabIndex = 32;
            this.notificacionLabel.Text = "Notificacion";
            // 
            // ReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 469);
            this.Controls.Add(this.notificacionLabel);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.citasLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fechaBuscar);
            this.Controls.Add(this.fechaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteFecha";
            this.Text = "ReporteFecha";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.DateTimePicker fechaBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label citasLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label notificacionLabel;
    }
}