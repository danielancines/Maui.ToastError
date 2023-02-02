using CommunityToolkit.Maui.Alerts;

namespace Maui.ToastError;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			await Toast.Make("Toast Test").Show();
		}
		catch (Exception ex)
		{
			_= Shell.Current.DisplayAlert("Error", $"{ex.Message} - {ex.StackTrace}", "Ok");
		}
	}
}

