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
    public partial class FormFaturamento : Form
    {
        private ClienteRepository _clienteRepository = new ClienteRepository();
        private FaturamentoRepository _faturamentoRepository = new FaturamentoRepository();
        public FormFaturamento()
        {
            InitializeComponent();
        }

        private async void BtnSalvar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("O campo Valor pago é obrigatório");
                return;
            }
            else if (cbxCliente.Text == "Selecione")
            {
                MessageBox.Show("O campo Cliente é obrigatório");
                return;
            }
            else if (cbxFormaPagamento.Text == "Selecione")
            {
                MessageBox.Show("O campo Forma de pagamento é obrigatório");
                return;
            }

            Enum.TryParse(cbxFormaPagamento.SelectedValue.ToString(), out FormaPagamentoEnum formaPagamento);
            int.TryParse(cbxCliente.SelectedValue.ToString(), out int clienteId);

            Faturamento faturamento = new Faturamento
            {
                Valor = Convert.ToDecimal(txtValor.Text),
                Data = Convert.ToDateTime(dtpData.Text),
                FormaPagamento = formaPagamento,
                ClienteId = clienteId,
                Observacao = txtObservacao.Text
            };

            await _faturamentoRepository.Insert(faturamento).ContinueWith((taskAnterior) =>
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
                        cbxCliente.Text = "Selecione";
                    });
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

        private async void FormFaturamento_Load(object sender, System.EventArgs e)
        {
            ActiveControl = txtValor;

            await Task.Run(() =>
            {
                CarregaDropDownClientes();
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
            List<Faturamento> faturamentos = await _faturamentoRepository.SelectDynamicInclude(null, i => i.Cliente);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cliente", typeof(string));
            dataTable.Columns.Add("Valor", typeof(string));
            dataTable.Columns.Add("Data", typeof(string));
            dataTable.Columns.Add("Forma Pagamento", typeof(string));
            dataTable.Columns.Add("Observação", typeof(string));

            foreach (var item in faturamentos.OrderByDescending(p => p.Data))
                dataTable.Rows.Add(item.Cliente.Nome, item.Valor.ToString("c"), item.Data.ToShortDateString(), item.FormaPagamento.ToString(), item.Observacao);

            Invoke((MethodInvoker)delegate
            {
                lblValorTotal.Text = $"Total em {DateTime.Today.ToString("MMMM")}: R${faturamentos.Where(p => p.Data.Month == DateTime.Today.Month).Sum(p => p.Valor)}";

                grdFaturamentos.DataSource = dataTable;
                grdFaturamentos.ReadOnly = true;
            });
        }

        private async void CarregaDropDownClientes()
        {
            List<Cliente> clientes = await _clienteRepository.Select();

            Invoke((MethodInvoker)delegate
            {
                cbxCliente.DataSource = clientes.OrderBy(p => p.Nome).ToList();
                cbxCliente.DisplayMember = "Nome";
                cbxCliente.ValueMember = "ClienteId";
                cbxCliente.Text = "Selecione";
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
