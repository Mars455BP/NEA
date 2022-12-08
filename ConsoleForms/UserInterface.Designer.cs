namespace ConsoleForms
{
    partial class UserInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Marker = new System.Windows.Forms.PictureBox();
            this.Milk = new System.Windows.Forms.CheckBox();
            this.Cheese = new System.Windows.Forms.CheckBox();
            this.Eggs = new System.Windows.Forms.CheckBox();
            this.Apples = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.Bananas = new System.Windows.Forms.CheckBox();
            this.BakedBeans = new System.Windows.Forms.CheckBox();
            this.Garlic = new System.Windows.Forms.CheckBox();
            this.ChilliPowder = new System.Windows.Forms.CheckBox();
            this.ChoppedTomatoes = new System.Windows.Forms.CheckBox();
            this.IceCream = new System.Windows.Forms.CheckBox();
            this.CatFood = new System.Windows.Forms.CheckBox();
            this.FrozenPizza = new System.Windows.Forms.CheckBox();
            this.DogToys = new System.Windows.Forms.CheckBox();
            this.DogFood = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marker)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 726);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(-1, -1);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(477, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(375, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pick List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Marker.Image = ((System.Drawing.Image)(resources.GetObject("Marker.Image")));
            this.Marker.Location = new System.Drawing.Point(96, 279);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(22, 22);
            this.Marker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Marker.TabIndex = 7;
            this.Marker.TabStop = false;
            // 
            // Milk
            // 
            this.Milk.Appearance = System.Windows.Forms.Appearance.Button;
            this.Milk.AutoSize = true;
            this.Milk.BackColor = System.Drawing.Color.Crimson;
            this.Milk.Checked = true;
            this.Milk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Milk.FlatAppearance.BorderSize = 0;
            this.Milk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Milk.ForeColor = System.Drawing.Color.Cornsilk;
            this.Milk.Location = new System.Drawing.Point(127, 326);
            this.Milk.Name = "Milk";
            this.Milk.Size = new System.Drawing.Size(6, 6);
            this.Milk.TabIndex = 8;
            this.Milk.UseVisualStyleBackColor = false;
            this.Milk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cheese
            // 
            this.Cheese.Appearance = System.Windows.Forms.Appearance.Button;
            this.Cheese.AutoSize = true;
            this.Cheese.BackColor = System.Drawing.Color.Crimson;
            this.Cheese.Checked = true;
            this.Cheese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cheese.FlatAppearance.BorderSize = 0;
            this.Cheese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheese.ForeColor = System.Drawing.Color.Cornsilk;
            this.Cheese.Location = new System.Drawing.Point(77, 389);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(6, 6);
            this.Cheese.TabIndex = 9;
            this.Cheese.UseVisualStyleBackColor = false;
            // 
            // Eggs
            // 
            this.Eggs.Appearance = System.Windows.Forms.Appearance.Button;
            this.Eggs.AutoSize = true;
            this.Eggs.BackColor = System.Drawing.Color.Crimson;
            this.Eggs.Checked = true;
            this.Eggs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Eggs.FlatAppearance.BorderSize = 0;
            this.Eggs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eggs.ForeColor = System.Drawing.Color.Cornsilk;
            this.Eggs.Location = new System.Drawing.Point(77, 425);
            this.Eggs.Name = "Eggs";
            this.Eggs.Size = new System.Drawing.Size(6, 6);
            this.Eggs.TabIndex = 10;
            this.Eggs.UseVisualStyleBackColor = false;
            // 
            // Apples
            // 
            this.Apples.Appearance = System.Windows.Forms.Appearance.Button;
            this.Apples.AutoSize = true;
            this.Apples.BackColor = System.Drawing.Color.Crimson;
            this.Apples.Checked = true;
            this.Apples.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Apples.FlatAppearance.BorderSize = 0;
            this.Apples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apples.ForeColor = System.Drawing.Color.Cornsilk;
            this.Apples.Location = new System.Drawing.Point(136, 389);
            this.Apples.Name = "Apples";
            this.Apples.Size = new System.Drawing.Size(6, 6);
            this.Apples.TabIndex = 11;
            this.Apples.UseVisualStyleBackColor = false;
            // 
            // Tomatoes
            // 
            this.Tomatoes.Appearance = System.Windows.Forms.Appearance.Button;
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.BackColor = System.Drawing.Color.Crimson;
            this.Tomatoes.Checked = true;
            this.Tomatoes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tomatoes.FlatAppearance.BorderSize = 0;
            this.Tomatoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tomatoes.ForeColor = System.Drawing.Color.Cornsilk;
            this.Tomatoes.Location = new System.Drawing.Point(136, 504);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(6, 6);
            this.Tomatoes.TabIndex = 12;
            this.Tomatoes.UseVisualStyleBackColor = false;
            // 
            // Bananas
            // 
            this.Bananas.Appearance = System.Windows.Forms.Appearance.Button;
            this.Bananas.AutoSize = true;
            this.Bananas.BackColor = System.Drawing.Color.Crimson;
            this.Bananas.Checked = true;
            this.Bananas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Bananas.FlatAppearance.BorderSize = 0;
            this.Bananas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bananas.ForeColor = System.Drawing.Color.Cornsilk;
            this.Bananas.Location = new System.Drawing.Point(185, 363);
            this.Bananas.Name = "Bananas";
            this.Bananas.Size = new System.Drawing.Size(6, 6);
            this.Bananas.TabIndex = 13;
            this.Bananas.UseVisualStyleBackColor = false;
            // 
            // BakedBeans
            // 
            this.BakedBeans.Appearance = System.Windows.Forms.Appearance.Button;
            this.BakedBeans.AutoSize = true;
            this.BakedBeans.BackColor = System.Drawing.Color.Crimson;
            this.BakedBeans.Checked = true;
            this.BakedBeans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BakedBeans.FlatAppearance.BorderSize = 0;
            this.BakedBeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BakedBeans.ForeColor = System.Drawing.Color.Cornsilk;
            this.BakedBeans.Location = new System.Drawing.Point(194, 273);
            this.BakedBeans.Name = "BakedBeans";
            this.BakedBeans.Size = new System.Drawing.Size(6, 6);
            this.BakedBeans.TabIndex = 14;
            this.BakedBeans.UseVisualStyleBackColor = false;
            // 
            // Garlic
            // 
            this.Garlic.Appearance = System.Windows.Forms.Appearance.Button;
            this.Garlic.AutoSize = true;
            this.Garlic.BackColor = System.Drawing.Color.Crimson;
            this.Garlic.Checked = true;
            this.Garlic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Garlic.FlatAppearance.BorderSize = 0;
            this.Garlic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Garlic.ForeColor = System.Drawing.Color.Cornsilk;
            this.Garlic.Location = new System.Drawing.Point(244, 389);
            this.Garlic.Name = "Garlic";
            this.Garlic.Size = new System.Drawing.Size(6, 6);
            this.Garlic.TabIndex = 15;
            this.Garlic.UseVisualStyleBackColor = false;
            // 
            // ChilliPowder
            // 
            this.ChilliPowder.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChilliPowder.AutoSize = true;
            this.ChilliPowder.BackColor = System.Drawing.Color.Crimson;
            this.ChilliPowder.Checked = true;
            this.ChilliPowder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChilliPowder.FlatAppearance.BorderSize = 0;
            this.ChilliPowder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChilliPowder.ForeColor = System.Drawing.Color.Cornsilk;
            this.ChilliPowder.Location = new System.Drawing.Point(244, 358);
            this.ChilliPowder.Name = "ChilliPowder";
            this.ChilliPowder.Size = new System.Drawing.Size(6, 6);
            this.ChilliPowder.TabIndex = 16;
            this.ChilliPowder.UseVisualStyleBackColor = false;
            // 
            // ChoppedTomatoes
            // 
            this.ChoppedTomatoes.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChoppedTomatoes.AutoSize = true;
            this.ChoppedTomatoes.BackColor = System.Drawing.Color.Crimson;
            this.ChoppedTomatoes.Checked = true;
            this.ChoppedTomatoes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChoppedTomatoes.FlatAppearance.BorderSize = 0;
            this.ChoppedTomatoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoppedTomatoes.ForeColor = System.Drawing.Color.Cornsilk;
            this.ChoppedTomatoes.Location = new System.Drawing.Point(194, 325);
            this.ChoppedTomatoes.Name = "ChoppedTomatoes";
            this.ChoppedTomatoes.Size = new System.Drawing.Size(6, 6);
            this.ChoppedTomatoes.TabIndex = 17;
            this.ChoppedTomatoes.UseVisualStyleBackColor = false;
            // 
            // IceCream
            // 
            this.IceCream.Appearance = System.Windows.Forms.Appearance.Button;
            this.IceCream.AutoSize = true;
            this.IceCream.BackColor = System.Drawing.Color.Crimson;
            this.IceCream.Checked = true;
            this.IceCream.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IceCream.FlatAppearance.BorderSize = 0;
            this.IceCream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IceCream.ForeColor = System.Drawing.Color.Cornsilk;
            this.IceCream.Location = new System.Drawing.Point(301, 389);
            this.IceCream.Name = "IceCream";
            this.IceCream.Size = new System.Drawing.Size(6, 6);
            this.IceCream.TabIndex = 18;
            this.IceCream.UseVisualStyleBackColor = false;
            // 
            // CatFood
            // 
            this.CatFood.Appearance = System.Windows.Forms.Appearance.Button;
            this.CatFood.AutoSize = true;
            this.CatFood.BackColor = System.Drawing.Color.Crimson;
            this.CatFood.Checked = true;
            this.CatFood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CatFood.FlatAppearance.BorderSize = 0;
            this.CatFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatFood.ForeColor = System.Drawing.Color.Cornsilk;
            this.CatFood.Location = new System.Drawing.Point(310, 389);
            this.CatFood.Name = "CatFood";
            this.CatFood.Size = new System.Drawing.Size(6, 6);
            this.CatFood.TabIndex = 19;
            this.CatFood.UseVisualStyleBackColor = false;
            // 
            // FrozenPizza
            // 
            this.FrozenPizza.Appearance = System.Windows.Forms.Appearance.Button;
            this.FrozenPizza.AutoSize = true;
            this.FrozenPizza.BackColor = System.Drawing.Color.Crimson;
            this.FrozenPizza.Checked = true;
            this.FrozenPizza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FrozenPizza.FlatAppearance.BorderSize = 0;
            this.FrozenPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrozenPizza.ForeColor = System.Drawing.Color.Cornsilk;
            this.FrozenPizza.Location = new System.Drawing.Point(252, 308);
            this.FrozenPizza.Name = "FrozenPizza";
            this.FrozenPizza.Size = new System.Drawing.Size(6, 6);
            this.FrozenPizza.TabIndex = 20;
            this.FrozenPizza.UseVisualStyleBackColor = false;
            // 
            // DogToys
            // 
            this.DogToys.Appearance = System.Windows.Forms.Appearance.Button;
            this.DogToys.AutoSize = true;
            this.DogToys.BackColor = System.Drawing.Color.Crimson;
            this.DogToys.Checked = true;
            this.DogToys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DogToys.FlatAppearance.BorderSize = 0;
            this.DogToys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DogToys.ForeColor = System.Drawing.Color.Cornsilk;
            this.DogToys.Location = new System.Drawing.Point(359, 364);
            this.DogToys.Name = "DogToys";
            this.DogToys.Size = new System.Drawing.Size(6, 6);
            this.DogToys.TabIndex = 21;
            this.DogToys.UseVisualStyleBackColor = false;
            this.DogToys.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // DogFood
            // 
            this.DogFood.Appearance = System.Windows.Forms.Appearance.Button;
            this.DogFood.AutoSize = true;
            this.DogFood.BackColor = System.Drawing.Color.Crimson;
            this.DogFood.Checked = true;
            this.DogFood.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DogFood.FlatAppearance.BorderSize = 0;
            this.DogFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DogFood.ForeColor = System.Drawing.Color.Cornsilk;
            this.DogFood.Location = new System.Drawing.Point(359, 298);
            this.DogFood.Name = "DogFood";
            this.DogFood.Size = new System.Drawing.Size(6, 6);
            this.DogFood.TabIndex = 22;
            this.DogFood.UseVisualStyleBackColor = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 785);
            this.Controls.Add(this.DogFood);
            this.Controls.Add(this.DogToys);
            this.Controls.Add(this.FrozenPizza);
            this.Controls.Add(this.CatFood);
            this.Controls.Add(this.IceCream);
            this.Controls.Add(this.ChoppedTomatoes);
            this.Controls.Add(this.ChilliPowder);
            this.Controls.Add(this.Garlic);
            this.Controls.Add(this.BakedBeans);
            this.Controls.Add(this.Bananas);
            this.Controls.Add(this.Tomatoes);
            this.Controls.Add(this.Apples);
            this.Controls.Add(this.Eggs);
            this.Controls.Add(this.Cheese);
            this.Controls.Add(this.Milk);
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Marker;
        public System.Windows.Forms.CheckBox Milk;
        public System.Windows.Forms.CheckBox Cheese;
        public System.Windows.Forms.CheckBox Eggs;
        public System.Windows.Forms.CheckBox Apples;
        public System.Windows.Forms.CheckBox Tomatoes;
        public System.Windows.Forms.CheckBox Bananas;
        public System.Windows.Forms.CheckBox BakedBeans;
        public System.Windows.Forms.CheckBox Garlic;
        public System.Windows.Forms.CheckBox ChilliPowder;
        public System.Windows.Forms.CheckBox ChoppedTomatoes;
        public System.Windows.Forms.CheckBox IceCream;
        public System.Windows.Forms.CheckBox CatFood;
        public System.Windows.Forms.CheckBox FrozenPizza;
        public System.Windows.Forms.CheckBox DogToys;
        public System.Windows.Forms.CheckBox DogFood;
    }
}