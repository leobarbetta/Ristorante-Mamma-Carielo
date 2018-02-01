using Ristorante.Mamma.Carielo.Domain;
using Ristorante.Mamma.Carielo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristorante.Mamma.Carielo.WinForms
{
    public partial class FormMercado : Form
    {
        private MercadoRepository _mercadoRepository = new MercadoRepository();
        public FormMercado()
        {
            InitializeComponent();
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome mercado é obrigatório");
                return;
            }

            Mercado mercado = new Mercado
            {
                Nome = txtNome.Text
            };

            await _mercadoRepository.Insert(mercado).ContinueWith((taskAnterior) =>
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

        private async void FormMercado_Load(object sender, EventArgs e)
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
            List<Mercado> mercados = await _mercadoRepository.Select();

            Invoke((MethodInvoker)delegate
            {
                lblTotalMercados.Text = $"Total de mercados: {mercados.Count}";

                grdMercados.Visible = true;
                grdMercados.DataSource = mercados.OrderBy(p => p.Nome).ToList();
                grdMercados.ReadOnly = true;
                grdMercados.Columns[0].Visible = false;
                grdMercados.Columns[2].HeaderText = "Data Cadastro";
                grdMercados.Refresh();
            });
        }
    }
}
