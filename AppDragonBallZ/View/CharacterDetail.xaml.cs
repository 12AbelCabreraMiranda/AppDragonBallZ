using AppDragonBallZ.Model.DBZmodel;
using AppDragonBallZ.ViewModel;

namespace AppDragonBallZ.View;

public partial class CharacterDetail : ContentPage
{
	public CharacterDetail(long characterId)
	{
		InitializeComponent();
        BindingContext = new CharacterDetailViewModel(Navigation, characterId);
    }
}