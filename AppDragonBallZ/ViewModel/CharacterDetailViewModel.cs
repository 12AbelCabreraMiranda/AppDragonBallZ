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

        bool _estadoExisteTransformacion;

        #endregion

        #region OBJETOS
        public Character Character
        {
            get { return _character; }
            set { SetValue(ref _character, value); }
        }
        public bool EstadoExisteTransformacion
        {
            get { return _estadoExisteTransformacion; }
            set { SetValue(ref _estadoExisteTransformacion, value); }
        }
        #endregion

        #region CONSTRUCTOR
        public CharacterDetailViewModel(INavigation navigation, long characterId)
        {
            Navigation = navigation;
            ObtenerUnPersonaje(characterId);
            EstadoExisteTransformacion = false;
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
                if (Character == null)
                {
                    await DisplayAlert("Error", "No se encontró el personaje", "Ok");
                    return;
                }
                
                EstadoExisteTransformacion = Character.Transformations.Count > 0 ? false : true;
                
                

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: ObtenerUnPersonaje -> ", ex.Message.ToString(), "Ok");
            }
        }
        
        #endregion

        #region COMANDOS        
     
        #endregion
    }
}
