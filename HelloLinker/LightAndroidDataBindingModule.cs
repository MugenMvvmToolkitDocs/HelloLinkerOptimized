using MugenMvvmToolkit;
using MugenMvvmToolkit.Android;
using MugenMvvmToolkit.Android.Binding.Infrastructure;
using MugenMvvmToolkit.Binding;
using MugenMvvmToolkit.Binding.Behaviors;
using MugenMvvmToolkit.Interfaces;
using MugenMvvmToolkit.Interfaces.Models;
using MugenMvvmToolkit.Models;
using AttachedMembersRegistration = MugenMvvmToolkit.Android.Binding.AttachedMembersRegistration;

namespace HelloLinker
{
    public class LightAndroidDataBindingModule : IModule
    {
        #region Properties

        public int Priority => ApplicationSettings.ModulePriorityInitialization + 1;

        #endregion

        #region Implementation of interfaces

        public bool Load(IModuleContext context)
        {
            if (context.PlatformInfo.Platform == PlatformType.Android)
            {
                BindingServiceProvider.Initialize(errorProvider: new AndroidBindingErrorProvider());
                BindingServiceProvider.BindingProvider.DefaultBehaviors.Add(DisableEqualityCheckingBehavior.TargetTrueNotTwoWay);
            }

            PlatformExtensions.ItemsSourceAdapterFactory = (o, ctx, arg3) => new ItemsSourceAdapter(o, ctx, true);

            AttachedMembersRegistration.RegisterObjectMembers();
            AttachedMembersRegistration.RegisterViewBaseMembers();
            AttachedMembersRegistration.RegisterViewMembers();
            AttachedMembersRegistration.RegisterTextViewMembers();
            AttachedMembersRegistration.RegisterViewGroupMembers();

            return true;
        }

        public void Unload(IModuleContext context)
        {
        }

        #endregion
    }
}