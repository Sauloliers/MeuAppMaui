namespace MeuAppMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Bloco de tratamento de exceções, para evitar que de erro e o app feche inesperadamente
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está compensando.";
                }
                else 
                { 
                    msg = "A Gasolina está compensando.";
                }

                // Exibe o resultado em uma caixa de diálogo
                DisplayAlert("Calculado", msg, "OK");
            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // Fecha método
    } // Fecha classe
} // Fecha namespace
