using Ristorante.Mamma.Carielo.Domain;
using Ristorante.Mamma.Carielo.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristorante.Mamma.Carielo.WinForms
{
    public partial class FormDespesa : Form
    {
        private MercadoRepository _mercadoRepository = new MercadoRepository();
        private DespesaRepository _despesaRepository = new DespesaRepository();
        public FormInicial @FormInicial { get; set; }
        public FormDespesa()
        {
            InitializeComponent();
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("O campo Valor gasto é obrigatório");
                return;
            }
            else if (cbxMercado.Text == "Selecione")
            {
                MessageBox.Show("O campo Mercado é obrigatório");
                return;
            }
            else if (cbxFormaPagamento.Text == "Selecione")
            {
                MessageBox.Show("O campo Forma de pagamento é obrigatório");
                return;
            }

            Enum.TryParse(cbxFormaPagamento.SelectedValue.ToString(), out FormaPagamentoEnum formaPagamento);
            int.TryParse(cbxMercado.SelectedValue.ToString(), out int mercadoId);

            Despesa despesa = new Despesa
            {
                Valor = Convert.ToDecimal(txtValor.Text),
                Data = dtpData.Value,
                FormaPagamento = formaPagamento,
                MercadoId = mercadoId,
                Observacao = txtObservacao.Text
            };

            await _despesaRepository.Insert(despesa).ContinueWith((taskAnterior) =>
            {
                if (taskAnterior.Result)
                {
                    CarregaGrid();

                    Invoke((MethodInvoker)delegate
                    {
                        txtValor.Text = "";
                        txtObservacao.Text = "";
                        dtpData.Value = DateTime.Today;
                        cbxFormaPagamento.Text = "Selecione";
                        cbxMercado.Text = "Selecione";
                    });
                    @FormInicial.CarregaIndicadores();
                }
                else
                    MessageBox.Show("Houve um erro");
            });
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
        }

        private async void FormDespesa_Load(object sender, EventArgs e)
        {
            ActiveControl = txtValor;

            await Task.Run(() =>
            {
                CarregaDropDownMercados();
            }).ContinueWith((taskAnterior) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    btnSalvar.Enabled = true;
                });
            });

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

            CarregaDropDownFormasPagamento();
        }

        private async void CarregaGrid()
        {
            List<Despesa> despesas = await _despesaRepository.SelectDynamicInclude(null, i => i.Mercado);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mercado", typeof(string));
            dataTable.Columns.Add("Valor", typeof(string));
            dataTable.Columns.Add("Data", typeof(string));
            dataTable.Columns.Add("Forma Pagamento", typeof(string));
            dataTable.Columns.Add("Observação", typeof(string));

            foreach (var item in despesas.OrderByDescending(p => p.Data))
                dataTable.Rows.Add(item.Mercado.Nome, item.Valor.ToString("c"), item.Data.ToShortDateString(), item.FormaPagamento.ToString(), item.Observacao);

            Invoke((MethodInvoker)delegate
            {
                lblValorTotal.Text = $"Total em {DateTime.Today.ToString("MMMM")}: R${despesas.Where(p => p.Data.Month == DateTime.Today.Month).Sum(p => p.Valor)}";

                grdDespesas.Visible = true;
                grdDespesas.DataSource = dataTable;
                grdDespesas.ReadOnly = true;
            });
        }

        private async void CarregaDropDownMercados()
        {
            List<Mercado> mercados = await _mercadoRepository.Select();

            Invoke((MethodInvoker)delegate
            {
                cbxMercado.DataSource = mercados.OrderBy(p => p.Nome).ToList();
                cbxMercado.DisplayMember = "Nome";
                cbxMercado.ValueMember = "MercadoId";
                cbxMercado.Text = "Selecione";
            });
        }

        private void CarregaDropDownFormasPagamento()
        {
            Invoke((MethodInvoker)delegate
            {
                cbxFormaPagamento.DataSource = Enum.GetValues(typeof(FormaPagamentoEnum));
                cbxFormaPagamento.Text = "Selecione";
            });
        }
    }
}
