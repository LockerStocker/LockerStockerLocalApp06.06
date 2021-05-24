using essentialUIKitTry.ViewModels;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to show the no item
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Locker2OrderFailed
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locker2OrderFailed" /> class.
        /// </summary>
        public Locker2OrderFailed()
        {
            this.InitializeComponent();
            this.BindingContext = Locker2OrderFailedViewModel.BindingContext;
        }
        void Back_To_Menu(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}