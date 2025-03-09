using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui.Platform;

namespace appForAccGoods;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Изменение цвета нижней панели
        Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#292929")); // Укажи нужный цвет
    }
}
