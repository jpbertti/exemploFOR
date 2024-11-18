namespace exemploFOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lsbNumeros.Items.Add(i);
            }
        }

        private void btnDecremento_Click(object sender, EventArgs e)
        {
            // i = i-1
            lsbNumeros2.Items.Clear();
            for (int i = 10; i >= 1; i--)
            {
                lsbNumeros2.Items.Add(i);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lsbMedia.Items.Clear();
            Random random = new Random();
            int numAleatorio = 0;
            double media = 0, temp = 0;
            for (int i = 0; i < 10; i++)
            {
                numAleatorio = random.Next(1, 100);
                lsbMedia.Items.Add(numAleatorio);
                temp = temp + numAleatorio;
            }

            media = temp / 10;
            lsbMedia.Items.Add("-------------");
            lsbMedia.Items.Add("Média: " + media);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Clear();
            lsbNumeros2.Items.Clear();
            lsbMedia.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
