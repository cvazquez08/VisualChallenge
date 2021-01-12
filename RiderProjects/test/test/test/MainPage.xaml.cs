using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public List<Color> Podcasts { get; set; }
        public MainPage()
        {
            BindingContext = this;

            Podcasts = new List<Color>
            {
                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

                Color.FromHex("#8a8a8a"),
                Color.FromHex("#969696"),
                Color.FromHex("#a3a3a3"),
                Color.FromHex("#b0b0b0"),
                Color.FromHex("#bdbdbd"),

            };
            InitializeComponent();
        }
    }
}