using appForAccGoods.ViewModel;

namespace appForAccGoods.View;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();
        BindingContext = new ProductsViewModel();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void OnAddGoodTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AddGoodPage");
    }
}