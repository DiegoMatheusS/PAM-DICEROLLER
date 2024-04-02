namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;

        public MainPage()
        {

            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }
        
        private void RollBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar o  valor selecionado do picker 
            //Jogar esse valor em uma variável  \/
            valor = Convert.ToInt32(SidesPicker.SelectedItem);

            //Sortear um numero em um dado utilizando o Random
            //Colocar o valor sorteado em uma variavel
            
            int umvalor = 0;
            umvalor = new Random().Next(1, valor +1);

            //Exibir o Valor para o usuario em uma Label (ResultLabel)
            ResultLabel.Text = umvalor.ToString();
        }






        /* Com DisplayAlert
         * 
         * private async void RollBtn_Clicked(object sender, EventArgs e)
        {
            if (valor == 0)
            {
                await DisplayAlert("ALERTA", "Deverá Selecionar um número antes", "Voltar");
            }
            //Pegar o  valor selecionado do picker 
            //Jogar esse valor em uma variável  \/
            valor = Convert.ToInt32(SidesPicker.SelectedItem);

            //Sortear um numero em um dado utilizando o Random
            //Colocar o valor sorteado em uma variavel

            var umvalor = 0;
            umvalor = new Random().Next(1, valor + 1);

            //Exibir o Valor para o usuario em uma Label (ResultLabel)
            ResultLabel.Text = umvalor.ToString(); 
        }
        */


    }

}
