namespace TexBox_para_cadenas
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
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblmensaje = new Label();
            btnsaludo = new Button();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblnombre.Location = new Point(24, 23);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(91, 25);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(121, 28);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(189, 23);
            txtnombre.TabIndex = 1;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmensaje.Location = new Point(24, 102);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(51, 20);
            lblmensaje.TabIndex = 2;
            lblmensaje.Text = "label1";
            // 
            // btnsaludo
            // 
            btnsaludo.Location = new Point(224, 57);
            btnsaludo.Name = "btnsaludo";
            btnsaludo.Size = new Size(86, 33);
            btnsaludo.TabIndex = 3;
            btnsaludo.Text = "Saludo";
            btnsaludo.UseVisualStyleBackColor = true;
            btnsaludo.Click += btnsaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 161);
            Controls.Add(btnsaludo);
            Controls.Add(lblmensaje);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
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

        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblmensaje;
        private Button btnsaludo;
    }
}
