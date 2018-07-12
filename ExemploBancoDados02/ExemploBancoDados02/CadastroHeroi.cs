using ExemploBancoDados02.Modelo;
using ExemploBancoDados02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDados02
{
    public partial class CadastroHeroi : Form
    {
        private int codigo;

        public CadastroHeroi()
        {
            InitializeComponent();
        }

        public CadastroHeroi(int codigo)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(codigo);
            PrencherCampos(heroi);

        }

        private void PrencherCampos(Heroi heroi)
        {
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCodigo.Text = Convert.ToString(heroi.Id);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            txtQuantidadeFilmes.Text = Convert.ToString(heroi.QuantidadeFilmes);
            cbMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            rtbDescricao.Text = heroi.Descricao;
            if (heroi.Escuridao)
            {
                rbEscuridaoSim.Checked = true;
            }
            else
            {
                rbEscuridaoNao.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento = dtpDataNascimento.Value;
            heroi.Escuridao = rbEscuridaoSim.Checked;
            heroi.QuantidadeFilmes = Convert.ToByte(txtQuantidadeFilmes.Text);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = cbMulher.Checked ? 'm' : 'h';
            heroi.Descricao = rtbDescricao.Text;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int cadastrou = new HeroiRepositorio().Inserir(heroi);
                txtCodigo.Text = Convert.ToString(cadastrou);
                
                
                    MessageBox.Show("Registro cadastrado com sucesso.");
                
                
            }
            int id = Convert.ToInt32(txtCodigo.Text);
            heroi.Id = id;
            bool alterou = new HeroiRepositorio().Alterar(heroi);
            if (alterou)
            {
                MessageBox.Show("Registro alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível alterar");
            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int cod = Convert.ToInt32(txtCodigo.Text);
                    Heroi heroi = new HeroiRepositorio().ObterPeloCodigo(cod);

                    if (heroi != null)
                    {
                        PrencherCampos(heroi);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existe");
                        txtCodigo.Focus();
                        txtCodigo.SelectionStart = 0;
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;

                    }
                }
                catch (NotFiniteNumberException ex)
                {
                    MessageBox.Show("Informe um Código válido!");
                    txtCodigo.Focus();
                }
            }

        }

    }

    
    }


