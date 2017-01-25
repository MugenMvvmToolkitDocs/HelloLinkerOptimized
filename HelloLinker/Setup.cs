using HelloLinker;
using MugenMvvmToolkit;
using MugenMvvmToolkit.Android.Attributes;
using MugenMvvmToolkit.Android.Infrastructure;
using MugenMvvmToolkit.Interfaces;

[assembly: Bootstrapper(typeof(Setup))]

namespace HelloLinker
{
    public class Setup : AndroidBootstrapperBase
    {
        #region Overrides of AndroidBootstrapperBase

        protected override IIocContainer CreateIocContainer()
        {
            return new AutofacContainer();
        }

        protected override IMvvmApplication CreateApplication()
        {
            return new Core.App(LoadModules);
        }

        #endregion

        private static void LoadModules(MugenMvvmToolkit.Interfaces.Models.IModuleContext context)
        {
            new LightAndroidDataBindingModule().Load(context);
            new MugenMvvmToolkit.Android.Modules.AndroidInitializationModule().Load(context);
        }
    }
}