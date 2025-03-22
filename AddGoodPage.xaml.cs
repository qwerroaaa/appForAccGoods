namespace appForAccGoods;

public partial class AddGoodPage : ContentPage
{
	public AddGoodPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void OnReturnTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ProductsPage");
    }
}