namespace CapaPresentacion
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.submenuPanel = new System.Windows.Forms.Panel();
            this.reporreClienteButton = new System.Windows.Forms.Button();
            this.reporteDoctorButton = new System.Windows.Forms.Button();
            this.reporteFechaButton = new System.Windows.Forms.Button();
            this.salirBoton = new System.Windows.Forms.Button();
            this.reporteFechaBoton = new System.Windows.Forms.Button();
            this.administracionDoctorBoton = new System.Windows.Forms.Button();
            this.registroCitasBoton = new System.Windows.Forms.Button();
            this.administracionClienteBoton = new System.Windows.Forms.Button();
            this.registroConsultaBoton = new System.Windows.Forms.Button();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tituloLabel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.submenuPanel.SuspendLayout();
            this.encabezadoPanel.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.pictureBox3);
            this.menuPanel.Controls.Add(this.submenuPanel);
            this.menuPanel.Controls.Add(this.salirBoton);
            this.menuPanel.Controls.Add(this.reporteFechaBoton);
            this.menuPanel.Controls.Add(this.administracionDoctorBoton);
            this.menuPanel.Controls.Add(this.registroCitasBoton);
            this.menuPanel.Controls.Add(this.administracionClienteBoton);
            this.menuPanel.Controls.Add(this.registroConsultaBoton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 37);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(301, 679);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(81, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 138);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // submenuPanel
            // 
            this.submenuPanel.Controls.Add(this.reporreClienteButton);
            this.submenuPanel.Controls.Add(this.reporteDoctorButton);
            this.submenuPanel.Controls.Add(this.reporteFechaButton);
            this.submenuPanel.Location = new System.Drawing.Point(55, 478);
            this.submenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.submenuPanel.Name = "submenuPanel";
            this.submenuPanel.Size = new System.Drawing.Size(227, 127);
            this.submenuPanel.TabIndex = 12;
            // 
            // reporreClienteButton
            // 
            this.reporreClienteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reporreClienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reporreClienteButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporreClienteButton.Location = new System.Drawing.Point(0, 78);
            this.reporreClienteButton.Margin = new System.Windows.Forms.Padding(4);
            this.reporreClienteButton.Name = "reporreClienteButton";
            this.reporreClienteButton.Size = new System.Drawing.Size(227, 39);
            this.reporreClienteButton.TabIndex = 11;
            this.reporreClienteButton.Text = "Por cliente";
            this.reporreClienteButton.UseVisualStyleBackColor = false;
            this.reporreClienteButton.Click += new System.EventHandler(this.reporreClienteButton_Click);
            // 
            // reporteDoctorButton
            // 
            this.reporteDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reporteDoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reporteDoctorButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDoctorButton.Location = new System.Drawing.Point(0, 39);
            this.reporteDoctorButton.Margin = new System.Windows.Forms.Padding(4);
            this.reporteDoctorButton.Name = "reporteDoctorButton";
            this.reporteDoctorButton.Size = new System.Drawing.Size(227, 39);
            this.reporteDoctorButton.TabIndex = 10;
            this.reporteDoctorButton.Text = "Por doctor";
            this.reporteDoctorButton.UseVisualStyleBackColor = false;
            this.reporteDoctorButton.Click += new System.EventHandler(this.reporteDoctorButton_Click);
            // 
            // reporteFechaButton
            // 
            this.reporteFechaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reporteFechaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reporteFechaButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteFechaButton.Location = new System.Drawing.Point(0, 0);
            this.reporteFechaButton.Margin = new System.Windows.Forms.Padding(4);
            this.reporteFechaButton.Name = "reporteFechaButton";
            this.reporteFechaButton.Size = new System.Drawing.Size(227, 39);
            this.reporteFechaButton.TabIndex = 9;
            this.reporteFechaButton.Text = "Por fecha";
            this.reporteFechaButton.UseVisualStyleBackColor = false;
            this.reporteFechaButton.Click += new System.EventHandler(this.reporteFechaButton_Click);
            // 
            // salirBoton
            // 
            this.salirBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.salirBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBoton.Location = new System.Drawing.Point(81, 629);
            this.salirBoton.Margin = new System.Windows.Forms.Padding(4);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(133, 36);
            this.salirBoton.TabIndex = 10;
            this.salirBoton.Text = "Salir";
            this.salirBoton.UseVisualStyleBackColor = false;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // reporteFechaBoton
            // 
            this.reporteFechaBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reporteFechaBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteFechaBoton.Location = new System.Drawing.Point(16, 434);
            this.reporteFechaBoton.Margin = new System.Windows.Forms.Padding(4);
            this.reporteFechaBoton.Name = "reporteFechaBoton";
            this.reporteFechaBoton.Size = new System.Drawing.Size(265, 36);
            this.reporteFechaBoton.TabIndex = 7;
            this.reporteFechaBoton.Text = "Reportes";
            this.reporteFechaBoton.UseVisualStyleBackColor = false;
            this.reporteFechaBoton.Click += new System.EventHandler(this.reporteFechaBoton_Click);
            // 
            // administracionDoctorBoton
            // 
            this.administracionDoctorBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.administracionDoctorBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionDoctorBoton.Location = new System.Drawing.Point(16, 325);
            this.administracionDoctorBoton.Margin = new System.Windows.Forms.Padding(4);
            this.administracionDoctorBoton.Name = "administracionDoctorBoton";
            this.administracionDoctorBoton.Size = new System.Drawing.Size(265, 36);
            this.administracionDoctorBoton.TabIndex = 5;
            this.administracionDoctorBoton.Text = "Administración de doctores";
            this.administracionDoctorBoton.UseVisualStyleBackColor = false;
            this.administracionDoctorBoton.Click += new System.EventHandler(this.administracionDoctorBoton_Click);
            // 
            // registroCitasBoton
            // 
            this.registroCitasBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registroCitasBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroCitasBoton.Location = new System.Drawing.Point(16, 379);
            this.registroCitasBoton.Margin = new System.Windows.Forms.Padding(4);
            this.registroCitasBoton.Name = "registroCitasBoton";
            this.registroCitasBoton.Size = new System.Drawing.Size(265, 36);
            this.registroCitasBoton.TabIndex = 6;
            this.registroCitasBoton.Text = "Registro de citas";
            this.registroCitasBoton.UseVisualStyleBackColor = false;
            this.registroCitasBoton.Click += new System.EventHandler(this.button5_Click);
            // 
            // administracionClienteBoton
            // 
            this.administracionClienteBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.administracionClienteBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionClienteBoton.Location = new System.Drawing.Point(16, 270);
            this.administracionClienteBoton.Margin = new System.Windows.Forms.Padding(4);
            this.administracionClienteBoton.Name = "administracionClienteBoton";
            this.administracionClienteBoton.Size = new System.Drawing.Size(265, 36);
            this.administracionClienteBoton.TabIndex = 4;
            this.administracionClienteBoton.Text = "Administración de clientes";
            this.administracionClienteBoton.UseVisualStyleBackColor = false;
            this.administracionClienteBoton.Click += new System.EventHandler(this.administracionClienteBoton_Click);
            // 
            // registroConsultaBoton
            // 
            this.registroConsultaBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registroConsultaBoton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroConsultaBoton.ForeColor = System.Drawing.Color.Black;
            this.registroConsultaBoton.Location = new System.Drawing.Point(16, 214);
            this.registroConsultaBoton.Margin = new System.Windows.Forms.Padding(4);
            this.registroConsultaBoton.Name = "registroConsultaBoton";
            this.registroConsultaBoton.Size = new System.Drawing.Size(265, 36);
            this.registroConsultaBoton.TabIndex = 3;
            this.registroConsultaBoton.Text = "Registro tipo consulta";
            this.registroConsultaBoton.UseVisualStyleBackColor = false;
            this.registroConsultaBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.White;
            this.encabezadoPanel.Controls.Add(this.botonSalir);
            this.encabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(1176, 37);
            this.encabezadoPanel.TabIndex = 1;
            this.encabezadoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.encabezadoPanel_MouseDown);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.White;
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.Black;
            this.botonSalir.Location = new System.Drawing.Point(1136, 0);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(40, 37);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "X";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click_1);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.White;
            this.panelDatos.Controls.Add(this.panelInicio);
            this.panelDatos.Location = new System.Drawing.Point(325, 55);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(823, 629);
            this.panelDatos.TabIndex = 2;
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.pictureBox1);
            this.panelInicio.Controls.Add(this.tituloLabel2);
            this.panelInicio.Controls.Add(this.pictureBox2);
            this.panelInicio.Location = new System.Drawing.Point(27, 23);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(4);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(777, 586);
            this.panelInicio.TabIndex = 12;
            this.panelInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInicio_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(249, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administración de citas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 382);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // tituloLabel2
            // 
            this.tituloLabel2.AutoSize = true;
            this.tituloLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tituloLabel2.Location = new System.Drawing.Point(225, 523);
            this.tituloLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel2.Name = "tituloLabel2";
            this.tituloLabel2.Size = new System.Drawing.Size(374, 31);
            this.tituloLabel2.TabIndex = 11;
            this.tituloLabel2.Text = "de los dentistas de San José";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(573, 422);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 140);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1176, 716);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.encabezadoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMenu_MouseDown);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.submenuPanel.ResumeLayout(false);
            this.encabezadoPanel.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button reporteFechaBoton;
        private System.Windows.Forms.Button administracionDoctorBoton;
        private System.Windows.Forms.Button registroCitasBoton;
        private System.Windows.Forms.Button administracionClienteBoton;
        private System.Windows.Forms.Button registroConsultaBoton;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel submenuPanel;
        private System.Windows.Forms.Button reporreClienteButton;
        private System.Windows.Forms.Button reporteDoctorButton;
        private System.Windows.Forms.Button reporteFechaButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tituloLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label label1;
    }
}

