using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Manager.forms
{
    public partial class people_form : Form
    {
        public people_form()
        {
            InitializeComponent();
            TB_date.Text = DateTime.Now.ToShortDateString();
            TB_date.Focus();
        }

        private void people_form_Load(object sender, EventArgs e)
        {
            //TB_date.Focus();
        }

        private void people_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                try
                {
                    if (TB_fio.Text == "")
                    {
                        TB_fio.Focus();
                        throw new Exception("не введена фамилия");
                    }

                    if (TB_name.Text == "")
                    {
                        TB_name.Focus();
                        throw new Exception("не введено имя");
                    }

                    if (TB_otchestvo.Text == "")
                    {
                        TB_otchestvo.Focus();
                        throw new Exception("не введено отчество");
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "предупреждение");
                }
        }
    }
}
