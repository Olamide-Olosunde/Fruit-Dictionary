namespace Fruit
{
    partial class Form1
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
            labelListOfFruits = new Label();
            listBoxAllFruits = new ListBox();
            button1 = new Button();
            labelPickAFruit = new Label();
            labelFruitName = new Label();
            labelFruitDescription = new Label();
            btnListOfFruits = new Button();
            btnLight = new Button();
            SuspendLayout();
            // 
            // labelListOfFruits
            // 
            labelListOfFruits.AutoSize = true;
            labelListOfFruits.Font = new Font("Segoe UI", 14F);
            labelListOfFruits.Location = new Point(70, 37);
            labelListOfFruits.Name = "labelListOfFruits";
            labelListOfFruits.Size = new Size(167, 38);
            labelListOfFruits.TabIndex = 0;
            labelListOfFruits.Text = "List of Fruits";
            // 
            // listBoxAllFruits
            // 
            listBoxAllFruits.Font = new Font("Segoe UI", 12F);
            listBoxAllFruits.FormattingEnabled = true;
            listBoxAllFruits.ItemHeight = 32;
            listBoxAllFruits.Items.AddRange(new object[] { "Orange", "Mandarin", "Apple", "Pear", "Peach", "Cherry", "Peas", "Beans", "Almond", "Walnut", "Corn", "Strawberry", "Raspberry", "Blackberry", "Pineapple", "Fig", "Mulberry" });
            listBoxAllFruits.Location = new Point(70, 114);
            listBoxAllFruits.Name = "listBoxAllFruits";
            listBoxAllFruits.Size = new Size(291, 292);
            listBoxAllFruits.TabIndex = 1;
            listBoxAllFruits.SelectedIndexChanged += listBoxAllFruits_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(546, 216);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // labelPickAFruit
            // 
            labelPickAFruit.AutoSize = true;
            labelPickAFruit.Font = new Font("Segoe UI", 8F);
            labelPickAFruit.Location = new Point(70, 90);
            labelPickAFruit.Name = "labelPickAFruit";
            labelPickAFruit.Size = new Size(202, 21);
            labelPickAFruit.TabIndex = 3;
            labelPickAFruit.Text = "Pick a fruit to learn about it!";
            // 
            // labelFruitName
            // 
            labelFruitName.AutoSize = true;
            labelFruitName.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            labelFruitName.Location = new Point(393, 37);
            labelFruitName.Name = "labelFruitName";
            labelFruitName.Size = new Size(187, 48);
            labelFruitName.TabIndex = 4;
            labelFruitName.Text = "FruitName";
            labelFruitName.Visible = false;
            // 
            // labelFruitDescription
            // 
            labelFruitDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFruitDescription.AutoSize = true;
            labelFruitDescription.Font = new Font("Segoe UI", 12F);
            labelFruitDescription.Location = new Point(326, 189);
            labelFruitDescription.Name = "labelFruitDescription";
            labelFruitDescription.Size = new Size(183, 32);
            labelFruitDescription.TabIndex = 5;
            labelFruitDescription.Text = "FruitDescription";
            labelFruitDescription.TextAlign = ContentAlignment.MiddleCenter;
            labelFruitDescription.Visible = false;
            // 
            // btnListOfFruits
            // 
            btnListOfFruits.AutoSize = true;
            btnListOfFruits.Font = new Font("Segoe UI", 10F);
            btnListOfFruits.Location = new Point(12, 395);
            btnListOfFruits.Name = "btnListOfFruits";
            btnListOfFruits.Size = new Size(132, 43);
            btnListOfFruits.TabIndex = 6;
            btnListOfFruits.Text = "List of Fruits";
            btnListOfFruits.UseVisualStyleBackColor = true;
            btnListOfFruits.Visible = false;
            btnListOfFruits.Click += btnListOfFruits_Click;
            // 
            // btnLight
            // 
            btnLight.Location = new Point(602, 404);
            btnLight.Name = "btnLight";
            btnLight.Size = new Size(186, 34);
            btnLight.TabIndex = 7;
            btnLight.Text = "Light/Dark Theme";
            btnLight.UseVisualStyleBackColor = true;
            btnLight.Click += btnLight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLight);
            Controls.Add(btnListOfFruits);
            Controls.Add(labelFruitDescription);
            Controls.Add(labelFruitName);
            Controls.Add(labelPickAFruit);
            Controls.Add(button1);
            Controls.Add(listBoxAllFruits);
            Controls.Add(labelListOfFruits);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelListOfFruits;
        public ListBox listBoxAllFruits;
        private Button button1;
        private Label labelPickAFruit;
        private Label labelFruitName;
        private Label labelFruitDescription;
        private Button btnListOfFruits;
        private Button btnLight;
    }
}
