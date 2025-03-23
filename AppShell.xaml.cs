namespace appForAccGoods
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ProductsPage", typeof(View.ProductsPage));
            Routing.RegisterRoute("ReportsPage", typeof(View.ReportsPage));
            Routing.RegisterRoute("ImportPage", typeof(View.ImportPage));
            Routing.RegisterRoute("ExportPage", typeof(View.ExportPage));
            Routing.RegisterRoute("DocumentPage", typeof(View.DocumentPage));
            Routing.RegisterRoute("BarcodeScannerPage", typeof(View.BarcodeScannerPage));
            Routing.RegisterRoute("AddGoodPage", typeof(View.AddGoodPage));
            Routing.RegisterRoute("MainPage", typeof(View.MainPage));
        }

        private void OnMenuTapped(object sender, EventArgs e)
        {
            this.FlyoutIsPresented = !this.FlyoutIsPresented;
        }
    }
}
