namespace Area_y_volumen
{
    partial class frmCalculoareavolumen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlturaCal = new System.Windows.Forms.Label();
            this.lblCanculo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCalaltura = new System.Windows.Forms.TextBox();
            this.txtDaiametrocal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diamentro";
            // 
            // lblAlturaCal
            // 
            this.lblAlturaCal.AutoSize = true;
            this.lblAlturaCal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlturaCal.Location = new System.Drawing.Point(23, 125);
            this.lblAlturaCal.Name = "lblAlturaCal";
            this.lblAlturaCal.Size = new System.Drawing.Size(65, 28);
            this.lblAlturaCal.TabIndex = 1;
            this.lblAlturaCal.Text = "Altura";
            this.lblAlturaCal.Click += new System.EventHandler(this.lblAlturaCal_Click);
            // 
            // lblCanculo
            // 
            this.lblCanculo.AutoSize = true;
            this.lblCanculo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCanculo.Location = new System.Drawing.Point(219, 19);
            this.lblCanculo.Name = "lblCanculo";
            this.lblCanculo.Size = new System.Drawing.Size(330, 37);
            this.lblCanculo.TabIndex = 0;
            this.lblCanculo.Text = "Calculo de area y volumen";
            this.lblCanculo.Click += new System.EventHandler(this.lblCanculo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(355, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(653, 404);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LImpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtCalaltura
            // 
            this.txtCalaltura.Location = new System.Drawing.Point(94, 130);
            this.txtCalaltura.Name = "txtCalaltura";
            this.txtCalaltura.Size = new System.Drawing.Size(132, 23);
            this.txtCalaltura.TabIndex = 6;
            this.txtCalaltura.TextChanged += new System.EventHandler(this.txtCalaltura_TextChanged);
            // 
            // txtDaiametrocal
            // 
            this.txtDaiametrocal.Location = new System.Drawing.Point(134, 280);
            this.txtDaiametrocal.Name = "txtDaiametrocal";
            this.txtDaiametrocal.Size = new System.Drawing.Size(132, 23);
            this.txtDaiametrocal.TabIndex = 7;
            this.txtDaiametrocal.TextChanged += new System.EventHandler(this.txtDaiametrocal_TextChanged);
            // 
            // frmCalculoareavolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDaiametrocal);
            this.Controls.Add(this.txtCalaltura);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlturaCal);
            this.Controls.Add(this.lblCanculo);
            this.Name = "frmCalculoareavolumen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblAlturaCal;
        private Label lblCanculo;
        private Button btnCalcular;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtCalaltura;
        private TextBox txtDaiametrocal;
    }
}