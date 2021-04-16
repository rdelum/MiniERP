using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class WM_ConfigureSqlLogin : Form
    {
        public WM_ConfigureSqlLogin()
        {
            InitializeComponent();
        }

        private void button_loginToConfigureSQL_Click(object sender, EventArgs e)
        {
            if (textBox_PASStoConfigureSQL.Text == "123")
            {
                ConfigureDataBase configureDataBase = new ConfigureDataBase();
                configureDataBase.Show();
                    
            }
            else
            {
                MessageBox.Show("the password you entered is incorrect");
            }
        }
    }
}
