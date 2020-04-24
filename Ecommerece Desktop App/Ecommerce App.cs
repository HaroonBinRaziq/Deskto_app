using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerece_Desktop_App
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

        private void Select_Item_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length>0)
            {
                txt_blnc.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txt_dis.Text.Length>0)
            {
                txt_net.Text= (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_dis.Text)).ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Pharmacy Item 1");
            cmb_items.Items.Add("Pharmacy Item 2");
            cmb_items.Items.Add("Pharmacy Item 3");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("General Item 1");
            cmb_items.Items.Add("General Item 2");
            cmb_items.Items.Add("General Item 3");
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString()=="Pharmacy Item 1")
            { txt_price.Text = "50"; }
            else if(cmb_items.SelectedItem.ToString()=="Pharmacy Item 2")
                { txt_price.Text = "100"; }
            else if(cmb_items.SelectedItem.ToString() == "Pharmacy Item 3")
                { txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "General Item 1")
                { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "General Item 2")
                { txt_price.Text = "250"; }
            else if (cmb_items.SelectedItem.ToString() == "General Item 3")
                { txt_price.Text = "300"; }
            else
                { txt_price.Text = "0"; }

            txt_total.Text = "";
            txt_qty.Text = ""; 
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lv1 = new ListViewItem(arr);
            listView1.Items.Add(lv1);

           txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }
    }
}
