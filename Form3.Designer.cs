namespace digita
{
    partial class Form3
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
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(112, 46);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 29);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(112, 115);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 29);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(112, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(112, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumAquamarine;
            button1.Location = new Point(117, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(305, 217);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "Form3";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}