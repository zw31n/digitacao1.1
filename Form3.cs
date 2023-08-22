using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digita
{
    public partial class Form3 : Form
    {
        MySqlConnection conect = new MySqlConnection("Server = aws.connect.psdb.cloud; Database=digitacao-users;user=qgx252desg8g1rulw48f;password=pscale_pw_CbaHfe6t5te3B6CxYaPtplbR42xtZMPCbVxGVpJxq5b;SslMode=VerifyFull;");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Open();
                string query = "insert into usuario(id, senha, lvl) values('" + txtLogin.Text + "', '" + txtSenha.Text + "',0)";
                MySqlDataAdapter dp = new MySqlDataAdapter(query, conect);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                conect.Close();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao se conectar ao banco de dados!!" + ex.Message);
                conect.Close();
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();

            }
        }
    }
}
