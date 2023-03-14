namespace Calcula_Salario_2
{
    public partial class Calculadordesalario : Form
    {
        public Calculadordesalario()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            func.CPF = mtxtCpf.Text;
            func.Nome = txtNome.Text;
            func.DiasTraB =int.Parse(txtDiasTrab.Text);
            func.ValorDiaria = double.Parse(txtValorDiaria.Text);

            func.SalarioBase();
            func.ValorIr();
            func.SalarioLiquido();

            lblSalarioBase.Visible = true;
            lblValorIR.Visible= true;
            lblSalarioLiquido.Visible= true;
            txtSalaBase.Visible = true;
            txtValorIR.Visible= true;
            txtSalarioLiquido.Visible= true;

            txtSalaBase.Text = func.Sbase.ToString("n2");
            txtValorIR.Text = func.Ir.ToString("n2");
            txtSalarioLiquido.Text = func.Sliquido.ToString("n2");

        }
    }
}