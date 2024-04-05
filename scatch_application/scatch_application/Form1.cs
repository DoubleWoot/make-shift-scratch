using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scatch_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbox_up_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // makes it so only numbers are allowed as input in the text box
            }
        }

        private void textbox_down_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // makes it so only numbers are allowed as input in the text box
            }
        }

        private void textbox_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // makes it so only numbers are allowed as input in the text box
            }
        }

        private void textbox_right_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // makes it so only numbers are allowed as input in the text box
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            // checks if the textbox has laman
            // it then parses the user input into a float
            if (!string.IsNullOrWhiteSpace(textbox_up.Text) && float.TryParse(textbox_up.Text, out float moveDistance))
            {
                // calculates the y position
                float modY = character.Top - moveDistance; // subtracts because going up

                if (modY < 0) // checks if the character is nearing the border
                {
                    modY = 600 - character.Height; // prevents the character to leave the panel
                }

                // adds the log in the list box output
                string log = $"You have moved {moveDistance} going up!";
                listBoxOutput.Items.Add(log);

                // applies the new position
                character.Top = (int)modY;
            }
            else
            {
                MessageBox.Show("Please enter a number!"); // makes a messagebox pop up if the textbox is null
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_down.Text) && float.TryParse(textbox_down.Text, out float moveDistance))
            {
                // calculates the y position
                float modY = character.Top + moveDistance; // add because going down

                if ((modY + character.Height) > panelBackground.Height)
                {
                    // adjusts the character to stay inside the panel
                    modY = panelBackground.Height - panelBackground.Height;
                }

                // adds the log in the list box output
                string log = $"You have moved {moveDistance} going down!";
                listBoxOutput.Items.Add(log);

                // applies the new position
                character.Top = (int)modY;
            }
            else
            {
                MessageBox.Show("Please enter a number!"); // makes a messagebox pop up if the textbox is null
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_left.Text) && float.TryParse(textbox_left.Text, out float moveDistance))
            {
                // calculates the x position
                float modX = character.Left - moveDistance; // subtracts because going left

                if (modX < 0) // checks if the character is nearing the border
                {
                    modX = 0; // prevents the character to leave the panel
                }

                // adds the log in the list box output
                string log = $"You have moved {moveDistance} going left!";
                listBoxOutput.Items.Add(log);

                // applies the new position
                character.Left = (int)modX;
            }
            else
            {
                MessageBox.Show("Please enter a number!"); // makes a messagebox pop up if the textbox is null
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_left.Text) && float.TryParse(textbox_left.Text, out float moveDistance))
            {
                // calculates the x position
                float modX = character.Left + moveDistance; // addition because going right

                if (modX > (600 - character.Width)) // checks if the character is nearing the border
                {
                    modX = 600 - character.Width; // prevents the character to leave the panel
                }

                // adds the log in the list box output
                string log = $"You have moved {moveDistance} going right!";
                listBoxOutput.Items.Add(log);

                // applies the new position
                character.Left = (int)modX;
            }
            else
            {
                MessageBox.Show("Please enter a number!"); // makes a messagebox pop up if the textbox is null
            }
        }

        private void teleportButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxX = 600 - character.Width;
            int maxY = 600 - character.Height;

            // sets the random coordinates for the character
            int randomX = random.Next(0, maxX + 1);
            int randomY = random.Next(0, maxY + 1);

            // applies the random coordinates inside the panel
            character.Location = new Point(randomX, randomY);

            string log = "You teleported!";
            listBoxOutput.Items.Add(log);
        }

    }

}

