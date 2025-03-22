namespace appForAccGoods;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void OnAddGoodTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AddGoodPage");
    }
}