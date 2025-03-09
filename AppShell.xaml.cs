namespace appForAccGoods
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ProductsPage", typeof(ProductsPage));
        }
    }
}
