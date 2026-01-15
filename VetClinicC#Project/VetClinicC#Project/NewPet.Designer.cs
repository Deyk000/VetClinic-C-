namespace VetClinicC_Project
{
    partial class NewPet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTitle = new Label();
            radioButtonCat = new RadioButton();
            radioButtonDog = new RadioButton();
            NameTextBox = new TextBox();
            BreedTextBox = new TextBox();
            BirthdayDatePicker = new DateTimePicker();
            MedHistoryTextBox = new RichTextBox();
            NameLabel = new Label();
            BirthdayLabel = new Label();
            BreedLable = new Label();
            MedHisLable = new Label();
            WeightLabel = new Label();
            WeightTextBox = new TextBox();
            ColorLable = new Label();
            ColorTextBox = new TextBox();
            ImageLabel = new Label();
            ImageTextBox = new TextBox();
            FavToyLabel = new Label();
            FavToyTextBox = new TextBox();
            AddPetButton = new Button();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitle.ForeColor = Color.White;
            LabelTitle.Location = new Point(264, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(268, 77);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "New Pet";
            // 
            // radioButtonCat
            // 
            radioButtonCat.AutoSize = true;
            radioButtonCat.Location = new Point(131, 131);
            radioButtonCat.Name = "radioButtonCat";
            radioButtonCat.Size = new Size(52, 24);
            radioButtonCat.TabIndex = 1;
            radioButtonCat.TabStop = true;
            radioButtonCat.Text = "Cat";
            radioButtonCat.UseVisualStyleBackColor = true;
            radioButtonCat.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonDog
            // 
            radioButtonDog.AutoSize = true;
            radioButtonDog.Location = new Point(250, 131);
            radioButtonDog.Name = "radioButtonDog";
            radioButtonDog.Size = new Size(59, 24);
            radioButtonDog.TabIndex = 2;
            radioButtonDog.TabStop = true;
            radioButtonDog.Text = "Dog";
            radioButtonDog.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(131, 179);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(232, 27);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // BreedTextBox
            // 
            BreedTextBox.Location = new Point(131, 271);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(232, 27);
            BreedTextBox.TabIndex = 1;
            // 
            // BirthdayDatePicker
            // 
            BirthdayDatePicker.Location = new Point(131, 224);
            BirthdayDatePicker.Name = "BirthdayDatePicker";
            BirthdayDatePicker.Size = new Size(232, 27);
            BirthdayDatePicker.TabIndex = 1;
            // 
            // MedHistoryTextBox
            // 
            MedHistoryTextBox.Location = new Point(131, 319);
            MedHistoryTextBox.Name = "MedHistoryTextBox";
            MedHistoryTextBox.Size = new Size(232, 93);
            MedHistoryTextBox.TabIndex = 1;
            MedHistoryTextBox.Text = "";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(49, 175);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(80, 31);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name:";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthdayLabel.ForeColor = Color.White;
            BirthdayLabel.Location = new Point(25, 220);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(104, 31);
            BirthdayLabel.TabIndex = 10;
            BirthdayLabel.Text = "Birthday:";
            // 
            // BreedLable
            // 
            BreedLable.AutoSize = true;
            BreedLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreedLable.ForeColor = Color.White;
            BreedLable.Location = new Point(47, 271);
            BreedLable.Name = "BreedLable";
            BreedLable.Size = new Size(78, 31);
            BreedLable.TabIndex = 11;
            BreedLable.Text = "Breed:";
            // 
            // MedHisLable
            // 
            MedHisLable.AutoSize = true;
            MedHisLable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedHisLable.ForeColor = Color.White;
            MedHisLable.Location = new Point(-2, 318);
            MedHisLable.Name = "MedHisLable";
            MedHisLable.Size = new Size(131, 23);
            MedHisLable.TabIndex = 12;
            MedHisLable.Text = "Medical History:";
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeightLabel.ForeColor = Color.White;
            WeightLabel.Location = new Point(392, 177);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(92, 31);
            WeightLabel.TabIndex = 14;
            WeightLabel.Text = "Weight:";
            WeightLabel.Click += label6_Click;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(483, 181);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(232, 27);
            WeightTextBox.TabIndex = 1;
            // 
            // ColorLable
            // 
            ColorLable.AutoSize = true;
            ColorLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColorLable.ForeColor = Color.White;
            ColorLable.Location = new Point(401, 220);
            ColorLable.Name = "ColorLable";
            ColorLable.Size = new Size(73, 31);
            ColorLable.TabIndex = 16;
            ColorLable.Text = "Color:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(483, 224);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(232, 27);
            ColorTextBox.TabIndex = 1;
            // 
            // ImageLabel
            // 
            ImageLabel.AutoSize = true;
            ImageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImageLabel.ForeColor = Color.White;
            ImageLabel.Location = new Point(401, 267);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(83, 31);
            ImageLabel.TabIndex = 18;
            ImageLabel.Text = "Image:";
            // 
            // ImageTextBox
            // 
            ImageTextBox.Location = new Point(483, 271);
            ImageTextBox.Name = "ImageTextBox";
            ImageTextBox.Size = new Size(232, 27);
            ImageTextBox.TabIndex = 1;
            // 
            // FavToyLabel
            // 
            FavToyLabel.AutoSize = true;
            FavToyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavToyLabel.ForeColor = Color.White;
            FavToyLabel.Location = new Point(385, 318);
            FavToyLabel.Name = "FavToyLabel";
            FavToyLabel.Size = new Size(99, 20);
            FavToyLabel.TabIndex = 20;
            FavToyLabel.Text = "Favourite Toy:";
            // 
            // FavToyTextBox
            // 
            FavToyTextBox.Location = new Point(483, 315);
            FavToyTextBox.Name = "FavToyTextBox";
            FavToyTextBox.Size = new Size(232, 27);
            FavToyTextBox.TabIndex = 1;
            // 
            // AddPetButton
            // 
            AddPetButton.BackColor = Color.DarkSlateBlue;
            AddPetButton.ForeColor = Color.White;
            AddPetButton.Location = new Point(551, 374);
            AddPetButton.Name = "AddPetButton";
            AddPetButton.Size = new Size(124, 64);
            AddPetButton.TabIndex = 1;
            AddPetButton.Text = "Add Pet";
            AddPetButton.UseVisualStyleBackColor = false;
            // 
            // NewPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(832, 450);
            Controls.Add(AddPetButton);
            Controls.Add(FavToyLabel);
            Controls.Add(FavToyTextBox);
            Controls.Add(ImageLabel);
            Controls.Add(ImageTextBox);
            Controls.Add(ColorLable);
            Controls.Add(ColorTextBox);
            Controls.Add(WeightLabel);
            Controls.Add(WeightTextBox);
            Controls.Add(MedHisLable);
            Controls.Add(BreedLable);
            Controls.Add(BirthdayLabel);
            Controls.Add(NameLabel);
            Controls.Add(MedHistoryTextBox);
            Controls.Add(BirthdayDatePicker);
            Controls.Add(BreedTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(radioButtonDog);
            Controls.Add(radioButtonCat);
            Controls.Add(LabelTitle);
            Name = "NewPet";
            Text = "NewPet";
            Load += NewPet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private RadioButton radioButtonCat;
        private RadioButton radioButtonDog;
        private TextBox NameTextBox;
        private TextBox BreedTextBox;
        private DateTimePicker BirthdayDatePicker;
        private RichTextBox MedHistoryTextBox;
        private Label NameLabel;
        private Label BirthdayLabel;
        private Label BreedLable;
        private Label MedHisLable;
        private Label WeightLabel;
        private TextBox WeightTextBox;
        private Label ColorLable;
        private TextBox ColorTextBox;
        private Label ImageLabel;
        private TextBox ImageTextBox;
        private Label FavToyLabel;
        private TextBox FavToyTextBox;
        private Button AddPetButton;
    }
}