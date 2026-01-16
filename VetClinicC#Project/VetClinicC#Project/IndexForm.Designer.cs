using static VetClinicC_Project.IAnimal;

namespace VetClinicC_Project
{
    partial class IndexForm
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();

            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            listViewIndexForm = new ListView();
            ImageListPet = new ImageList(components);
            VetClinicLabel = new Label();
            AddNewPetButton = new Button();
            SuspendLayout();
            // 
            // listViewIndexForm
            // 
            listViewIndexForm.LargeImageList = ImageListPet;
            listViewIndexForm.Location = new Point(38, 136);
            listViewIndexForm.Name = "listViewIndexForm";
            listViewIndexForm.Size = new Size(726, 246);
            listViewIndexForm.SmallImageList = ImageListPet;
            listViewIndexForm.TabIndex = 0;
            listViewIndexForm.UseCompatibleStateImageBehavior = false;
            // 
            // ImageListPet
            // 
            ImageListPet.ColorDepth = ColorDepth.Depth16Bit;
            ImageListPet.ImageStream = (ImageListStreamer)resources.GetObject("ImageListPet.ImageStream");
            ImageListPet.TransparentColor = Color.Transparent;
            ImageListPet.Images.SetKeyName(0, "icons8-cat-48.png");
            ImageListPet.Images.SetKeyName(1, "icons8-dog-100.png");
            // 
            // VetClinicLabel
            // 
            VetClinicLabel.AutoSize = true;
            VetClinicLabel.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VetClinicLabel.ForeColor = Color.White;
            VetClinicLabel.Location = new Point(257, 9);
            VetClinicLabel.Name = "VetClinicLabel";
            VetClinicLabel.Size = new Size(295, 77);
            VetClinicLabel.TabIndex = 1;
            VetClinicLabel.Text = "Vet Clinic";
            VetClinicLabel.Click += label1_Click;
            // 
            // AddNewPetButton
            // 
            AddNewPetButton.BackColor = Color.DarkSlateBlue;
            AddNewPetButton.ForeColor = Color.White;
            AddNewPetButton.Location = new Point(609, 388);
            AddNewPetButton.Name = "AddNewPetButton";
            AddNewPetButton.Size = new Size(155, 29);
            AddNewPetButton.TabIndex = 2;
            AddNewPetButton.Text = "Add New Pet";
            AddNewPetButton.UseVisualStyleBackColor = false;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(AddNewPetButton);
            Controls.Add(VetClinicLabel);
            Controls.Add(listViewIndexForm);
            Name = "IndexForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        private ListView listViewIndexForm;
        private ImageList ImageListPet;
        private Label VetClinicLabel;
        private Button AddNewPetButton;


        private void LoadAllPets()
            {
                this.listViewIndexForm.Clear();
                foreach (var pet in pets)
                {
                this.listViewIndexForm.Items.Add(pet.Name, pet is Cat ? 0 : 1);
                }
        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs E)
        {
            IAnimal selectedPet = pets[listViewIndexForm.SelectedItems[0].Index];

           if(selectedPet != null)
            {
                using PetDetails detailsForm = new (selectedPet);
                detailsForm.ShowDialog();
            }
        }
        private void listViewIndexForm_MouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[listViewIndexForm.SelectedItems[0].Index];
            if (selectedPet != null)
            {
                using PetDetails petDetails = new (selectedPet);
                petDetails.ShowDialog();
            }
        }
        private void ButtonAddMewPetClick(object sender, EventArgs e)
        {
            using (NewPet newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }

        }
}

#endregion