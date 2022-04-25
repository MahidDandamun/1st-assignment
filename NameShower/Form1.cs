namespace NameShower
{
    public partial class MyFirstProgram : Form
    {
        public MyFirstProgram()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name is " + txtFname.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}