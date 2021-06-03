using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to show chat profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LockerprofilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockerprofilePage" /> class.
        /// </summary>
        public LockerprofilePage()
        {
            this.InitializeComponent();

        }
        void Tap_try(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InsideALockerImage());
        }
    }
}