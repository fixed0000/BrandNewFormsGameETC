namespace BrandNewFormsGameETC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            Menu menuWindow = new Menu();

            menuWindow.Close();
            gameWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();

            settingsWindow.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menu menuWindow = new Menu();

            menuWindow.Close();
        }
    }  
}