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
        // �������� ������ ��������� �����-���
        var barcode = e.Results.FirstOrDefault();
        if (barcode != null)
        {
            // ������������� ������������, ����� �� ��������� ���������
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                cameraBarcodeReaderView.IsDetecting = false;

                // ������� �����-��� � ��������� ��������
                await DisplayAlert("�����-��� ������", barcode.Value, "OK");
                await Navigation.PopAsync();
            });
        }
    }
}