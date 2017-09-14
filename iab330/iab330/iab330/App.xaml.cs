using iab330.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace iab330 {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            SetMainPage();
        }

        public static void SetMainPage() {
            Current.MainPage = new SearchPage {

            };
        }
    }
}
