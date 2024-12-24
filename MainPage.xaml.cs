namespace Scanner
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
        {
            var result= e.Results?.FirstOrDefault()?.Value;
            if (result != null)
            {
                Console.WriteLine($"Detected barcode: {result}");
            }
        }
    }

}
