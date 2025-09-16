namespace SingleResponsibility
{
    public partial class Form1 : Form
    {


        /*
         * SRP: Her sýnýfýn sadece bir sorumluluðu olmalý.
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            var productService = new ProductService();
            int affected = productService.CreateProduct(name, price);

            if (affected > 0)
            {
                MessageBox.Show("Kayýt baþarýlý");
            }
            else
            {
                MessageBox.Show("Hatalý kayýt");
            }


        }

     

        private void buttonBackColor_Click(object sender, EventArgs e)
        {

            changeColor();
        }

        private void changeColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }

        }
    }
}
