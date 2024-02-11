namespace Sueldo_empleado_ejer3
{
    partial class Form1
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
            btn_Limpiar = new Button();
            btn_Calcular = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_horas = new TextBox();
            txt_total = new TextBox();
            txt_sfs = new TextBox();
            txt_bruto = new TextBox();
            txt_afp = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txt_neto = new TextBox();
            label9 = new Label();
            txt_pago = new TextBox();
            SuspendLayout();
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(437, 204);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 34);
            btn_Limpiar.TabIndex = 0;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Calcular.Location = new Point(437, 148);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 34);
            btn_Calcular.TabIndex = 1;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_Salir.Location = new Point(437, 260);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 34);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 35);
            label1.Name = "label1";
            label1.Size = new Size(299, 45);
            label1.TabIndex = 3;
            label1.Text = "Sueldo_Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(45, 366);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 4;
            label2.Text = "Sueldo Bruto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(49, 422);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 5;
            label3.Text = "Sueldo Neto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(90, 209);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 6;
            label4.Text = "AFP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(14, 108);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 7;
            label5.Text = "Horas Trabajadas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(92, 260);
            label6.Name = "label6";
            label6.Size = new Size(44, 28);
            label6.TabIndex = 8;
            label6.Text = "SFS";
            // 
            // txt_horas
            // 
            txt_horas.Location = new Point(189, 108);
            txt_horas.Name = "txt_horas";
            txt_horas.Size = new Size(150, 31);
            txt_horas.TabIndex = 9;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(189, 309);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(150, 31);
            txt_total.TabIndex = 10;
            // 
            // txt_sfs
            // 
            txt_sfs.Location = new Point(189, 262);
            txt_sfs.Name = "txt_sfs";
            txt_sfs.Size = new Size(150, 31);
            txt_sfs.TabIndex = 11;
            // 
            // txt_bruto
            // 
            txt_bruto.Location = new Point(189, 363);
            txt_bruto.Name = "txt_bruto";
            txt_bruto.Size = new Size(150, 31);
            txt_bruto.TabIndex = 12;
            // 
            // txt_afp
            // 
            txt_afp.Location = new Point(189, 206);
            txt_afp.Name = "txt_afp";
            txt_afp.Size = new Size(150, 31);
            txt_afp.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 213);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(15, 309);
            label8.Name = "label8";
            label8.Size = new Size(159, 28);
            label8.TabIndex = 15;
            label8.Text = "Total Descuentos";
            // 
            // txt_neto
            // 
            txt_neto.Location = new Point(189, 422);
            txt_neto.Name = "txt_neto";
            txt_neto.Size = new Size(150, 31);
            txt_neto.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(59, 157);
            label9.Name = "label9";
            label9.Size = new Size(112, 28);
            label9.TabIndex = 17;
            label9.Text = "Pago Horas";
            // 
            // txt_pago
            // 
            txt_pago.Location = new Point(189, 154);
            txt_pago.Name = "txt_pago";
            txt_pago.Size = new Size(150, 31);
            txt_pago.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(599, 481);
            Controls.Add(txt_pago);
            Controls.Add(label9);
            Controls.Add(txt_neto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_afp);
            Controls.Add(txt_bruto);
            Controls.Add(txt_sfs);
            Controls.Add(txt_total);
            Controls.Add(txt_horas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Calcular);
            Controls.Add(btn_Limpiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Limpiar;
        private Button btn_Calcular;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_horas;
        private TextBox txt_total;
        private TextBox txt_sfs;
        private TextBox txt_bruto;
        private TextBox txt_afp;
        private Label label7;
        private Label label8;
        private TextBox txt_neto;
        private Label label9;
        private TextBox txt_pago;
    }
}
