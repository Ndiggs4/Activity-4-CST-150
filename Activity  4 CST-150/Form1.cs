namespace Activity__4_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This is the click handler for the button 
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // This is the click event handler for the button and the code will be executed when the button is clicked at runtime.

            // Display an error message if the input textbox is blank
            if (textBoxSeconds.Text == "")
            {
                MessageBox.Show("Please enter the value.");
            }
            else
            {
                // Proceed only if the input textbox has some data.

                // Get the value from the textbox, convert it to integer and store it in the variable "seconds"
                int seconds = Convert.ToInt32(textBoxSeconds.Text);

                // If the seconds is greater than or equal to 86400, convert it into days as follows and display the result in days in the output textbox
                if (seconds >= 86400)
                {
                    int days = seconds / 86400;
                    textBoxResult.Text = days + " days";
                }

                // If the above condition fails, proceed with the below
                // If the seconds is greater than or equal to 3600, convert it into hours as follows and display the result in hours in the output textbox
                else if (seconds >= 3600)
                {
                    int hours = seconds / 3600;
                    textBoxResult.Text = hours + " hours";
                }

                // If the above condition fails, proceed with the below
                // If the seconds is greater than or equal to 60, convert it into minutes as follows and display the result in minutes in the output textbox
                else if (seconds >= 60)
                {
                    int minutes = seconds / 60;
                    textBoxResult.Text = minutes + " minutes";
                }

                // If all the above condition fails, then the seconds is less than 60, simply display the seconds.
                else
                {
                    textBoxResult.Text = seconds + " seconds";
                }
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}