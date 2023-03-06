namespace ClientApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void name_textBox_Enter(object sender, EventArgs e)
        {
            if (name_textBox.Text.ToString().Equals("Enter your Name"))
            {
                name_textBox.Text = "";
                name_textBox.ForeColor = Color.Black;
            }
        }

        private void name_textBox_Leave(object sender, EventArgs e)
        {
            if (name_textBox.Text.ToString().Equals(""))
            {
                name_textBox.Text = "Enter your Name";
                name_textBox.ForeColor = Color.Silver;
            }
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            string name = name_textBox.Text.ToString();
            ServiceReference1.RecordsServiceClient client = new ServiceReference1.RecordsServiceClient();
            bool x = client.checkName(name);
            if (x == true)
            {
                status_label.Text = "    Found   ";
                status_label.ForeColor = Color.Green;

                age_label.Text = "   "+Convert.ToString(client.getAge())+"   ";
            }
            else
            {
                status_label.Text = "Not Found";
                status_label.ForeColor = Color.Red;

                age_label.Text = "---------";
            }
        }

    }
}