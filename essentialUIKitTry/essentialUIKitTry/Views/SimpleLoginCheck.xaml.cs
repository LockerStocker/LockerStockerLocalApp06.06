using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginCheck
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLoginCheck" /> class.
        /// </summary>
        public SimpleLoginCheck()
        {
            this.InitializeComponent();
        }
    }
}