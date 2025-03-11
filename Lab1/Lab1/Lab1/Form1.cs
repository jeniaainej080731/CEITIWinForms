namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PotatoLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/potato.jpg");
        }

        private void CarrotLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/carrot.jpg");
        }

        private void PeaLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/pea.jpg");
        }

        private void CucumberLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/cucumber.jpg");
        }

        private void PeperLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/peper.jpg");
        }

        private void TomateLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/tomato.jpg");
        }

        private void CabbageLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/cabbage.jpg");
        }

        private void BroccoliLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/broccoli.jpg");
        }

        private void GarlicLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/garlic.jpg");
        }

        private void PumpkinLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/pumpkin.jpg");
        }

        private void ZucchiniLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/zucchini.jpg");
        }

        private void RadishLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/radish.jpg");
        }

        private void BeetsLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/beets.jpg");
        }

        private void OnionLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/onion.jpg");
        }

        private void EggplantLabel_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Images/eggplant.jpg");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
