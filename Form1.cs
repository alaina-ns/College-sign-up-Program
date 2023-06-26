using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Programmer: Alaina Smith // Project: Smith_2 
// Due Date: 02/25/2022 
// Description: Individual Assignment #2 

namespace Smith_2
{
    public partial class Form1 : Form
    {
 

        // Declare class-level constants for later use in the program
        private const decimal IN_STATE_TUITION_PRICE = 49.00m;
        private const decimal OUT_OF_STATE_TUITION_PRICE = 99.00m;
        private const decimal STARTUP_BASE_PRICE = 0.00M;
        // Declare local variables
        string registrationTerm = "";
        string residenceStatus = "";
        string creditCardType = "";
        private int totalCourses; // Total amount of courses selected
        decimal pricePerCourse = 49.00m; // Total cost per course
        decimal totalOrderPrice; // Total cost for all courses purchased
        public Form1()
        {
            InitializeComponent();
        }

        // Execute when form loads at program start up
        private void Form1_Load(object sender, EventArgs e)
        {    //assign in state tuition to the language courses
            frenchPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            germanPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            italianPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            russianPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            spanishPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            totalCoursesLabel.Text = totalCourses.ToString();
            totalOrderPriceLabel.Text = STARTUP_BASE_PRICE.ToString("c");
        }
        // Fall Radio button changed event
        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {  // if else statement if the student picks fall or spring.
            if (fallRadioButton.Checked)
                registrationTerm = "Fall";
            else if (springRadioButton.Checked)
                registrationTerm = "Spring";
        }

        private void outStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {  // assigned out of state tution  to lang courses. Inside the handler
            pricePerCourse = OUT_OF_STATE_TUITION_PRICE;
            frenchPriceLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            germanPriceLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            italianPriceLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            russianPriceLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            spanishPriceLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            // Update display value on the form
            totalCoursesLabel.Text = totalCourses.ToString();

            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {// assigned in state tution  to lang courses. Inside the handler
            pricePerCourse = IN_STATE_TUITION_PRICE;
            frenchPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            germanPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            italianPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            russianPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            spanishPriceLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            totalCoursesLabel.Text = totalCourses.ToString();
            totalOrderPriceLabel.Text = STARTUP_BASE_PRICE.ToString("c");
            // Update display value on the form
            totalCoursesLabel.Text = totalCourses.ToString();

            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        // Created event handlers for each language
        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Simple if else logic expression
            if (italianCheckBox.Checked)
            { // Add 1 if selected
                totalCourses += 1;
 
            }
            else
            { //subtract 1 if unselected
                totalCourses -= 1;
            }
            // Update display value on the form 
            totalCoursesLabel.Text = totalCourses.ToString();
            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        // Created event handlers for each language
        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Simple if else logic expression
            if (germanCheckBox.Checked)
            {
                totalCourses += 1;
            }
            else
            {
                totalCourses -= 1;
            }
            // Update display value on the form 
            totalCoursesLabel.Text = totalCourses.ToString();
            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        // Created event handlers for each language
        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Simple if else logic expression
            if (russianCheckBox.Checked)
            {
                totalCourses += 1;
            }
            else
            {
                totalCourses -= 1;
            }

            // Update display value on the form 
            totalCoursesLabel.Text = totalCourses.ToString();
            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        // Created event handlers for each language
        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            // Simple if else logic expression
            if (spanishCheckBox.Checked)
            {
                totalCourses += 1;
            }
            else
            {
                totalCourses -= 1;
            }

            // Update display value on the form 
            totalCoursesLabel.Text = totalCourses.ToString();
            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();
        }
        // Execute whenever a check box is selected or deselected
        // Event handler is shared with the other four check boxes
        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            // Simple if else logic expression
            if (frenchCheckBox.Checked)
            {
                totalCourses += 1;
            }
            else
            {
                totalCourses -= 1;
            }

            // Update display value on the form 
            totalCoursesLabel.Text = totalCourses.ToString();
            // Update display value for total price
            totalOrderPrice = totalCourses * pricePerCourse;
            totalOrderPriceLabel.Text = totalOrderPrice.ToString();

        }
        // if else same with fall/spring term 
        private void visaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (visaRadioButton.Checked)
                creditCardType = "Visa";
            else if (mastercardRadioButton.Checked)
                creditCardType = "Mastercard";
        }

        // Simulated saved information displayed in Message box
        private void saveButton_Click(object sender, EventArgs e)
        {            // Statement saying courses can only be 1,2,3 and not higher than 4
            if (totalCourses > 0 && totalCourses <= 3)
            { // Displays "Order summary of what the student selected
                MessageBox.Show("Order Summary\n\n" +
                       "Term: " + registrationTerm + " " + yearComboBox.Text + "\n" +
                       "Student ID: " + studentIDMaskedTextBox.Text + "\n" +
                       "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text
                        + "\n" +
                       "Email: " + emailTextBox.Text + "\n" +
                       "Residence Status: " + residenceStatus + "\n" +
                       "Total Courses Purchased: " + totalCoursesLabel.Text + "\n" +
                       "Price per Course: " + pricePerCourse + "\n" +
                       "Total Order Price: " + totalOrderPriceLabel.Text + "\n" +
                        "Credit Card Type: " + creditCardType + "\n" +
                       "Card Number: " + creditCardMaskedTextBox.Text + "\n" +
                       "Credit Card Expiration Date: " + ExpirationMaskedTextBox.Text
                         + "\n",
                       "LAI Order Form", MessageBoxButtons.OK,
             MessageBoxIcon.Information);
            }
            else
            { // If student selected more than 4 courses or 0 this pop will appear
                MessageBox.Show("Course order must contain at least one course but no more than three courses",
                "Order form error", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }
        // Clear data entry controls and reset form to initial set up
        private void clearButton_Click(object sender, EventArgs e)
        {
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            mastercardRadioButton.Checked = true;
            creditCardMaskedTextBox.Text = "";
            ExpirationMaskedTextBox.Text = "";
            totalCoursesLabel.Text = totalCourses.ToString();
            totalOrderPriceLabel.Text = STARTUP_BASE_PRICE.ToString("c");
            // Send focus to first data entry control on form
            fallRadioButton.Focus();
        }
        // event handler for exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Declare variable to hold user selection in dialog box
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take appropriate action based on user selection in dialog box
            if (selection == DialogResult.Yes)
            {
                // Close the form (ending the program)
                this.Close();
            }
        }


    }
}
