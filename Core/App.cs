using System;
using System.Collections.Generic;
using System.Reflection;
using Core.ViewModels;
using MugenMvvmToolkit;
using MugenMvvmToolkit.Interfaces.Models;

namespace Core
{
    public class App : MvvmApplication
    {
        private readonly Action<IModuleContext> _loadModulesDelegate;

        public App(Action<IModuleContext> loadModulesDelegate = null)
        {
            _loadModulesDelegate = loadModulesDelegate;
        }

        protected override void LoadModules(IList<Assembly> assemblies)
        {
            if (_loadModulesDelegate == null)
                base.LoadModules(assemblies);
            else
                _loadModulesDelegate(CreateModuleContext(assemblies));
        }

        #region Overrides of MvvmApplication

        public override Type GetStartViewModelType()
        {
            return typeof(MainViewModel);
        }

        #endregion
    }
}