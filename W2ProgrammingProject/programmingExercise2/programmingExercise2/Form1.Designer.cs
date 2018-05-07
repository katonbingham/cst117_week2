namespace programmingExercise2
{
    partial class Form1
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
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.characterNameTextbox = new System.Windows.Forms.TextBox();
            this.enterName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.characterInfoBox = new System.Windows.Forms.ListBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.Fighter = new System.Windows.Forms.RadioButton();
            this.Archer = new System.Windows.Forms.RadioButton();
            this.Mage = new System.Windows.Forms.RadioButton();
            this.Assassin = new System.Windows.Forms.RadioButton();
            this.characterInfoBoxLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(15, 24);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(15, 39);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 1;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character Creation";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Greathammer of the Mountain";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Merlin\'s Staff";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 237);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Nightshade Dagger";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 251);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(92, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Trueshot Bow";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // characterNameTextbox
            // 
            this.characterNameTextbox.Location = new System.Drawing.Point(14, 78);
            this.characterNameTextbox.Name = "characterNameTextbox";
            this.characterNameTextbox.Size = new System.Drawing.Size(138, 20);
            this.characterNameTextbox.TabIndex = 9;
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Location = new System.Drawing.Point(11, 62);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(63, 13);
            this.enterName.TabIndex = 10;
            this.enterName.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Starting Gear";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(15, 265);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(112, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Mysterious Trinket";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(15, 279);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(112, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Spectral Bagpipes";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(158, 79);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(45, 19);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // characterInfoBox
            // 
            this.characterInfoBox.FormattingEnabled = true;
            this.characterInfoBox.Location = new System.Drawing.Point(300, 24);
            this.characterInfoBox.Name = "characterInfoBox";
            this.characterInfoBox.Size = new System.Drawing.Size(217, 368);
            this.characterInfoBox.TabIndex = 16;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(15, 293);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(62, 17);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "A Rock";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // Fighter
            // 
            this.Fighter.AutoSize = true;
            this.Fighter.Location = new System.Drawing.Point(6, 15);
            this.Fighter.Name = "Fighter";
            this.Fighter.Size = new System.Drawing.Size(57, 17);
            this.Fighter.TabIndex = 18;
            this.Fighter.TabStop = true;
            this.Fighter.Text = "Fighter";
            this.Fighter.UseVisualStyleBackColor = true;
            this.Fighter.CheckedChanged += new System.EventHandler(this.fighter_CheckedChanged);
            // 
            // Archer
            // 
            this.Archer.AutoSize = true;
            this.Archer.Location = new System.Drawing.Point(6, 31);
            this.Archer.Name = "Archer";
            this.Archer.Size = new System.Drawing.Size(56, 17);
            this.Archer.TabIndex = 19;
            this.Archer.TabStop = true;
            this.Archer.Text = "Archer";
            this.Archer.UseVisualStyleBackColor = true;
            this.Archer.CheckedChanged += new System.EventHandler(this.Archer_CheckedChanged);
            // 
            // Mage
            // 
            this.Mage.AutoSize = true;
            this.Mage.Location = new System.Drawing.Point(6, 47);
            this.Mage.Name = "Mage";
            this.Mage.Size = new System.Drawing.Size(52, 17);
            this.Mage.TabIndex = 20;
            this.Mage.TabStop = true;
            this.Mage.Text = "Mage";
            this.Mage.UseVisualStyleBackColor = true;
            this.Mage.CheckedChanged += new System.EventHandler(this.Mage_CheckedChanged);
            // 
            // Assassin
            // 
            this.Assassin.AutoSize = true;
            this.Assassin.Location = new System.Drawing.Point(6, 63);
            this.Assassin.Name = "Assassin";
            this.Assassin.Size = new System.Drawing.Size(66, 17);
            this.Assassin.TabIndex = 21;
            this.Assassin.TabStop = true;
            this.Assassin.Text = "Assassin";
            this.Assassin.UseVisualStyleBackColor = true;
            this.Assassin.CheckedChanged += new System.EventHandler(this.Assassin_CheckedChanged);
            // 
            // characterInfoBoxLabel
            // 
            this.characterInfoBoxLabel.AutoSize = true;
            this.characterInfoBoxLabel.Location = new System.Drawing.Point(297, 9);
            this.characterInfoBoxLabel.Name = "characterInfoBoxLabel";
            this.characterInfoBoxLabel.Size = new System.Drawing.Size(74, 13);
            this.characterInfoBoxLabel.TabIndex = 22;
            this.characterInfoBoxLabel.Text = "Character Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Assassin);
            this.groupBox1.Controls.Add(this.Mage);
            this.groupBox1.Controls.Add(this.Archer);
            this.groupBox1.Controls.Add(this.Fighter);
            this.groupBox1.Location = new System.Drawing.Point(14, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 85);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.characterInfoBoxLabel);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.characterInfoBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.characterNameTextbox);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Name = "Form1";
            this.Text = "Character Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox characterNameTextbox;
        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox characterInfoBox;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.RadioButton Fighter;
        private System.Windows.Forms.RadioButton Archer;
        private System.Windows.Forms.RadioButton Mage;
        private System.Windows.Forms.RadioButton Assassin;
        private System.Windows.Forms.Label characterInfoBoxLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

