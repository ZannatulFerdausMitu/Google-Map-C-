using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Search_data_Click(object sender, EventArgs e)
        {
            
             string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps?q=");
               
                


                 if (street != string.Empty)
                {
                    queryaddress.Append(street + "," + "+");
                }

                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }

                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }

                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Unable to get map");
            }

        }
    }
}
