using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.characterNameTextbox.Text != "")
            {
                characterInfoBox.Items.Add(this.characterNameTextbox.Text);
                this.characterNameTextbox.Focus();
                this.characterNameTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK); //messageboxicon.in?
                this.characterNameTextbox.Focus();
            }
        }
        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Male.Checked)
            {
                this.characterInfoBox.Items.Remove("Female");
                this.characterInfoBox.Items.Remove("Male");
                characterInfoBox.Items.Add("Male");
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            this.characterInfoBox.Items.Remove("Female");
            this.characterInfoBox.Items.Remove("Male");
            characterInfoBox.Items.Add("Female");
        }

        private void fighter_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Fighter");
        }

        private void Archer_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Archer");
        }

        private void Mage_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Mage");
        }

        private void Assassin_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Assassin");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Greathammer of the Mountain");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Merlin's Staff");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Nightshade Dagger");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Trueshot Bow");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Mysterious Trinket");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("Spectral Bagpipes");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            characterInfoBox.Items.Add("A normal rock");
        }
    }
}
