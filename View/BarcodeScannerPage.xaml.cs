using ZXing.Net.Maui;

namespace appForAccGoods.View;

public partial class BarcodeScannerPage : ContentPage
{
	public BarcodeScannerPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        // Получаем первый найденный штрих-код
        var barcode = e.Results.FirstOrDefault();
        if (barcode != null)
        {
            // Останавливаем сканирование, чтобы не повторять обработку
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                cameraBarcodeReaderView.IsDetecting = false;

                // Выводим штрих-код и закрываем страницу
                await DisplayAlert("Штрих-код найден", barcode.Value, "OK");
                await Navigation.PopAsync();
            });
        }
    }
}