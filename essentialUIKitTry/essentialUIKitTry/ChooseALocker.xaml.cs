using essentialUIKitTry.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseALocker : ContentPage
    {
        public ChooseALocker()
        {
            InitializeComponent();

        }
        void Locker1_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Locker1OrderedSuccess());
            
        }
        void Locker2_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Locker2OrderFailed());
        }
        void Locker3_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Locker3OrderSuccess());
        }
    }
}