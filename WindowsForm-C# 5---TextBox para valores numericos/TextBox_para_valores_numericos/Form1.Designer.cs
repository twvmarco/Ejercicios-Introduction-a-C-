namespace TextBox_para_valores_numericos
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
            lbla = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            lblb = new Label();
            lblresultado = new Label();
            btnsuma = new Button();
            btnresta = new Button();
            btndif = new Button();
            btnmulti = new Button();
            SuspendLayout();
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new Point(31, 54);
            lbla.Name = "lbla";
            lbla.Size = new Size(18, 15);
            lbla.TabIndex = 0;
            lbla.Text = "A:";
            // 
            // txta
            // 
            txta.Location = new Point(70, 51);
            txta.Name = "txta";
            txta.Size = new Size(100, 23);
            txta.TabIndex = 1;
            txta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtb
            // 
            txtb.Location = new Point(70, 90);
            txtb.Name = "txtb";
            txtb.Size = new Size(100, 23);
            txtb.TabIndex = 2;
            txtb.TextAlign = HorizontalAlignment.Right;
            // 
            // lblb
            // 
            lblb.AutoSize = true;
            lblb.Location = new Point(31, 98);
            lblb.Name = "lblb";
            lblb.Size = new Size(17, 15);
            lblb.TabIndex = 3;
            lblb.Text = "B:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(120, 148);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(59, 15);
            lblresultado.TabIndex = 4;
            lblresultado.Text = "Resultado";
            // 
            // btnsuma
            // 
            btnsuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsuma.Location = new Point(205, 51);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(33, 25);
            btnsuma.TabIndex = 5;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnresta
            // 
            btnresta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresta.Location = new Point(256, 51);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(33, 25);
            btnresta.TabIndex = 6;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = true;
            btnresta.Click += btnresta_Click;
            // 
            // btndif
            // 
            btndif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndif.Location = new Point(256, 88);
            btndif.Name = "btndif";
            btndif.Size = new Size(33, 25);
            btndif.TabIndex = 8;
            btndif.Text = "/";
            btndif.UseVisualStyleBackColor = true;
            btndif.Click += btndif_Click;
            // 
            // btnmulti
            // 
            btnmulti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmulti.Location = new Point(205, 88);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(33, 25);
            btnmulti.TabIndex = 7;
            btnmulti.Text = "*";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 187);
            Controls.Add(btndif);
            Controls.Add(btnmulti);
            Controls.Add(btnresta);
            Controls.Add(btnsuma);
            Controls.Add(lblresultado);
            Controls.Add(lblb);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(lbla);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbla;
        private TextBox txta;
        private TextBox txtb;
        private Label lblb;
        private Label lblresultado;
        private Button btnsuma;
        private Button btnresta;
        private Button btndif;
        private Button btnmulti;
    }
}
