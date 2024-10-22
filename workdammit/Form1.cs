namespace workdammit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            WorkLB.Text = "Privyet Egert";
            oppa.Text = "Guten Tag, Emma";
        }
    }
}