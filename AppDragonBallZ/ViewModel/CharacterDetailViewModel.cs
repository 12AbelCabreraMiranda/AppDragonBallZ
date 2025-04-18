using AppDragonBallZ.Model;
using AppDragonBallZ.Model.DBZmodel;
using AppDragonBallZ.RepositoryPattern;
using AppDragonBallZ.RepositoryPattern.IRepositoryPattern;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDragonBallZ.ViewModel
{
    public class CharacterDetailViewModel: BaseViewModel
    {

        #region VARIABLES
        private readonly ICharactersRepository charactersRepository = new CharactersRepository();
        Character _character = new();

       
        #endregion

        #region OBJETOS
        public Character Character
        {
            get { return _character; }
            set { SetValue(ref _character, value); }
        }
        #endregion

        #region CONSTRUCTOR
        public CharacterDetailViewModel(INavigation navigation, long characterId)
        {
            Navigation = navigation;
            ObtenerUnPersonaje(characterId);
        }
        #endregion

        #region PROCESOS
        public async void ObtenerUnPersonaje(long characterId)
        {
            try
            {
                Respuesta respuesta = await charactersRepository.GetCharacterById(characterId);
                if (respuesta.Resultado != true)
                {
                    await DisplayAlert("Error", respuesta.Mensaje, "Ok");
                }

                Character = (Character)respuesta.Data;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: ObtenerUnPersonaje -> ", ex.Message.ToString(), "Ok");
            }
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS        
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
