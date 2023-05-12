namespace PrySignorileControlesBasicos
{
    partial class frmCajaDeTexto
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
            this.txtReflejo = new System.Windows.Forms.TextBox();
            this.lblreflejo = new System.Windows.Forms.Label();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReflejo
            // 
            this.txtReflejo.Location = new System.Drawing.Point(30, 28);
            this.txtReflejo.Name = "txtReflejo";
            this.txtReflejo.Size = new System.Drawing.Size(100, 20);
            this.txtReflejo.TabIndex = 0;
            this.txtReflejo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblreflejo
            // 
            this.lblreflejo.AutoSize = true;
            this.lblreflejo.Location = new System.Drawing.Point(151, 32);
            this.lblreflejo.Name = "lblreflejo";
            this.lblreflejo.Size = new System.Drawing.Size(0, 13);
            this.lblreflejo.TabIndex = 1;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(119, 86);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 2;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(39, 86);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 3;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(30, 129);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // frmCajaDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 178);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.lblreflejo);
            this.Controls.Add(this.txtReflejo);
            this.Name = "frmCajaDeTexto";
            this.Text = "caja de texto";
            this.Load += new System.EventHandler(this.frmCajaDeTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReflejo;
        private System.Windows.Forms.Label lblreflejo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button cmdAsignar;
    }
}