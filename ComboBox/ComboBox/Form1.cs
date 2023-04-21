namespace ComboBox
{
    public partial class Form1 : Form
    {
        string name, name2;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
            MessageBox.Show(name2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name=cbLanguages.Text.ToString();
            name2=cbLanguages.SelectedItem.ToString();

        }
    }
}