using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string name;
        public double salary; //Public variable declaration
        public string option;

        private void btnCheckApplication_Click(object sender, EventArgs e)
        {
            name = tbName.Text; //Variable initialisation
            if (double.TryParse(tbSalary.Text, out salary)) //Ensuring valid user input
            {
                if (rbUSB.Checked == false && rbLTE.Checked == false && rbFibre.Checked == false) //Ensuring that a radio burrin is checked
                {
                    MessageBox.Show("Please select an internet option");
                }
                else
                {
                    Form2 form = new Form2(); //Creating form
                    form.Show(); //Showing second form
                    if (salary > 2500)//Determining if the application is valid
                    {
                        form.lblAproval.Text = "Application is approved";
                        if (rbFibre.Checked)
                        {
                            option = "Fibre"; //Assinging internet option to "option" variable 
                        }
                        else if (rbLTE.Checked)
                        {
                            option = "LTE/ Wifi";
                        }
                        else
                        {
                            option = "USB Dongle";
                        }
                        form.lboxOutput.Items.Add("Thank you for applying " + name + ". Your " + option + " option application is approved"); //Displaying output in listbox
                    }
                    else
                    {
                        form.lblAproval.Text = "Application is not approved";//Case if salaray is not more than 2500
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid salaray");//Case if user does not enter a valid salary
            }
        }
    }
}
