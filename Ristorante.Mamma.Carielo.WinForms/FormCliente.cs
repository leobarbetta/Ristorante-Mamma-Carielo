using Ristorante.Mamma.Carielo.Domain;
using Ristorante.Mamma.Carielo.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Ristorante.Mamma.Carielo.WinForms
{
    public partial class FormCliente : Form
    {
        private ClienteRepository _clienteRepository = new ClienteRepository();
        public FormCliente()
        {
            InitializeComponent();
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome cliente é obrigatório");
                return;
            }

            Cliente cliente = new Cliente
            {
                Nome = txtNome.Text
            };

            await _clienteRepository.Insert(cliente).ContinueWith((taskAnterior) =>
            {
                if (taskAnterior.Result)
                {
                    CarregaGrid();
                    txtNome.Invoke((MethodInvoker)delegate
                    {
                        txtNome.Text = "";
                    });
                }
                else
                    MessageBox.Show("Houve um erro");
            });
        }

        private async void FormCliente_Load(object sender, EventArgs e)
        {
            ActiveControl = txtNome;
            await Task.Run(() =>
            {
                CarregaGrid();
            }).ContinueWith((taskAnterior) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    lblLoading.Visible = false;
                });
            });
        }

        private async void CarregaGrid()
        {
            List<Cliente> clientes = await _clienteRepository.Select();

            Invoke((MethodInvoker)delegate
            {
                lblTotalClientes.Text = $"Total de clientes: {clientes.Count}";

                grdClientes.Visible = true;
                grdClientes.DataSource = clientes.OrderBy(p => p.Nome).ToList();
                grdClientes.ReadOnly = true;
                grdClientes.Columns[0].Visible = false;
                grdClientes.Columns[2].HeaderText = "Data Cadastro";
                grdClientes.Refresh();
            });
        }
    }
}
