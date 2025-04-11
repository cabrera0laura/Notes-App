namespace NotesApp;

public partial class NotePage : ContentPage
{
    string caminho = FileSystem.AppDataDirectory;
    string arquivo = "arquivo.txt";

    //NULL

    public NotePage()
	{
		InitializeComponent();
        if (File.Exists(Path.Combine(caminho, arquivo)))
        {
            TextoEditor.Text = File.ReadAllText(Path.Combine(caminho, arquivo));
            
        }
    }

    private void SalvarButton_Clicked(object sender, EventArgs e)
    {
        string conteudo = TextoEditor.Text;
        File.WriteAllText(Path.Combine(caminho, arquivo), conteudo);
        DisplayAlert("Ok", "Salvo com Sucesso", "Valeu!");
    }

    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        File.Delete(Path.Combine(caminho, arquivo));
        if (File.Exists(Path.Combine(caminho, arquivo)))
            File.Delete(Path.Combine(caminho, arquivo));
        TextoEditor.Text = string.Empty;
        DisplayAlert("Alerta!",$"Arquivo: {arquivo}. \nDeletado com sucesso!", "OK");
    }
}