namespace MauiFlix;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}

    private void btnmissao_Clicked(object sender, EventArgs e)
    {

    }

    private void btnjonh_Clicked(object sender, EventArgs e)
    {

    }

    private void btnmad_Clicked(object sender, EventArgs e)
    {

    }

    private void btntop_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new topgun());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}