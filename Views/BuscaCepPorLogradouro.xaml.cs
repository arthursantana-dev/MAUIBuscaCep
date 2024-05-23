using MAUIBuscaCep.Models;
using MAUIBuscaCep.Services;

namespace MAUIBuscaCep.Views;

public partial class BuscaCepPorLogradouro : ContentPage
{
    public BuscaCepPorLogradouro()
    {
        InitializeComponent();
    }

    public async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            carregando.IsRunning = true;

            List<Cep> arr_ceps =
                await DataService.GetCepsByLogradouro(
                    txt_logradouro.Text);

            lst_ceps.ItemsSource = arr_ceps;

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
        finally
        {
            carregando.IsRunning = false;
        }
    }
}