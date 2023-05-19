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
            this.mrcAderezo = new System.Windows.Forms.GroupBox();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.cboAdicional = new System.Windows.Forms.ComboBox();
            this.mrcAderezo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReflejo
            // 
            this.txtReflejo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReflejo.Location = new System.Drawing.Point(22, 14);
            this.txtReflejo.Name = "txtReflejo";
            this.txtReflejo.Size = new System.Drawing.Size(100, 20);
            this.txtReflejo.TabIndex = 0;
            this.txtReflejo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblreflejo
            // 
            this.lblreflejo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblreflejo.AutoSize = true;
            this.lblreflejo.Location = new System.Drawing.Point(19, 103);
            this.lblreflejo.Name = "lblreflejo";
            this.lblreflejo.Size = new System.Drawing.Size(0, 13);
            this.lblreflejo.TabIndex = 1;
            // 
            // optAzul
            // 
            this.optAzul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(90, 40);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 2;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(10, 40);
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
            this.cmdAsignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdAsignar.Location = new System.Drawing.Point(34, 63);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // mrcAderezo
            // 
            this.mrcAderezo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcAderezo.Controls.Add(this.chkPicante);
            this.mrcAderezo.Controls.Add(this.chkMayonesa);
            this.mrcAderezo.Controls.Add(this.chkKetchup);
            this.mrcAderezo.Location = new System.Drawing.Point(22, 149);
            this.mrcAderezo.Name = "mrcAderezo";
            this.mrcAderezo.Size = new System.Drawing.Size(100, 100);
            this.mrcAderezo.TabIndex = 5;
            this.mrcAderezo.TabStop = false;
            this.mrcAderezo.Text = "Aderezo";
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(10, 19);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(62, 17);
            this.chkPicante.TabIndex = 6;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(10, 42);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 7;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(10, 65);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(66, 17);
            this.chkKetchup.TabIndex = 8;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSeleccionar.Location = new System.Drawing.Point(34, 255);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionar.TabIndex = 6;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // lblEscribir
            // 
            this.lblEscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEscribir.AutoSize = true;
            this.lblEscribir.Location = new System.Drawing.Point(19, 291);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(0, 13);
            this.lblEscribir.TabIndex = 7;
            // 
            // cboAdicional
            // 
            this.cboAdicional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(14, 322);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(121, 21);
            this.cboAdicional.TabIndex = 8;
            // 
            // frmCajaDeTexto
            // 
            this.AcceptButton = this.cmdAsignar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 355);
            this.Controls.Add(this.cboAdicional);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.mrcAderezo);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.lblreflejo);
            this.Controls.Add(this.txtReflejo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCajaDeTexto";
            this.Text = "caja de texto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCajaDeTexto_Load);
            this.mrcAderezo.ResumeLayout(false);
            this.mrcAderezo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReflejo;
        private System.Windows.Forms.Label lblreflejo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.GroupBox mrcAderezo;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.ComboBox cboAdicional;
    }
}