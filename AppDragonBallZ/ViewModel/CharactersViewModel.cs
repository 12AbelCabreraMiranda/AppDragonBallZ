using App_DragonBallZ.RepositoryPattern;
using AppDragonBallZ.Generico;
using AppDragonBallZ.Model;
using AppDragonBallZ.Model.DBZmodel;
using AppDragonBallZ.RepositoryPattern.IRepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDragonBallZ.ViewModel
{
    public class CharactersViewModel : BaseViewModel
    {
        #region VARIABLES
        private readonly ICharactersRepository charactersRepository = new CharactersRepository();

        Pagination _pagination = new();
        public bool IsRefreshing { get; set; }

        int _page =1;
        int _limit=10;
        bool _btnAnterior;
        bool _btnSiguiente;

        #endregion

        #region OBJETOS
        public Pagination Pagination
        {
            get { return _pagination; }
            set { SetValue(ref _pagination, value); }
        }
        public bool BtnAnterior
        {
            get { return _btnAnterior; }
            set { SetValue(ref _btnAnterior, value); }
        }
        public bool BtnSiguiente
        {
            get { return _btnSiguiente; }
            set { SetValue(ref _btnSiguiente, value); }
        }
        public int Page
        {
            get { return _page; }
            set { SetValue(ref _page, value); }
        }

        public int Limit
        {
            get { return _limit; }
            set { SetValue(ref _limit, value); }
        }
        #endregion

        #region CONSTRUCTOR
        public CharactersViewModel(INavigation navigation)
        {
            Navigation = navigation;
            BtnSiguiente = true;
            ObtenerPersonajes();
        }
        #endregion
      
        #region PROCESOS
        public async void ObtenerPersonajes()
        {
            try
            {               
                Respuesta respuesta = await charactersRepository.Characters($"{Utilidades.UrlApiDBZ}?page={Page}&limit={Limit}");
                
                if (respuesta.Resultado!=true)
                {
                    await DisplayAlert("Error", respuesta.Mensaje, "Ok");
                }

                Pagination = (Pagination)respuesta.Data;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: ObtenerPersonajes -> ", ex.Message.ToString(), "Ok");
            }
        }
       
        public async void SiguientePagina(Pagination pagination)
        {
            try
            {              
                Respuesta respuesta = await charactersRepository.Characters(pagination.Links.Next.ToString());

                if (respuesta.Resultado != true)
                {
                    await DisplayAlert("Error", respuesta.Mensaje, "Ok");
                }

                Pagination = (Pagination)respuesta.Data;
                  ValidarEstadoBoton("Siguiente");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: SiguientePagina -> ", ex.Message.ToString(), "Ok");
            }
        }

        public async void AnteriorPagina(Pagination pagination)
        {
            try
            {
               
                Respuesta respuesta = await charactersRepository.Characters(pagination.Links.Previous.ToString());

                if (respuesta.Resultado != true)
                {
                    await DisplayAlert("Error", respuesta.Mensaje, "Ok");
                }

                Pagination = (Pagination)respuesta.Data;
                ValidarEstadoBoton("Anterior");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: AnteriorPagina -> ", ex.Message.ToString(), "Ok");
            }
        }

        public async void ValidarEstadoBoton(string boton)
        {
            try
            {
                if (boton.Equals("Siguiente"))
                {
                    BtnSiguiente = Pagination.Links.Next == null ? false : true;
                    BtnAnterior = Pagination.Links.Previous == null ? false : true;
                }
                else if (boton.Equals("Anterior"))
                {
                    BtnAnterior = Pagination.Links.Previous == null ? false : true;
                    BtnSiguiente = Pagination.Links.Next == null ? false : true;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error en método: ValidarEstadoBoton -> ", ex.Message.ToString(), "Ok");
            }
           
        }
        #endregion

        #region COMANDOS        
        public ICommand SiguientePaginaCommand => new Command<Pagination>(SiguientePagina);
        public ICommand AnteriorPaginaCommand => new Command<Pagination>(AnteriorPagina);
        #endregion
    }
}
