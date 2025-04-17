using AppDragonBallZ.ViewModel;

namespace AppDragonBallZ.View;

public partial class Characters : ContentPage
{
	public Characters()
	{
		InitializeComponent();
        BindingContext = new CharactersViewModel(Navigation);
    }
}