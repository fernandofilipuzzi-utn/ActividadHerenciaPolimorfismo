
namespace ActividadEnElAula
{
    partial class FormDatos
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbValorConcepto = new System.Windows.Forms.TextBox();
            this.lbConcepto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(109, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceotar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbValorConcepto
            // 
            this.tbValorConcepto.Location = new System.Drawing.Point(153, 30);
            this.tbValorConcepto.Name = "tbValorConcepto";
            this.tbValorConcepto.Size = new System.Drawing.Size(100, 20);
            this.tbValorConcepto.TabIndex = 1;
            // 
            // lbConcepto
            // 
            this.lbConcepto.AutoSize = true;
            this.lbConcepto.Location = new System.Drawing.Point(43, 33);
            this.lbConcepto.Name = "lbConcepto";
            this.lbConcepto.Size = new System.Drawing.Size(35, 13);
            this.lbConcepto.TabIndex = 2;
            this.lbConcepto.Text = "lbConcepto";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 91);
            this.Controls.Add(this.lbConcepto);
            this.Controls.Add(this.tbValorConcepto);
            this.Controls.Add(this.button1);
            this.Name = "form";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbValorConcepto;
        public System.Windows.Forms.Label lbConcepto;
    }
}