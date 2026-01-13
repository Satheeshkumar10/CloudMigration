namespace SfButtonSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzIyZTMwMmUzMFQzbzgyTlpiMGZDOTB6ZkxKdXZnTVdxVWt0Q0dRVWlXV0FqZUhGa2o4QzQ9");
        MainPage = new NavigationPage(new MainPage());
    }
    public static double ScreenWidth { get; internal set; }
    public static double ScreenHeight { get; internal set; }
    public static float Density { get; internal set; }
}
