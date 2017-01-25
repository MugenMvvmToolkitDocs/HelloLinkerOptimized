using Android.App;
using MugenMvvmToolkit.Android.Views.Activities;

namespace HelloLinker.Views
{
    [Activity(Label = "MainView")]
    public class MainView : MvvmActivity
    {
        #region Constructors

        public MainView()
            : base(Resource.Layout.Main)
        {
        }

        #endregion
    }
}