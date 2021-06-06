using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to show chat profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Locker3ProfilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locker3ProfilePage" /> class.
        /// </summary>
        public Locker3ProfilePage()
        {
            this.InitializeComponent();
           
        }
        void Tap_try(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InsideALockerImage());
        }
    }
}