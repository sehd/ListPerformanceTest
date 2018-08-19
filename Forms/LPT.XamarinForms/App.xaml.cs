using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ListPerformanceTest.XamarinForms
{
	public partial class App : Application
	{
        public static NavigationPage NavigationPage { get; private set; }

		public App ()
		{
			InitializeComponent();
            NavigationPage = new NavigationPage(new MainPage());
			MainPage = NavigationPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
