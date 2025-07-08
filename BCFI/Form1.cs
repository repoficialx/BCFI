namespace BCFI
{
    #pragma warning disable
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            new Datos(await dosu.Food.GetFoodInfo(textBox1.Text));
        }
    }
}
