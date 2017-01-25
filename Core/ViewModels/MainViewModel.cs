using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel:WorkspaceViewModel
    {
        #region Overrides of ViewModelBase

        protected override void OnInitialized()
        {
            DisplayName = "Hello, Linker!";
            base.OnInitialized();
        }

        #endregion
    }
}