namespace digita
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            btnCad = new Button();
            btnGuest = new Button();
            txtLogin = new TextBox();
            imageList1 = new ImageList(components);
            labl1 = new Label();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSlateBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.MediumSpringGreen;
            btnLogin.Location = new Point(121, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCad
            // 
            btnCad.BackColor = Color.MediumSlateBlue;
            btnCad.FlatStyle = FlatStyle.Flat;
            btnCad.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCad.ForeColor = Color.MediumSpringGreen;
            btnCad.Location = new Point(121, 318);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(143, 30);
            btnCad.TabIndex = 3;
            btnCad.Text = "CADASTRAR";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.MediumSlateBlue;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuest.ForeColor = Color.MediumSpringGreen;
            btnGuest.Location = new Point(121, 367);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(143, 30);
            btnGuest.TabIndex = 4;
            btnGuest.Text = "SEM LOGIN";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(121, 121);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(143, 29);
            txtLogin.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labl1.ForeColor = Color.WhiteSmoke;
            labl1.Location = new Point(121, 94);
            labl1.Name = "labl1";
            labl1.Size = new Size(110, 24);
            labl1.TabIndex = 2;
            labl1.Text = "USUÁRIO";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(121, 193);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(143, 29);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(121, 166);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 2;
            label1.Text = "SENHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(121, 18);
            label2.Name = "label2";
            label2.Size = new Size(139, 43);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(389, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labl1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnGuest);
            Controls.Add(btnCad);
            Controls.Add(btnLogin);
            Name = "Form2";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCad;
        private Button btnGuest;
        private TextBox txtLogin;
        private ImageList imageList1;
        private Label labl1;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
    }
}