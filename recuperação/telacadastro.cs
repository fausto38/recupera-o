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
using static System.Net.Mime.MediaTypeNames;

namespace recuperação
{
    public partial class telacadastro : Form
    {
        string servidor;
        string op;
        string id;
        public telacadastro()
        {
            InitializeComponent();
            Variaveis.servidor = "Server=localhost;Database=bdcad;Uid=root;Pwd=";
            Variaveis.conexao = new MySqlConnection(Variaveis.servidor);
            Variaveis.comando = Variaveis.conexao.CreateCommand();

            lista();
            
        }
        private void lista()
        {
            try
            {
                Variaveis.conexao.Open();

                Variaveis.comando.CommandText = "SELECT * FROM bd_cad;";
                MySqlDataAdapter adaptadoruser = new MySqlDataAdapter(Variaveis.comando);
                DataTable tabelauser = new DataTable();
                adaptadoruser.Fill(tabelauser);
                dataGridViews1.DataSource = tabelauser;




            }
            catch (Exception erro_mysql)
            {

                //MessageBox.Show(erro_mysql.Message);
               // MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                Variaveis.conexao.Close();
            }
            
        }
       
            
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            
            labelUSUARIO.ForeColor = Color.Black;
            labelCADSENHA.ForeColor = Color.Black;
            labelCELULAR.ForeColor = Color.Black;

            if (radioButtonADM.Checked)
            {
                op = "ADM";
            }
            if (radioButtonCLIENTE.Checked)
            {
                op = "Cliente";
            }


            try
            {

                if (textBoxNOMEUSUARIO.Text != "" && textBoxCADSENHA.Text != "" && textBoxCELULAR.Text != "" && (radioButtonADM.Checked|| radioButtonCLIENTE.Checked))
                {
                    Variaveis.conexao.Open();
                    Variaveis.comando.CommandText = "INSERT INTO bd_cad(usuario, senha, nivel, celular) VALUES ('" + textBoxNOMEUSUARIO.Text + "', '" + textBoxCADSENHA.Text + "', '" + op + "', '" + textBoxCELULAR.Text + "');";
                    Variaveis.comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    lista();
                }
                else
                {
                    MessageBox.Show("algum campo está em BRANCO! Por favor preencha!", "ATENÇÃO!!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    if (textBoxNOMEUSUARIO.Text == "")
                    {
                        textBoxNOMEUSUARIO.Focus();
                        labelUSUARIO.ForeColor = Color.Red;

                    }
                    if (textBoxCADSENHA.Text == "")
                    {
                        textBoxCADSENHA.Focus();
                        labelCADSENHA.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxCELULAR.Focus();
                        labelCELULAR.ForeColor = Color.Red;
                    }
                }


            }
            catch (Exception erro_mysql)
            {

                MessageBox.Show("Erro de Sistema. Informe o suport");
                //MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                textBoxNOMEUSUARIO.Clear(); textBoxCADSENHA.Clear(); textBoxCELULAR.Clear();
            }
            lista();
        }

        private void buttonDELETAR_Click(object sender, EventArgs e)
        {
            
            try
            {

                Variaveis.conexao.Open();
                Variaveis.comando.CommandText = "DELETE FROM bd_cad WHERE id = " + id + ";";
                int resultado = Variaveis.comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Usuário(s) Removido(s) com Sucesso! - " + resultado + "Registros Removidos...");
                    lista();
                }
                else
                {
                    MessageBox.Show("User não localizado!");
                }

            }
            catch (Exception erro_mysql)
            {

               

            }
            finally
            {

                textBoxNOMEUSUARIO.Clear(); textBoxCADSENHA.Clear(); textBoxCELULAR.Clear();

            }
            lista();
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            
            if (radioButtonADM.Checked)
            {
                op = "ADM";
            }
            if (radioButtonCLIENTE.Checked)
            {
                op = "Cliente";
            }




            try
            {

                Variaveis.conexao.Open();
                Variaveis.comando.CommandText ="UPDATE bd_cad SET usuario = '" + textBoxNOMEUSUARIO.Text + "', senha = '" + textBoxCADSENHA.Text + "', nivel = '" + op + "', celular = '" + textBoxCELULAR.Text + "' WHERE  id = " + id + ";";
                int resultado = Variaveis.comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente(s) Atualizado(s) com Sucesso! - " + resultado + " Registro(s) Alterado(s)...");
                    lista();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                }

            }
            catch (Exception erro_mysql)
            {

               // MessageBox.Show(erro_mysql.Message);

            }
            finally
            {

                textBoxNOMEUSUARIO.Clear(); textBoxCADSENHA.Clear(); textBoxCELULAR.Clear(); 
            }
            lista();
        }

        private void buttonPROCURAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPESQUISA.Text == "")
                {
                    lista();
                }
                else
                {
                    Variaveis.conexao.Open();

                    Variaveis.comando.CommandText = "SELECT * FROM bd_cad WHERE usuario LIKE '%" + textBoxPESQUISA.Text + "%';";
                    MySqlDataAdapter adaptadorusers = new MySqlDataAdapter(Variaveis.comando);
                    DataTable tabelausers = new DataTable();
                    adaptadorusers.Fill(tabelausers);

                    dataGridViews1.DataSource = tabelausers;

                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                Variaveis.conexao.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        { 
            if (dataGridViews1.CurrentRow.Cells[3].Value.ToString() == "ADM")
            {
                radioButtonADM.Checked = true;
            }
            if (dataGridViews1.CurrentRow.Cells[3].Value.ToString() == "Cliente")
            {
                radioButtonCLIENTE.Checked = true;
            }

            id = dataGridViews1.CurrentRow.Cells[0].Value.ToString();

            textBoxNOMEUSUARIO.Text = dataGridViews1.CurrentRow.Cells[1].Value.ToString();
            textBoxCADSENHA.Text = dataGridViews1.CurrentRow.Cells[2].Value.ToString();
            textBoxCELULAR.Text = dataGridViews1.CurrentRow.Cells[4].Value.ToString();
            

        }
    }
}
