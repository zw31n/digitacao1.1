using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace digita
{

    public partial class Form2 : Form
    {
        MySqlConnection conect = new MySqlConnection("Server = aws.connect.psdb.cloud; Database=digitacao-users;user=qgx252desg8g1rulw48f;password=pscale_pw_CbaHfe6t5te3B6CxYaPtplbR42xtZMPCbVxGVpJxq5b;SslMode=VerifyFull;");


        public Form2()
        {
            InitializeComponent();
            /*
            try
            {

                var strConect = "server=localhost;uid=root;pwd=1234;database=registro";
                var conect = new MySqlConnection(strConect);
                conect.Open();
                MessageBox.Show("Conexão OK!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar!" + ex.Message);
            }
            */
        }

        public string User { get; set; }
        public int Lvl { get; set; }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Open();
                string query = "select * from  usuario where id = '" + txtLogin.Text + "' and senha = '" + txtSenha.Text + "'";
                MySqlDataAdapter dp = new MySqlDataAdapter(query, conect);
                MySqlCommand cmd = new MySqlCommand(query, conect);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MySqlDataReader dataReader;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        User = dataReader.GetString("id");
                        Lvl = dataReader.GetInt32("lvl");
                    }
                    conect.Close();
                    this.Hide();
                    Form f = new Form1(Lvl, User);
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!!");
                    conect.Close();
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtLogin.Focus();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao se conectar ao banco de dados!!" + ex.Message);
                conect.Close();
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Form3 cadastro = new Form3();
            cadastro.Show();

        }
    }
}
