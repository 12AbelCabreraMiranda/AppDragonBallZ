using AppDragonBallZ.View;

namespace AppDragonBallZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Characters();
            MainPage = new NavigationPage(new Characters());
        }
    }
}
