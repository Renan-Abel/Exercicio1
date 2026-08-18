namespace Exercicio1
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcular_Clicked(object sender, EventArgs e)
        {
            float pontoAx = float.Parse(txPontoAx.Text);
            float pontoAy = float.Parse(txPontoAy.Text);
            float pontoBx = float.Parse(txPontoBx.Text);
            float pontoBy = float.Parse(txPontoBy.Text);

            float distancia = (float)Math.Sqrt(Math.Pow(pontoBx - pontoAx, 2) + Math.Pow(pontoBy - pontoAy, 2));

            txNovoValor.Text = String.Format("{0:f2}", distancia);
        }
    }
}

