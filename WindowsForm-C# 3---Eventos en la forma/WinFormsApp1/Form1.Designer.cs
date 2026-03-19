namespace WinFormsApp1
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
            lblmensaje = new Label();
            btnsaludo = new Button();
            btndespedida = new Button();
            SuspendLayout();
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmensaje.Location = new Point(35, 74);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(57, 21);
            lblmensaje.TabIndex = 0;
            lblmensaje.Text = "label1";
            // 
            // btnsaludo
            // 
            btnsaludo.FlatStyle = FlatStyle.Flat;
            btnsaludo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsaludo.ForeColor = Color.FromArgb(0, 192, 0);
            btnsaludo.Location = new Point(159, 23);
            btnsaludo.Name = "btnsaludo";
            btnsaludo.Size = new Size(121, 53);
            btnsaludo.TabIndex = 1;
            btnsaludo.Text = "Saludo!";
            btnsaludo.UseVisualStyleBackColor = true;
            btnsaludo.Click += btnsaludo_Click;
            // 
            // btndespedida
            // 
            btndespedida.FlatStyle = FlatStyle.Flat;
            btndespedida.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndespedida.ForeColor = Color.Red;
            btndespedida.Location = new Point(159, 116);
            btndespedida.Name = "btndespedida";
            btndespedida.Size = new Size(121, 53);
            btndespedida.TabIndex = 2;
            btndespedida.Text = "Despedida";
            btndespedida.UseVisualStyleBackColor = true;
            btndespedida.UseWaitCursor = true;
            btndespedida.Click += btndespedida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 194);
            Controls.Add(btndespedida);
            Controls.Add(btnsaludo);
            Controls.Add(lblmensaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmensaje;
        private Button btnsaludo;
        private Button btndespedida;
    }
}
