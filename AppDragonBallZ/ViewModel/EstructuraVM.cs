﻿using AppDragonBallZ.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppDragonBallZ.ViewModel
{
    public class EstructuraVM : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region CONSTRUCTOR
        public EstructuraVM(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
       
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
