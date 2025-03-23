using appForAccGoods.Model;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appForAccGoods.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<ProductModel> Products { get; set; } = new();
        public ICommand SelectProductCommand { get; }

        public ProductsViewModel()
        {
            SelectProductCommand = new AsyncRelayCommand<ProductModel>(OnProductSelected);

            MessagingCenter.Subscribe<AddGoodPageViewModel, Product>(this, "AddProduct", (sender, product) =>
            {
                // Добавляем товар, конвертируя его в ProductModel
                Products.Add(new ProductModel
                {
                    Name = product.Name,
                    Barcode = product.Barcode,
                    Image = product.PhotoPath
                });
            });
        }

        private ProductModel _selectedProduct;
        public ProductModel SelectedProduct
        {
            get => _selectedProduct;
            set => SetProperty(ref _selectedProduct, value);
        }

        private async Task OnProductSelected(ProductModel selectedProduct)
        {
            if (selectedProduct == null)
                return;

            // Переход на AddGoodPage и передача данных через параметры
            var navigationParams = new Dictionary<string, object>
            {
                { "SelectedProduct", selectedProduct }
            };

            await Shell.Current.GoToAsync("AddGoodPage", navigationParams);
            SelectedProduct = null;
        }
    }

}
