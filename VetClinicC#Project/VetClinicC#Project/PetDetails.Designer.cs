namespace VetClinicC_Project
{
    partial class PetDetails
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
            listViewProfilePic = new ListView();
            FavToyLabel = new Label();
            StatusTextBox = new TextBox();
            StatusLable = new Label();
            TextBoxFavToy = new TextBox();
            ColorLabel = new Label();
            ColorTextBox = new TextBox();
            WeightLabel = new Label();
            WeightTextBox = new TextBox();
            MedHisLabel = new Label();
            BreedLabel = new Label();
            BirthdayLabel = new Label();
            TypeLabel = new Label();
            MedHistoryTextBox = new RichTextBox();
            dateTimePicker = new DateTimePicker();
            BreedTextBox = new TextBox();
            TypeTextBox = new TextBox();
            AdoptButton = new Button();
            PetsNameLabel = new Label();
            SuspendLayout();
            // 
            // listViewProfilePic
            // 
            listViewProfilePic.BackColor = Color.SpringGreen;
            listViewProfilePic.Location = new Point(33, 43);
            listViewProfilePic.Name = "listViewProfilePic";
            listViewProfilePic.Size = new Size(134, 125);
            listViewProfilePic.TabIndex = 0;
            listViewProfilePic.UseCompatibleStateImageBehavior = false;
            // 
            // FavToyLabel
            // 
            FavToyLabel.AutoSize = true;
            FavToyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavToyLabel.ForeColor = Color.White;
            FavToyLabel.Location = new Point(416, 274);
            FavToyLabel.Name = "FavToyLabel";
            FavToyLabel.Size = new Size(99, 20);
            FavToyLabel.TabIndex = 36;
            FavToyLabel.Text = "Favourite Toy:";
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(521, 315);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(232, 27);
            StatusTextBox.TabIndex = 35;
            // 
            // StatusLable
            // 
            StatusLable.AutoSize = true;
            StatusLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLable.ForeColor = Color.White;
            StatusLable.Location = new Point(430, 313);
            StatusLable.Name = "StatusLable";
            StatusLable.Size = new Size(81, 31);
            StatusLable.TabIndex = 34;
            StatusLable.Text = "Status:";
            // 
            // TextBoxFavToy
            // 
            TextBoxFavToy.Location = new Point(521, 271);
            TextBoxFavToy.Name = "TextBoxFavToy";
            TextBoxFavToy.Size = new Size(232, 27);
            TextBoxFavToy.TabIndex = 33;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColorLabel.ForeColor = Color.White;
            ColorLabel.Location = new Point(439, 220);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(73, 31);
            ColorLabel.TabIndex = 32;
            ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(521, 224);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(232, 27);
            ColorTextBox.TabIndex = 31;
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeightLabel.ForeColor = Color.White;
            WeightLabel.Location = new Point(430, 177);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(92, 31);
            WeightLabel.TabIndex = 30;
            WeightLabel.Text = "Weight:";
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(521, 181);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(232, 27);
            WeightTextBox.TabIndex = 29;
            // 
            // MedHisLabel
            // 
            MedHisLabel.AutoSize = true;
            MedHisLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedHisLabel.ForeColor = Color.White;
            MedHisLabel.Location = new Point(36, 318);
            MedHisLabel.Name = "MedHisLabel";
            MedHisLabel.Size = new Size(131, 23);
            MedHisLabel.TabIndex = 28;
            MedHisLabel.Text = "Medical History:";
            // 
            // BreedLabel
            // 
            BreedLabel.AutoSize = true;
            BreedLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreedLabel.ForeColor = Color.White;
            BreedLabel.Location = new Point(85, 271);
            BreedLabel.Name = "BreedLabel";
            BreedLabel.Size = new Size(78, 31);
            BreedLabel.TabIndex = 27;
            BreedLabel.Text = "Breed:";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthdayLabel.ForeColor = Color.White;
            BirthdayLabel.Location = new Point(63, 220);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(104, 31);
            BirthdayLabel.TabIndex = 26;
            BirthdayLabel.Text = "Birthday:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeLabel.ForeColor = Color.White;
            TypeLabel.Location = new Point(87, 175);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(67, 31);
            TypeLabel.TabIndex = 25;
            TypeLabel.Text = "Type:";
            // 
            // MedHistoryTextBox
            // 
            MedHistoryTextBox.Location = new Point(169, 319);
            MedHistoryTextBox.Name = "MedHistoryTextBox";
            MedHistoryTextBox.Size = new Size(232, 93);
            MedHistoryTextBox.TabIndex = 24;
            MedHistoryTextBox.Text = "";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(169, 224);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(232, 27);
            dateTimePicker.TabIndex = 23;
            // 
            // BreedTextBox
            // 
            BreedTextBox.Location = new Point(169, 271);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(232, 27);
            BreedTextBox.TabIndex = 22;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(169, 179);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(232, 27);
            TypeTextBox.TabIndex = 21;
            // 
            // AdoptButton
            // 
            AdoptButton.BackColor = Color.Indigo;
            AdoptButton.ForeColor = Color.White;
            AdoptButton.Location = new Point(572, 363);
            AdoptButton.Name = "AdoptButton";
            AdoptButton.Size = new Size(141, 49);
            AdoptButton.TabIndex = 37;
            AdoptButton.Text = "Adopt";
            AdoptButton.UseVisualStyleBackColor = false;
            // 
            // PetsNameLabel
            // 
            PetsNameLabel.AutoSize = true;
            PetsNameLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PetsNameLabel.ForeColor = Color.White;
            PetsNameLabel.Location = new Point(297, 43);
            PetsNameLabel.Name = "PetsNameLabel";
            PetsNameLabel.Size = new Size(302, 81);
            PetsNameLabel.TabIndex = 38;
            PetsNameLabel.Text = "PetsName";
            // 
            // PetDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(PetsNameLabel);
            Controls.Add(AdoptButton);
            Controls.Add(FavToyLabel);
            Controls.Add(StatusTextBox);
            Controls.Add(StatusLable);
            Controls.Add(TextBoxFavToy);
            Controls.Add(ColorLabel);
            Controls.Add(ColorTextBox);
            Controls.Add(WeightLabel);
            Controls.Add(WeightTextBox);
            Controls.Add(MedHisLabel);
            Controls.Add(BreedLabel);
            Controls.Add(BirthdayLabel);
            Controls.Add(TypeLabel);
            Controls.Add(MedHistoryTextBox);
            Controls.Add(dateTimePicker);
            Controls.Add(BreedTextBox);
            Controls.Add(TypeTextBox);
            Controls.Add(listViewProfilePic);
            Name = "PetDetails";
            Text = "PetDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProfilePic;
        private Label FavToyLabel;
        private TextBox StatusTextBox;
        private Label StatusLable;
        private TextBox TextBoxFavToy;
        private Label ColorLabel;
        private TextBox ColorTextBox;
        private Label WeightLabel;
        private TextBox WeightTextBox;
        private Label MedHisLabel;
        private Label BreedLabel;
        private Label BirthdayLabel;
        private Label TypeLabel;
        private RichTextBox MedHistoryTextBox;
        private DateTimePicker dateTimePicker;
        private TextBox BreedTextBox;
        private TextBox TypeTextBox;
        private Button AdoptButton;
        private Label PetsNameLabel;
    }
}