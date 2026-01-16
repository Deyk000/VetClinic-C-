using static VetClinicC_Project.IAnimal;

namespace VetClinicC_Project
{
    public partial class IndexForm : Form
    {
        private readonly List<IAnimal> pets = new()
        {
            new Cat("Whiskers", new DateTime(2020, 5, 1), "Siamese", "No known issues", 8.5, "Cream", "Yarn Ball"),

            new Dog("Buddy", new DateTime(2019, 8, 15), "Labrador", "Vaccinated",25.5, "Golden","Rubber Bone")
        };

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        public IndexForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
