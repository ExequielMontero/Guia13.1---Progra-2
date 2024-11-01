namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtenderDenuncia = new System.Windows.Forms.Button();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.rbNuevo);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.rbDenuncia);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patente:";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(169, 33);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(100, 20);
            this.tbPatente.TabIndex = 6;
            this.tbPatente.Text = "QWE123";
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Checked = true;
            this.rbNuevo.Location = new System.Drawing.Point(7, 74);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(92, 17);
            this.rbNuevo.TabIndex = 5;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo Cliente";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Equipo de Trabajo",
            "Bicicleta"});
            this.cbTipo.Location = new System.Drawing.Point(169, 70);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(100, 21);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.Text = "Tipo";
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Location = new System.Drawing.Point(7, 36);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(71, 17);
            this.rbDenuncia.TabIndex = 4;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(52, 12);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 0;
            this.tbDni.Text = "44763336";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(332, 74);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 58);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lbVer
            // 
            this.lbVer.FormattingEnabled = true;
            this.lbVer.Location = new System.Drawing.Point(6, 19);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(298, 108);
            this.lbVer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dni:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbVer);
            this.groupBox2.Location = new System.Drawing.Point(16, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 138);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(332, 201);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 45);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar tickets";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(332, 252);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 45);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Importar tickets";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnAtenderDenuncia
            // 
            this.btnAtenderDenuncia.Location = new System.Drawing.Point(39, 326);
            this.btnAtenderDenuncia.Name = "btnAtenderDenuncia";
            this.btnAtenderDenuncia.Size = new System.Drawing.Size(113, 45);
            this.btnAtenderDenuncia.TabIndex = 9;
            this.btnAtenderDenuncia.Text = "Atender nueva denuncia";
            this.btnAtenderDenuncia.UseVisualStyleBackColor = true;
            this.btnAtenderDenuncia.Click += new System.EventHandler(this.btnAtenderDenuncia_Click);
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Location = new System.Drawing.Point(172, 326);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(113, 45);
            this.btnAtenderCliente.TabIndex = 10;
            this.btnAtenderCliente.Text = "Atender  nuevo cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 396);
            this.Controls.Add(this.btnAtenderCliente);
            this.Controls.Add(this.btnAtenderDenuncia);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtenderDenuncia;
        private System.Windows.Forms.Button btnAtenderCliente;
    }
}

