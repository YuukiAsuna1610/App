namespace BookApp
{
    public partial class MainPage : ContentPage
    {     
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBuchClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Seiten.BuchPage());

        }

        
        private void OnProfilClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Seiten.Profil());

        }
        //<Editor x:Name="editor"
        //Placeholder="Enter your response here"
        //HeightRequest="250"
        //TextChanged="OnEditorTextChanged"
        //Completed="OnEditorCompleted" />
    }
}
