using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Program;

namespace Vehicle_Program
{
    public partial class Form1 : Form
    {

        //Vehicle Array
        Vehicle[] AllVehicles = new Vehicle[3];
        int cnt = 0;
        
       
        public Form1()
        {
           
            InitializeComponent();
        }


        
      
        //Insert Button
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cnt >= 3)
            {
                MessageBox.Show("You have insert the maximum number of vehicles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Add vehicle to listBox
            else
            {
                AllVehicles[cnt] = new Vehicle(txtManufacturer.Text, txtModel.Text, txtYear.Text, txtRegistration.Text);
                listBox1.Items.Add(AllVehicles[cnt].PrintToScreen2());
                cnt++;

            }
            //Clear all textboxes after clicking insert button
            txtManufacturer.Clear();
            txtModel.Clear();
            txtRegistration.Clear();
            txtYear.Clear();
        }












        //Travel Button
        private void btnTravel_Click(object sender, EventArgs e)
        {
            AllVehicles[listBox1.SelectedIndex].AddJourney((double)Convert.ToDouble(txtKilometres.Text));

            AllVehicles[listBox1.SelectedIndex].AddFuelPurchase((double)Convert.ToDouble(txtFuelQtyPurchase.Text), (double)Convert.ToDouble(txtFuelCost.Text));

            txtFuelCost.Clear();
            txtFuelQtyPurchase.Clear();
            txtKilometres.Clear();


        }

       













        //............

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (richTextBox1 != null)
            {
                richTextBox1.Clear();
            }

            richTextBox1.SelectedText = (AllVehicles[listBox1.SelectedIndex].PrintToScreen());

            //if require service is true then display message box
            if (AllVehicles[listBox1.SelectedIndex].requires_service == true)
            {
                DialogResult dialogResult = MessageBox.Show("This Vehicle need to be serviced!\n\n If this Vehicle has been serviced click Yes or Click No.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    AllVehicles[listBox1.SelectedIndex].requires_service = false;

                }
                else if (dialogResult == DialogResult.No)
                {
                    AllVehicles[listBox1.SelectedIndex].requires_service = true;
                }
            }
           
            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

       
    }
}
