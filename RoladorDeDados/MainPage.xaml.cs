namespace RoladorDeDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollerClicked(object sender, EventArgs e)
        {
            int selectSides = Convert.ToInt32(SidesPicker.SelectedItem);

            Random random = new Random();
            int drawnNumber = random.Next(1, selectSides + 1);

            ResultadoRolagem.Text = drawnNumber.ToString();
        }
    }
}
