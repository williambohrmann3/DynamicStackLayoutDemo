using Android.Hardware.Lights;
using static Android.Icu.Text.ListFormatter;

namespace DynamicStackLayoutDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        this.BindingContext = new MapViewModel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}

