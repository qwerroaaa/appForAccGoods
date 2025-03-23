using appForAccGoods.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appForAccGoods.ViewModel
{
    [QueryProperty("SelectedProduct", "SelectedProduct")]
    public partial class AddGoodPageViewModel : ObservableObject
    {
        private ProductModel _selectedProduct;
        public ProductModel SelectedProduct
        {
            get => _selectedProduct;
            set => SetProperty(ref _selectedProduct, value);
        }
        // Свойства, к которым будут привязаны поля ввода
        [ObservableProperty]
        private string productName;

        [ObservableProperty]
        private string barcode;

        [ObservableProperty]
        private string quantity;

        [ObservableProperty]
        private string description;

        // Команда сохранения товара
        public ICommand SaveProductCommand { get; }

        public AddGoodPageViewModel()
        {
            SaveProductCommand = new RelayCommand(OnSaveProduct);
        }

        private async void OnSaveProduct()
        {
            // Создаем объект товара
            Product newProduct = new Product
            {
                Name = this.ProductName,
                Barcode = this.Barcode,
                Quantity = int.TryParse(this.Quantity, out int q) ? q : 0,
                Description = this.Description,
                PhotoPath = "product_image.png" //Заглушка, пока не хочу делать обработку картинок
            };

            // Отправляем товар в ProductPage
            MessagingCenter.Send(this, "AddProduct", newProduct);

            // Для примера выводим сообщение
            await Shell.Current.DisplayAlert("Товар создан",
                $"Создан товар: {newProduct.Name}", "OK");

            // Переходим назад на ProductPage
            await Shell.Current.GoToAsync("..");
        }
    }
}
