namespace LetterExclusionCount
{
    public partial class Form1 : Form
    {
        readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            inputText = string.Concat(inputText.ToLower().Distinct());

            string excludedLetters = string.Concat(Alphabet.Except(inputText));

            int numExcluded = excludedLetters.Length;

            if (numExcluded == 0) excludedLetters = "~ All letters have been used ~";

            label2.Text = $"{numExcluded} Unused Letters";

            label1.Text = excludedLetters;

            label1.Visible = true;
        }

        //Unused element methods
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}