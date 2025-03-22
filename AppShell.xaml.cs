namespace appForAccGoods
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ProductsPage", typeof(ProductsPage));
            Routing.RegisterRoute("ReportsPage", typeof(ReportsPage));
            Routing.RegisterRoute("ImportPage", typeof(ImportPage));
            Routing.RegisterRoute("ExportPage", typeof(ExportPage));
            Routing.RegisterRoute("DocumentPage", typeof(DocumentPage));
            Routing.RegisterRoute("BarcodeScannerPage", typeof(BarcodeScannerPage));
            Routing.RegisterRoute("AddGoodPage", typeof(AddGoodPage));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
        }

        private void OnMenuTapped(object sender, EventArgs e)
        {
            this.FlyoutIsPresented = !this.FlyoutIsPresented;
        }
    }
}
