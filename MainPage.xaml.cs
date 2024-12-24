namespace Scanner
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddImageTapped(object sender, EventArgs e)
        {
            DisplayAlert("Tapped!", "You tapped the Add Pic.", "OK");
        }
        private void CameraFrameTapped(object sender, EventArgs e) 
        {
            DisplayAlert("Tapped!", "You tapped the Camera frame.", "OK");
        }

        private void GallareyFrameTapped(Object sender, EventArgs e)
        {
            DisplayAlert("Tapped!", "You tapped the Gallarey frame.", "OK");
        }
        private void Enter_BarcodeFrameTapped(Object sender, EventArgs e)
        {
            DisplayAlert("Tapped!", "You tapped the Enter_Barcode frame.", "OK");
        }

    }

}
