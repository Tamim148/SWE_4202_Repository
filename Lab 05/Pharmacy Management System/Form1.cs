using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List <Medicine>meds = new List <Medicine> ();
        List <Medicine>bought_meds = new List <Medicine> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void stockMedButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            
           
                string medicineName = stockMedNameTextBox.Text;
                int medicineQty = Convert.ToInt32(stockMedQtyTextBox.Text);
                int medicineUnitPrice = Convert.ToInt32(stockMedUnitPriceTextBox.Text);

            foreach (Medicine med in meds)
            {
                if (med.medName == medicineName)
                { 
                    flag = true;
                    med.medQty = med.medQty + medicineQty;
                    med.setMedUnitPrice(medicineUnitPrice);
                    meds.Add(med);
                    MessageBox.Show("Medicine has been successfully added. Name: " + med.medName + " Quantity: " + med.medQty);
                    return;
                }
            }
            if (flag == false)
            {
                Medicine dumMed = new Medicine();
                dumMed.medName = medicineName;
                dumMed.medQty = medicineQty;
                dumMed.setMedUnitPrice(medicineUnitPrice);

                meds.Add(dumMed);
                int x = 0;
                if (x == 0)
                {
                    searchAvailablityBox.Items.Add(dumMed.medName);
                    x++;
                }
                int y = 0;
                if (y == 0)
                {
                    buyMedBox.Items.Add(dumMed.medName);
                    y++;
                }

                MessageBox.Show("Medicine has been successfully createded. Name: " + dumMed.medName + " Quantity: " + dumMed.medQty);
            }

            }

            private void buyMedButton_Click(object sender, EventArgs e)
        {
            string buyMedicineName = buyMedBox.Text;
            int buyMedicineQty = Convert.ToInt32(buyMedQtyTextBox.Text);
            int buyMedicineUnitPrice;
            int buyMedicineTotalPrice;
            bool flag = false;

            foreach (Medicine Med in meds)
            {
                if(Med.medName == buyMedicineName && Med.medQty>=buyMedicineQty)
                {
                    flag = true;
                    Med.medQty -= buyMedicineQty;
                    buyMedicineUnitPrice=Med.getMedUnitPrice();
                    buyMedicineTotalPrice = buyMedicineUnitPrice * buyMedicineQty;
                    MessageBox.Show("You have successfuly purchased " + buyMedicineName + " " + buyMedicineQty + " Units. Payable Amount: " + Convert.ToString(buyMedicineTotalPrice));
                    bool flag2 = false;
                    foreach(Medicine medi in bought_meds)
                    {
                        if(medi.medName == buyMedicineName)
                        {
                            flag2 = true;
                            medi.medUnitBought += buyMedicineQty;
                            return;
                        }
                    }
                    if (flag2 == false)
                    {
                        Med.medUnitBought += buyMedicineQty;
                        bought_meds.Add(Med);
                    }
                        return;
                }
                if (Med.medName == buyMedicineName && Med.medQty < buyMedicineQty)
                {
                    MessageBox.Show("Not enough Units in Stock.");
                    return;
                }
            }
            if(flag==false)
            {
                MessageBox.Show("Medicine is not Found in the System.");
            }


        }

        private void medAvailabilityButton_Click(object sender, EventArgs e)
        {
            string searchMedicineName = searchAvailablityBox.Text;
            string medInfo;
            medAvailabilityListBox.Items.Clear();
            bool flag = false;
            foreach (Medicine Med in meds)
            {
                if (searchMedicineName == Med.medName)
                {
                    flag = true;
                    medInfo = Med.medName + "\t" + Med.medQty + "\t" + Convert.ToString(Med.getMedUnitPrice());
                    medAvailabilityListBox.Items.Add(medInfo);
                    break;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Medicine is not found in the system.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBalance=0;
            foreach(Medicine Med in bought_meds)
            {
                totalBalance =totalBalance + (Med.getMedUnitPrice() * Med.medUnitBought);
            }
            MessageBox.Show("Balance: " + Convert.ToString(totalBalance));
        }
    }
}
