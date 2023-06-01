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
    public partial class operation_form : Form
    {
        public operation_form()
        {
            InitializeComponent();
            TB_date.Text = DateTime.Now.ToShortDateString();
            TB_date.Focus();

        }

        private void operation_form_Load(object sender, EventArgs e)
        {
        }

        private void operation_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                try
                {
                    if (CB_operation.SelectedIndex == -1)
                    {
                        CB_operation.Focus();
                        throw new Exception("не выбрана операция");
                    }

                    if (CB_people.SelectedIndex == -1)
                    {
                        CB_people.Focus();
                        throw new Exception("не выбран участник");
                    }

                    if (TB_money.Text == "")
                    {
                        TB_money.Focus();
                        throw new Exception("не введена сумма");
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "предупреждение");
                }

        }

        private void TB_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != ',')
            {
                e.Handled = true;
            }
        }
    }
}
