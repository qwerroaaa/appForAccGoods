namespace appForAccGoods
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
        }
        private async void OnProductsButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ProductsPage");
        }

        private async void OnReportsButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ReportsPage");
        }

        private async void OnImportButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ImportPage");
        }
    }

}
