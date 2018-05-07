namespace Exercise4
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
            this.userInputLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.secondsElapsed = new System.Windows.Forms.TextBox();
            this.minutesElapsed = new System.Windows.Forms.TextBox();
            this.hoursElapsed = new System.Windows.Forms.TextBox();
            this.secondsElapsedLabel = new System.Windows.Forms.Label();
            this.daysElapsed = new System.Windows.Forms.TextBox();
            this.minutesElapsedLabel = new System.Windows.Forms.Label();
            this.hoursElapsedLabel = new System.Windows.Forms.Label();
            this.daysElapsedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Location = new System.Drawing.Point(12, 9);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(121, 13);
            this.userInputLabel.TabIndex = 0;
            this.userInputLabel.Text = "Enter Seconds Elapsed:";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(139, 6);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(162, 20);
            this.userInput.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 32);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(289, 39);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // secondsElapsed
            // 
            this.secondsElapsed.Location = new System.Drawing.Point(139, 112);
            this.secondsElapsed.Name = "secondsElapsed";
            this.secondsElapsed.ReadOnly = true;
            this.secondsElapsed.Size = new System.Drawing.Size(119, 20);
            this.secondsElapsed.TabIndex = 3;
            // 
            // minutesElapsed
            // 
            this.minutesElapsed.Location = new System.Drawing.Point(139, 138);
            this.minutesElapsed.Name = "minutesElapsed";
            this.minutesElapsed.ReadOnly = true;
            this.minutesElapsed.Size = new System.Drawing.Size(119, 20);
            this.minutesElapsed.TabIndex = 4;
            // 
            // hoursElapsed
            // 
            this.hoursElapsed.Location = new System.Drawing.Point(139, 164);
            this.hoursElapsed.Name = "hoursElapsed";
            this.hoursElapsed.ReadOnly = true;
            this.hoursElapsed.Size = new System.Drawing.Size(119, 20);
            this.hoursElapsed.TabIndex = 5;
            // 
            // secondsElapsedLabel
            // 
            this.secondsElapsedLabel.AutoSize = true;
            this.secondsElapsedLabel.Location = new System.Drawing.Point(40, 115);
            this.secondsElapsedLabel.Name = "secondsElapsedLabel";
            this.secondsElapsedLabel.Size = new System.Drawing.Size(93, 13);
            this.secondsElapsedLabel.TabIndex = 6;
            this.secondsElapsedLabel.Text = "Seconds Elapsed:";
            // 
            // daysElapsed
            // 
            this.daysElapsed.Location = new System.Drawing.Point(139, 190);
            this.daysElapsed.Name = "daysElapsed";
            this.daysElapsed.ReadOnly = true;
            this.daysElapsed.Size = new System.Drawing.Size(119, 20);
            this.daysElapsed.TabIndex = 7;
            // 
            // minutesElapsedLabel
            // 
            this.minutesElapsedLabel.AutoSize = true;
            this.minutesElapsedLabel.Location = new System.Drawing.Point(45, 141);
            this.minutesElapsedLabel.Name = "minutesElapsedLabel";
            this.minutesElapsedLabel.Size = new System.Drawing.Size(88, 13);
            this.minutesElapsedLabel.TabIndex = 8;
            this.minutesElapsedLabel.Text = "Minutes Elapsed:";
            // 
            // hoursElapsedLabel
            // 
            this.hoursElapsedLabel.AutoSize = true;
            this.hoursElapsedLabel.Location = new System.Drawing.Point(54, 167);
            this.hoursElapsedLabel.Name = "hoursElapsedLabel";
            this.hoursElapsedLabel.Size = new System.Drawing.Size(79, 13);
            this.hoursElapsedLabel.TabIndex = 9;
            this.hoursElapsedLabel.Text = "Hours Elapsed:";
            // 
            // daysElapsedLabel
            // 
            this.daysElapsedLabel.AutoSize = true;
            this.daysElapsedLabel.Location = new System.Drawing.Point(58, 193);
            this.daysElapsedLabel.Name = "daysElapsedLabel";
            this.daysElapsedLabel.Size = new System.Drawing.Size(75, 13);
            this.daysElapsedLabel.TabIndex = 10;
            this.daysElapsedLabel.Text = "Days Elapsed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daysElapsedLabel);
            this.Controls.Add(this.hoursElapsedLabel);
            this.Controls.Add(this.minutesElapsedLabel);
            this.Controls.Add(this.daysElapsed);
            this.Controls.Add(this.secondsElapsedLabel);
            this.Controls.Add(this.hoursElapsed);
            this.Controls.Add(this.minutesElapsed);
            this.Controls.Add(this.secondsElapsed);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.userInputLabel);
            this.Name = "Form1";
            this.Text = "Exercise 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox secondsElapsed;
        private System.Windows.Forms.TextBox minutesElapsed;
        private System.Windows.Forms.TextBox hoursElapsed;
        private System.Windows.Forms.Label secondsElapsedLabel;
        private System.Windows.Forms.TextBox daysElapsed;
        private System.Windows.Forms.Label minutesElapsedLabel;
        private System.Windows.Forms.Label hoursElapsedLabel;
        private System.Windows.Forms.Label daysElapsedLabel;
    }
}

