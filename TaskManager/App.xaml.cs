namespace TaskManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            Window window = base.CreateWindow(activationState);
            window.MinimumHeight = 480;
            window.MinimumWidth = 600;

            return window;
        }
    }
}
