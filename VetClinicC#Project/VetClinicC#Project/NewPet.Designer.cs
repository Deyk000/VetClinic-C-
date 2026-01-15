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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            NameTextBox = new TextBox();
            BreedTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            MedHistoryTextBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            WeightTextBox = new TextBox();
            label7 = new Label();
            ColorTextBox = new TextBox();
            label8 = new Label();
            ImageTextBox = new TextBox();
            label9 = new Label();
            FavToyTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 77);
            label1.TabIndex = 0;
            label1.Text = "New Pet";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(131, 131);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cat";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(250, 131);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dog";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(131, 179);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(232, 27);
            NameTextBox.TabIndex = 3;
            NameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // BreedTextBox
            // 
            BreedTextBox.Location = new Point(131, 271);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(232, 27);
            BreedTextBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(131, 224);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(232, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // MedHistoryTextBox
            // 
            MedHistoryTextBox.Location = new Point(131, 319);
            MedHistoryTextBox.Name = "MedHistoryTextBox";
            MedHistoryTextBox.Size = new Size(232, 93);
            MedHistoryTextBox.TabIndex = 8;
            MedHistoryTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 175);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 220);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 10;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 271);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 11;
            label4.Text = "Breed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-2, 318);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 12;
            label5.Text = "Medical History:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(392, 177);
            label6.Name = "label6";
            label6.Size = new Size(92, 31);
            label6.TabIndex = 14;
            label6.Text = "Weight:";
            label6.Click += label6_Click;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(483, 181);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(232, 27);
            WeightTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(401, 220);
            label7.Name = "label7";
            label7.Size = new Size(73, 31);
            label7.TabIndex = 16;
            label7.Text = "Color:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(483, 224);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(232, 27);
            ColorTextBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(401, 267);
            label8.Name = "label8";
            label8.Size = new Size(83, 31);
            label8.TabIndex = 18;
            label8.Text = "Image:";
            // 
            // ImageTextBox
            // 
            ImageTextBox.Location = new Point(483, 271);
            ImageTextBox.Name = "ImageTextBox";
            ImageTextBox.Size = new Size(232, 27);
            ImageTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(385, 318);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 20;
            label9.Text = "Favourite Toy:";
            // 
            // FavToyTextBox
            // 
            FavToyTextBox.Location = new Point(483, 315);
            FavToyTextBox.Name = "FavToyTextBox";
            FavToyTextBox.Size = new Size(232, 27);
            FavToyTextBox.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(551, 374);
            button1.Name = "button1";
            button1.Size = new Size(124, 64);
            button1.TabIndex = 21;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // NewPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(832, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(FavToyTextBox);
            Controls.Add(label8);
            Controls.Add(ImageTextBox);
            Controls.Add(label7);
            Controls.Add(ColorTextBox);
            Controls.Add(label6);
            Controls.Add(WeightTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MedHistoryTextBox);
            Controls.Add(dateTimePicker);
            Controls.Add(BreedTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "NewPet";
            Text = "NewPet";
            Load += NewPet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox NameTextBox;
        private TextBox BreedTextBox;
        private DateTimePicker dateTimePicker;
        private RichTextBox MedHistoryTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox WeightTextBox;
        private Label label7;
        private TextBox ColorTextBox;
        private Label label8;
        private TextBox ImageTextBox;
        private Label label9;
        private TextBox FavToyTextBox;
        private Button button1;
    }
}