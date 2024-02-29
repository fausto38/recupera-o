using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace recuperação
{
    public partial class telalogin : Form
    {
        int acesso = 1;
        
        public telalogin()
        {

            InitializeComponent();
           Variaveis.servidor = "Server=localhost;Database=bdcad;Uid=root;Pwd=";
           Variaveis.conexao = new MySqlConnection(Variaveis.servidor);
           Variaveis.comando = Variaveis.conexao.CreateCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Variaveis.conexao.Open();
                Variaveis.comando.CommandText = "SELECT usuario, senha FROM bd_cad WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultado = Variaveis.comando.ExecuteReader();


                if (resultado.Read())
                {
                    this.Hide();
                    Form cad = new telacadastro();
                   cad.Closed += (s, args) => this.Close();
                    cad.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!\n\nVocê utilizou " + acesso + " \n\n restam apenas 3 tentativas");
                    acesso++;
                }

                if (acesso > 3)
                {
                    MessageBox.Show("Acesso não permitido !");
                    this.Close();
                }


            }
            catch (Exception erro_mysql)
            {
                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");

            }
            finally
            {
                Variaveis.conexao.Close();
            }






        }
    }
}
