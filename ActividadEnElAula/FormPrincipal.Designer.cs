
namespace ActividadEnElAula
{
    partial class FormPrincipal
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
            this.lbxTicket = new System.Windows.Forms.ListBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaEnvio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCostosPosibles = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Tiket = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Tiket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxTicket
            // 
            this.lbxTicket.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTicket.FormattingEnabled = true;
            this.lbxTicket.ItemHeight = 16;
            this.lbxTicket.Location = new System.Drawing.Point(5, 19);
            this.lbxTicket.Name = "lbxTicket";
            this.lbxTicket.Size = new System.Drawing.Size(439, 132);
            this.lbxTicket.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(178, 157);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(111, 42);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Text = "Imprimir ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaEnvio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciando envío";
            // 
            // btnAltaEnvio
            // 
            this.btnAltaEnvio.Location = new System.Drawing.Point(29, 151);
            this.btnAltaEnvio.Name = "btnAltaEnvio";
            this.btnAltaEnvio.Size = new System.Drawing.Size(111, 42);
            this.btnAltaEnvio.TabIndex = 5;
            this.btnAltaEnvio.Text = "Alta Envío";
            this.btnAltaEnvio.UseVisualStyleBackColor = true;
            this.btnAltaEnvio.Click += new System.EventHandler(this.btnAltaEnvio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxCostosPosibles);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(192, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregando costos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona Costo";
            // 
            // cbxCostosPosibles
            // 
            this.cbxCostosPosibles.FormattingEnabled = true;
            this.cbxCostosPosibles.Location = new System.Drawing.Point(150, 51);
            this.cbxCostosPosibles.Name = "cbxCostosPosibles";
            this.cbxCostosPosibles.Size = new System.Drawing.Size(121, 21);
            this.cbxCostosPosibles.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Agregando costos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCostos_Click);
            // 
            // Tiket
            // 
            this.Tiket.Controls.Add(this.lbxTicket);
            this.Tiket.Controls.Add(this.btnTicket);
            this.Tiket.Location = new System.Drawing.Point(492, 12);
            this.Tiket.Name = "Tiket";
            this.Tiket.Size = new System.Drawing.Size(450, 199);
            this.Tiket.TabIndex = 4;
            this.Tiket.TabStop = false;
            this.Tiket.Text = "Tiket";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 218);
            this.Controls.Add(this.Tiket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Tiket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTicket;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaEnvio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Tiket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCostosPosibles;
    }
}

