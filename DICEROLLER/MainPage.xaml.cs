namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculaTip(object sender, EventArgs e)
        {

            Random rnd = new Random();

            Console.WriteLine("Generating 6 random numbers:");

            for (uint ctr = 1; ctr <= 6; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");


        }
        
        private void BottonPickerCalcule(object sender, EventArgs e)
        {
            int clck = CalculaTip();
            double amount = double.Parse(Dado.Text);
        }

    }

}
