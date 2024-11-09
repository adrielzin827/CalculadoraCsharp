namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public bool operacaoEmAndamento { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao
        }
        public Form1()
        {
            InitializeComponent();
            operacaoEmAndamento = false;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
        }

        private void btnTrês_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
        }
        private void btnNove_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            Visor.Text += "0";
        }
        private void btnVírgula_Click(object sender, EventArgs e)
        {
            if (!Visor.Text.Contains(","))
            {
                 Visor.Text += ",";
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Visor.Text.Length > 0){
                Visor.Text = Visor.Text.Remove(Visor.Text.Length - 1);
            }
        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                btnIgual_Click(sender, e);
            }
            OperacaoSelecionada = Operacao.adicao;
            Valor = Convert.ToDecimal(Visor.Text);
            Visor.Text = "";
            lblOperacao.Text = "+";
            operacaoEmAndamento = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                btnIgual_Click(sender, e);
            }
            OperacaoSelecionada = Operacao.subtracao;
            Valor = Convert.ToDecimal(Visor.Text);
            Visor.Text = "";
            lblOperacao.Text = "-";
            operacaoEmAndamento = true;
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                btnIgual_Click(sender, e);
            }
            OperacaoSelecionada = Operacao.divisao;
            Valor = Convert.ToDecimal(Visor.Text);
            Visor.Text = "";
            lblOperacao.Text = "/";
            operacaoEmAndamento = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                btnIgual_Click(sender, e);
            }
            OperacaoSelecionada = Operacao.multiplicacao;
            Valor = Convert.ToDecimal(Visor.Text);
            Visor.Text = "";
            lblOperacao.Text = "X";
            operacaoEmAndamento = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal resultadoParcial = Convert.ToDecimal(Visor.Text);
            switch (OperacaoSelecionada)
            {
                case Operacao.adicao:
                    Resultado = Valor + resultadoParcial;
                    break;
                case Operacao.subtracao:
                    Resultado = Valor - resultadoParcial;
                    break;
                case Operacao.divisao:
                    if (resultadoParcial != 0)
                    {
                        Resultado = Valor / resultadoParcial;
                    }
                    else
                        MessageBox.Show("Erro: Divisão por 0");
                    
                    break;
                case Operacao.multiplicacao:
                    Resultado = Valor * resultadoParcial;
                    break;
            }
            Visor.Text = Resultado.ToString();
            operacaoEmAndamento = false;
            lblOperacao.Text = "";
        }

        
    }
}
