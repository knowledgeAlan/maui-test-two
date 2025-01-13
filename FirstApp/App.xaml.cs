namespace FirstApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{

		// var navPage = new Window(new AppShell());
		//  var navPage = new Window(new FlyoutContentPageDemo());
		var navPage = new Window(new TabbedPageDemo());
		return navPage;
		// return new Window(new AppShell());
		// return new Window(new ContentPageDemo());
	}
}