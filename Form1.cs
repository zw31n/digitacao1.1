
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace digita
{
    

    public partial class Form1 : Form
    {
        MySqlConnection conect = new MySqlConnection("Server = aws.connect.psdb.cloud; Database=digitacao-users;user=qgx252desg8g1rulw48f;password=pscale_pw_CbaHfe6t5te3B6CxYaPtplbR42xtZMPCbVxGVpJxq5b;SslMode=VerifyFull;");
        private int Segundos;
        string lvl1 = new StringBuilder("asdfg çlkjh zxcvb ;.,mn qwert poiuy ".Length * 1).Insert(0, "asdfg çlkjh zxcvb ;.,mn qwert poiuy ", 1).ToString();
        string lvl2 = new StringBuilder("gfdsa hjklç bvcxz nm,.; trewq yuiop ".Length * 1).Insert(0, "gfdsa hjklç bvcxz nm,.; trewq yuiop ", 1).ToString();
        string lvl3 = new StringBuilder("agsfd hçjlk zbxvc n;m., qtwre ypuoi ".Length * 1).Insert(0, "agsfd hçjlk zbxvc n;m., qtwre ypuoi ", 1).ToString();
        string letra = "", user = "";
        int cont = 0, lvl = 0, pontos = 0;
        string licao = "";
        string[] levels;
        double efi = 0, i = 0, digitos = 0;
        public Form1(int Lvl, string User)
        {
            InitializeComponent();
            levels = new string[] { lvl1, lvl2, lvl3 };
            lvl = Lvl;
            user = User;

        }
        private void eficiencia()
        {
            digitos = pontos;
            i = cont - 1;
            i++;
            efi = Math.Round(100 - (100 - (digitos * 100) / i) * -1, 0);
            if (efi < 0)
            {
                efi = 0;
            }
            lblPontos.Text = efi.ToString() + "%";
        }
        private void BTN()
        {

            if (letra == "a")
            {
                btnA.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnA.BackColor = Color.Indigo;
            }

            if (letra == "á")
            {
                btn_Aact.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btn_Aact.BackColor = Color.Indigo;
            }

            if (letra == "â")
            {
                btn_Acirc.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btn_Acirc.BackColor = Color.Indigo;
            }

            if (letra == "ã")
            {
                btn_Atil.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btn_Atil.BackColor = Color.Indigo;
            }

            if (letra == "s")
            {
                btnS.BackColor = Color.MediumBlue;
            }
            else
            {
                btnS.BackColor = Color.Indigo;
            }

            if (letra == "d")
            {
                btnD.BackColor = Color.Tomato;
            }
            else
            {
                btnD.BackColor = Color.Indigo;
            }

            if (letra == "f")
            {
                btnF.BackColor = Color.DarkRed;
            }
            else
            {
                btnF.BackColor = Color.Indigo;
            }

            if (letra == "g")
            {
                btnG.BackColor = Color.DarkRed;
            }
            else
            {
                btnG.BackColor = Color.Indigo;
            }

            if (letra == "h")
            {
                btnH.BackColor = Color.DarkRed; ;
            }
            else
            {
                btnH.BackColor = Color.Indigo;
            }

            if (letra == "j")
            {
                btnJ.BackColor = Color.DarkRed;
            }
            else
            {
                btnJ.BackColor = Color.Indigo;
            }

            if (letra == "k")
            {
                btnK.BackColor = Color.Tomato;
            }
            else
            {
                btnK.BackColor = Color.Indigo;
            }

            if (letra == "l")
            {
                btnL.BackColor = Color.MediumBlue;
            }
            else
            {
                btnL.BackColor = Color.Indigo;
            }

            if (letra == "ç")
            {
                btnÇ.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnÇ.BackColor = Color.Indigo;
            }

            if (letra == "z")
            {
                btnZ.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnZ.BackColor = Color.Indigo;
            }

            if (letra == "x")
            {
                btnX.BackColor = Color.MediumBlue;
            }
            else
            {
                btnX.BackColor = Color.Indigo;
            }

            if (letra == "c")
            {
                btnC.BackColor = Color.Tomato;
            }
            else
            {
                btnC.BackColor = Color.Indigo;
            }

            if (letra == "v")
            {
                btnV.BackColor = Color.DarkRed;
            }
            else
            {
                btnV.BackColor = Color.Indigo;
            }

            if (letra == "b")
            {
                btnB.BackColor = Color.DarkRed;
            }
            else
            {
                btnB.BackColor = Color.Indigo;
            }

            if (letra == "n")
            {
                btnN.BackColor = Color.DarkRed; ;
            }
            else
            {
                btnN.BackColor = Color.Indigo;
            }

            if (letra == "m")
            {
                btnM.BackColor = Color.DarkRed;
            }
            else
            {
                btnM.BackColor = Color.Indigo;
            }

            if (letra == ",")
            {
                btnVG.BackColor = Color.Tomato;
            }
            else
            {
                btnVG.BackColor = Color.Indigo;
            }

            if (letra == ".")
            {
                btnPT.BackColor = Color.MediumBlue;
            }
            else
            {
                btnPT.BackColor = Color.Indigo;
            }

            if (letra == ";")
            {
                btnPV.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnPV.BackColor = Color.Indigo;
            }

            if (letra == "q")
            {
                btnQ.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnQ.BackColor = Color.Indigo;
            }

            if (letra == "w")
            {
                btnW.BackColor = Color.MediumBlue;
            }
            else
            {
                btnW.BackColor = Color.Indigo;
            }

            if (letra == "e")
            {
                btnE.BackColor = Color.Tomato;
            }
            else
            {
                btnE.BackColor = Color.Indigo;
            }

            if (letra == "é")
            {
                btn_Eact.BackColor = Color.Tomato;
            }
            else
            {
                btn_Eact.BackColor = Color.Indigo;
            }

            if (letra == "ê")
            {
                btn_Ecirc.BackColor = Color.Tomato;
            }
            else
            {
                btn_Ecirc.BackColor = Color.Indigo;
            }

            if (letra == "r")
            {
                btnR.BackColor = Color.DarkRed;
            }
            else
            {
                btnR.BackColor = Color.Indigo;
            }


            if (letra == "t")
            {
                btnT.BackColor = Color.DarkRed;
            }
            else
            {
                btnT.BackColor = Color.Indigo;
            }

            if (letra == "y")
            {
                btnY.BackColor = Color.DarkRed;
            }
            else
            {
                btnY.BackColor = Color.Indigo;
            }

            if (letra == "u")
            {
                btnU.BackColor = Color.DarkRed;
            }
            else
            {
                btnU.BackColor = Color.Indigo;
            }

            if (letra == "ú")
            {
                btn_Uact.BackColor = Color.DarkRed;
            }
            else
            {
                btn_Uact.BackColor = Color.Indigo;
            }

            if (letra == "i")
            {
                btnI.BackColor = Color.Tomato;
            }
            else
            {
                btnI.BackColor = Color.Indigo;
            }

            if (letra == "o")
            {
                btnO.BackColor = Color.MediumBlue;
            }
            else
            {
                btnO.BackColor = Color.Indigo;
            }

            if (letra == "ó")
            {
                btn_Oact.BackColor = Color.MediumBlue;
            }
            else
            {
                btn_Oact.BackColor = Color.Indigo;
            }

            if (letra == "p")
            {
                btnP.BackColor = Color.MediumVioletRed;
            }
            else
            {
                btnP.BackColor = Color.Indigo;
            }

            if (letra == " ")
            {
                btnEspace.BackColor = Color.HotPink;
            }
            else
            {
                btnEspace.BackColor = Color.Indigo;
            }
        }

        private void atualiza()
        {
            letra = licao.Substring(cont, 1);
            lblPontos.Text = pontos.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           if (lvl >= 3)
            {
                lvl = 2;
                MessageBox.Show("Por enquanto, vamos até aqui!!");
            }
            
            lblLvl.Text = (lvl + 1).ToString();
            pontos = 0;
            lblTime.Text = "00:00";
            licao = levels[lvl];
            cont = 0;
            atualiza();
            BTN();
            textBox1.Clear();
            btnIniciar.Enabled = false;
            textBox1.Enabled = true;
            textBox1.Focus();

            int minutos = 2;
            int segundos = 30;
            Segundos = (minutos * 60) + segundos;
            this.timer1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cont == licao.Length - 2)
            {
                textBox1.Clear();
                textBox1.Enabled = false;
                btnIniciar.Enabled = true;
                cont = 0;
                letra = "";
                BTN();
                timer1.Enabled = false;

                if (efi >= 80)
                {
                    lblTime.Text = "00:00";
                    lvl++;
                  
                    try
                    {
                        conect.Open();
                        string query = "UPDATE usuario set lvl = " + lvl + " WHERE id = '" + user + "'";
                        MySqlDataAdapter dp = new MySqlDataAdapter(query, conect);
                        DataTable dt = new DataTable();
                        dp.Fill(dt);
                        conect.Close();
                        MessageBox.Show("TUDO CERTO!");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops! Algo deu errado..." + ex.Message);
                            
                    }
                    lblfrase.Text = "PARABÉNS! VOCÊ ALCANÇOU O PRÓXIMO NÍVEL!!";
                }
                else
                {
                    lblTime.Text = "00:00";
                    timer1.Enabled = false;
                    lblfrase.Text = "SUA EFICIÊNCIA FOI BAIXA!! TENTE NOVAMENTE";
                    textBox1.Enabled = false;
                    btnIniciar.Enabled = true;
                }

                if (lvl >= 3)
                {
                    MessageBox.Show("VOCÊ TERMINOU O BETA TESTER!!");
                    Application.Exit();
                }
            }
            if (e.KeyChar.ToString().ToUpper() == letra.ToUpper())
            {
                textBox1.Text += letra;
                textBox1.SelectionStart = textBox1.Text.Length;
                cont++;
                atualiza();
                BTN();
                btnIniciar.Focus();
            }

            pontos++;
            eficiencia();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Segundos > 0)
            {
                Segundos--;
                int minutos = Segundos / 60;
                int segundos = Segundos - (minutos * 60);
                lblTime.Text = minutos.ToString() + ":" + segundos.ToString();
            }
            else
            {
                lblTime.Text = "00:00";
                timer1.Enabled = false;
                lblfrase.Text = "SEU TEMPO ACABOU! TENTE NOVAMETE!!";
                textBox1.Enabled = false;
                btnIniciar.Enabled = true;
            }
        }
    }
}
