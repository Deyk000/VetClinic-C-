namespace VetClinicC_Project
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            listView1 = new ListView();
            ImageListPet = new ImageList(components);
            VetClinicLabel = new Label();
            AddNewPetButton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.LargeImageList = ImageListPet;
            listView1.Location = new Point(38, 136);
            listView1.Name = "listView1";
            listView1.Size = new Size(726, 246);
            listView1.SmallImageList = ImageListPet;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
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
            Controls.Add(listView1);
            Name = "IndexForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ImageList ImageListPet;
        private Label VetClinicLabel;
        private Button AddNewPetButton;
    }
}
