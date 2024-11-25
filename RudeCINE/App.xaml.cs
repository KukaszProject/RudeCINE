using RudeCINE.MVVM.Views;

namespace RudeCINE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RepertuarPage();
        }
    }
}
