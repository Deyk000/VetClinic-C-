csharp VetClinicC#Project\NewPet.cs
using System;
using System.Windows.Forms;

namespace VetClinicC_Project
{
    public partial class NewPet : Form
    {
        // Expose created animal to the caller
        public IAnimal NewAnimal { get; private set; }

        public NewPet()
        {
            InitializeComponent();
            AddPetButton.Click += AddPetButton_Click;
        }

        private void AddPetButton_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(BreedTextBox.Text))
            {
                MessageBox.Show("Please enter a breed.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(WeightTextBox.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid numeric weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = NameTextBox.Text.Trim();
            var birthday = BirthdayDatePicker.Value;
            var breed = BreedTextBox.Text.Trim();
            var medHistory = MedHistoryTextBox.Text.Trim();
            var color = ColorTextBox.Text.Trim();
            var image = ImageTextBox.Text.Trim();
            var favToy = FavToyTextBox.Text.Trim();

            if (radioButtonCat.Checked)
            {
                NewAnimal = new Cat(name, birthday, breed, medHistory, weight, color, favToy)
                {
                    Image = image,
                    Status = Status.NotAdopted
                };
            }
            else
            {
                NewAnimal = new Dog(name, birthday, breed, medHistory, weight, color, favToy)
                {
                    Image = image,
                    Status = Status.NotAdopted
                };
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void NewPet_Load(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}