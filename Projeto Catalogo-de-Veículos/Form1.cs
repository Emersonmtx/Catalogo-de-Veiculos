using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Catalogo_de_Veículos
{
    public partial class Form1 : Form
    {
        string connectionString = "workstation id=Emersonmtx.mssql.somee.com;packet size=4096;user id=Emersonmtx_SQLLogin_1;pwd=llz9yfs5di;data source=Emersonmtx.mssql.somee.com;persist security info=False;initial catalog=Emersonmtx;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM tblveiculo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "tblveiculo");
                    dtVeiculos.DataSource = dataSet.Tables["tblveiculo"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ano = txtAno.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string tipo = cbTipo.Text;

            if (string.IsNullOrEmpty(ano) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string queryVeiculo = "INSERT INTO tblveiculo (anoVeiculo, modeloVeiculo) VALUES (@anoVeiculo, @modeloVeiculo)";
            string queryMarca = "INSERT INTO tblmarca (Marca) VALUES (@Marca)";
            string queryTipo = "INSERT INTO tblTipoVeiculo (tipo) VALUES (@tipo)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand commandVeiculo = new SqlCommand(queryVeiculo, connection))
                    {
                        commandVeiculo.Parameters.AddWithValue("@anoVeiculo", ano);
                        commandVeiculo.Parameters.AddWithValue("@modeloVeiculo", modelo);
                        commandVeiculo.ExecuteNonQuery();
                    }

                    using (SqlCommand commandMarca = new SqlCommand(queryMarca, connection))
                    {
                        commandMarca.Parameters.AddWithValue("@Marca", marca);
                        commandMarca.ExecuteNonQuery();
                    }

                    using (SqlCommand commandTipo = new SqlCommand(queryTipo, connection))
                    {
                        commandTipo.Parameters.AddWithValue("@tipo", tipo);
                        commandTipo.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados inseridos com sucesso!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int codVeiculo))
            {
                LoadDataForEdit(codVeiculo);
            }
        }

        private void LoadDataForEdit(int codVeiculo)
        {
            string query = "SELECT anoVeiculo, modeloVeiculo, Marca, tipo FROM tblveiculo WHERE codVeiculo = @codVeiculo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codVeiculo", codVeiculo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtAno.Text = reader["anoVeiculo"].ToString();
                                txtModelo.Text = reader["modeloVeiculo"].ToString();
                                txtMarca.Text = reader["Marca"].ToString();
                                cbTipo.Text = reader["tipo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados para edição: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int codVeiculo))
            {
                MessageBox.Show("Por favor, insira um código de veículo válido.");
                return;
            }

            string ano = txtAno.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string tipo = cbTipo.Text;

            if (string.IsNullOrEmpty(ano) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string query = "UPDATE tblveiculo SET anoVeiculo = @anoVeiculo, modeloVeiculo = @modeloVeiculo, Marca = @Marca, tipo = @tipo WHERE codVeiculo = @codVeiculo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codVeiculo", codVeiculo);
                        command.Parameters.AddWithValue("@anoVeiculo", ano);
                        command.Parameters.AddWithValue("@modeloVeiculo", modelo);
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados atualizados com sucesso!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int codVeiculo))
            {
                MessageBox.Show("Por favor, insira um código de veículo válido.");
                return;
            }

            string query = "DELETE FROM tblveiculo WHERE codVeiculo = @codVeiculo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codVeiculo", codVeiculo);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro excluído com sucesso!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }
}
