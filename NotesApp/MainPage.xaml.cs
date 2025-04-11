using System.Reflection.Metadata;


namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OiButton_Clicked(object sender, EventArgs e)
        {
            // Pegar o nome que a pessoa digitou
            // Document.getElementById("id_da_caixa_de_texto").Value;
            // Armazenar o nome em uma variavel
            // Exibir o nome que esta na variavel em uma caixa de texto

            string nome = NomeEntry.Text;
            //NomeLabel.Text = "Oi, " + nome;
            NomeLabel.Text = $"Oi, {nome}";
        }
    }

}
