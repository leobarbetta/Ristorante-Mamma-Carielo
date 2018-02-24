using Ristorante.Mamma.Carielo.Domain;
using Ristorante.Mamma.Carielo.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristorante.Mamma.Carielo.WinForms
{
    public partial class FormInicial : Form
    {
        Thread thread;
        private DespesaRepository _despesaRepository = new DespesaRepository();
        private FaturamentoRepository _faturamentoRepository = new FaturamentoRepository();
        public FormInicial() => InitializeComponent();

        private void FaturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaturamento form = new FormFaturamento
            {
                FormInicial = this
            };
            thread = new Thread(() => { Application.Run(form); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void DespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDespesa form = new FormDespesa
            {
                FormInicial = this
            };
            thread = new Thread(() => { Application.Run(form); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            thread = new Thread(() => { Application.Run(form); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void MercadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMercado form = new FormMercado();
            thread = new Thread(() => { Application.Run(form); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private async void FormInicial_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                CarregaIndicadores();
            }).ContinueWith((taskAnterior) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    lblLoading.Visible = false;
                    panel.Visible = false;
                });
            });
        }

        public async void CarregaIndicadores()
        {
            List<Despesa> despesas = await _despesaRepository.Select();
            List<Faturamento> faturamentos = await _faturamentoRepository.Select(p => p.IsPago);

            int mesAtual = DateTime.Today.Month;

            decimal saidageral = despesas.Sum(p => p.Valor);
            decimal saidaMes = despesas.Where(p => p.Data.Month == mesAtual).Sum(p => p.Valor);

            decimal entradaGeral = faturamentos.Sum(p => p.Valor);
            decimal entradaMes = faturamentos.Where(p => p.Data.Month == mesAtual).Sum(p => p.Valor);

            decimal resultadoGeral = entradaGeral - saidageral;
            decimal resultadoMes = entradaMes - saidaMes;

            Invoke((MethodInvoker)delegate
            {
                lblFincancasMes.Text = $"Finanças {DateTime.Today.ToString("MMMMM")}";

                lblEntradaGeral.Text = $"Entrada: R${entradaGeral}";
                lblEntradaMes.Text = $"Entrada: R${entradaMes}";

                lblSaidageral.Text = $"Sáida: R${saidageral}";
                lblSaidaMes.Text = $"Sáida: R${saidaMes}";

                lblResultadoGeral.BackColor = resultadoGeral < 0 ? Color.Red : Color.Green;
                lblResultadoGeral.Text = $"Resultado: R${resultadoGeral}";

                lblResultadoMes.BackColor = resultadoMes < 0 ? Color.Red : Color.Green;
                lblResultadoMes.Text = $"Resultado: R${resultadoMes}";
            });
        }
    }
}
