using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//using System.Design;
using System.Windows.Forms.Design;
using EgoldsUI;
using yt_DesignUI;
using Money_Manager.forms;
using System.IO;

namespace Money_Manager
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            Animator.Start();
            CB_vid.SelectedIndex = 0;
            DGV_operation.ClearSelection();
            load_data();
            lock_button(false);
            update();
        }

        async private void update()
        {
            update_data();
            await Task.Delay(1);
            vclad_money.Focus();
            clear_money.Focus();
            all_money.Focus();
        }

        public void load_data()
        {
            string name_file_people = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerPeople";

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(name_file_people, FileMode.Open)))
                {
                    try
                    {
                        DGV_people.RowCount = file.ReadInt32();

                        for (int i = 0; i < DGV_people.RowCount; i++)
                            for (int j = 0; j < DGV_people.ColumnCount - 2; j++)
                                DGV_people[j, i].Value = file.ReadString();
                    }
                    catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка");*/ }
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(name_file_people)))
                {
                }
            }

            string name_file_operation = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerOperation";

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(name_file_operation, FileMode.Open)))
                {
                    try
                    {
                        DGV_operation.RowCount = file.ReadInt32();

                        for (int i = 0; i < DGV_operation.RowCount; i++)
                            for (int j = 0; j < DGV_operation.ColumnCount; j++)
                                DGV_operation[j, i].Value = file.ReadString();
                    }
                    catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка");*/ }
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(name_file_operation))) {}
            }

            string name_file_logs = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerLogs";

            try
            {
                using (BinaryReader file = new BinaryReader(File.Open(name_file_logs, FileMode.Open)))
                {
                    try
                    {
                        DGV_logs.RowCount = file.ReadInt32();

                        for (int i = 0; i < DGV_logs.RowCount; i++)
                            for (int j = 0; j < DGV_logs.ColumnCount; j++)
                                DGV_logs[j, i].Value = file.ReadString();
                    }
                    catch (Exception E) { /*MessageBox.Show(E.Message, "ошибка");*/ }
                }
            }
            catch
            {
                using (BinaryReader file = new BinaryReader(File.Create(name_file_logs))) {}
            }

            update_logs("load_data");
        }

        public void save_data()
        {
            string name_file_people = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerPeople";

            using (BinaryWriter file = new BinaryWriter(File.Open(name_file_people, FileMode.Create)))
            {
                try
                {
                    file.Write(DGV_people.RowCount);

                    for (int i = 0; i < DGV_people.RowCount; i++)
                        for (int j = 0; j < DGV_people.ColumnCount - 2; j++)
                            file.Write(Convert.ToString(DGV_people[j, i].Value));
                }
                catch (Exception E) { MessageBox.Show(E.Message, "ошибка"); }
            }

            string name_file_operation = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerOperation";

            using (BinaryWriter file = new BinaryWriter(File.Open(name_file_operation, FileMode.Create)))
            {
                try
                {
                    file.Write(DGV_operation.RowCount);

                    for (int i = 0; i < DGV_operation.RowCount; i++)
                        for (int j = 0; j < DGV_operation.ColumnCount; j++)
                            file.Write(Convert.ToString(DGV_operation[j, i].Value));
                }
                catch (Exception E) { MessageBox.Show(E.Message, "ошибка"); }
            }

            string name_file_logs = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Money Manager\MoneyManagerLogs";

            using (BinaryWriter file = new BinaryWriter(File.Open(name_file_logs, FileMode.Create)))
            {
                try
                {
                    file.Write(DGV_logs.RowCount);

                    for (int i = 0; i < DGV_logs.RowCount; i++)
                        for (int j = 0; j < DGV_logs.ColumnCount; j++)
                            file.Write(Convert.ToString(DGV_logs[j, i].Value));
                }
                catch (Exception E) { MessageBox.Show(E.Message, "ошибка"); }
            }


            update_logs("save_data");
        }
        private void add_operation_Click(object sender, EventArgs e)
        {
            operation_form form = new operation_form();
            form.Text = "Добавление операции";

            for (int i = 0; i < DGV_people.RowCount; i++)
                form.CB_people.Items.Add(DGV_people[0, i].Value);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                DGV_operation.RowCount++;

                //сдвиг всех строк вниз на 1
                if (DGV_operation.RowCount > 1)
                    for (int j = DGV_operation.RowCount - 1; j >= 1; j--)
                        for (int c = 0; c < DGV_operation.ColumnCount; c++)
                            DGV_operation[c, j].Value = DGV_operation[c, j - 1].Value;

                DGV_operation[0, 0].Value = form.CB_operation.SelectedItem;
                DGV_operation[1, 0].Value = form.CB_people.SelectedItem;
                DGV_operation[2, 0].Value = form.TB_date.Text;
                DGV_operation[3, 0].Value = form.TB_money.Text;
                DGV_operation[4, 0].Value = form.TB_comm.Text;

                update_data();
                update_logs("add_operation");
                save_data();
            }

        }

        int global_index_operation = -1;
        int global_index_people = -1;
        private void change_operation_Click(object sender, EventArgs e)
        {
            operation_form form = new operation_form();
            form.Text = "Изменение операции";

            for (int i = 0; i < DGV_people.RowCount; i++)
                form.CB_people.Items.Add(DGV_people[0, i].Value);

            form.CB_operation.SelectedItem = Convert.ToString(DGV_operation[0, global_index_operation].Value);
            form.CB_people.SelectedItem = Convert.ToString(DGV_operation[1, global_index_operation].Value);
            form.TB_date.Text = Convert.ToString(DGV_operation[2, global_index_operation].Value);
            form.TB_money.Text = Convert.ToString(DGV_operation[3, global_index_operation].Value);
            form.TB_comm.Text = Convert.ToString(DGV_operation[4, global_index_operation].Value);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                DGV_operation[0, global_index_operation].Value = form.CB_operation.SelectedItem;
                DGV_operation[1, global_index_operation].Value = form.CB_people.SelectedItem;
                DGV_operation[2, global_index_operation].Value = form.TB_date.Text;
                DGV_operation[3, global_index_operation].Value = form.TB_money.Text;
                DGV_operation[4, global_index_operation].Value = form.TB_comm.Text;

                update_data();
                update_logs("change_operation");
                save_data();
            }
        }

        private void add_people_Click(object sender, EventArgs e)
        {
            people_form form = new people_form();
            form.Text = "Добавление участника";

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                DGV_people.RowCount++;

                //сдвиг всех строк вниз на 1
                if (DGV_people.RowCount > 1)
                    for (int j = DGV_people.RowCount - 1; j >= 1; j--)
                        for (int c = 0; c < DGV_people.ColumnCount; c++)
                            DGV_people[c, j].Value = DGV_people[c, j - 1].Value;

                DGV_people[0, 0].Value = form.TB_fio.Text + " " + form.TB_name.Text + " " + form.TB_otchestvo.Text;
                DGV_people[1, 0].Value = form.TB_date.Text;
                update_data();
                update_logs("add_people");
                DGV_operation.ClearSelection();
                save_data();
            }
        }

        private void update_logs(string value)
        {
            DGV_logs.RowCount++;

            //сдвиг всех строк вниз на 1
            if (DGV_logs.RowCount > 1)
                for (int j = DGV_logs.RowCount - 1; j >= 1; j--)
                    for (int c = 0; c < DGV_logs.ColumnCount; c++)
                        DGV_logs[c, j].Value = DGV_logs[c, j - 1].Value;

            string status = null;

            switch (value)
            {
                case "add_operation":
                    status = "Добавление операции: "+ DGV_operation[0,0].Value + " (" + DGV_operation[3, 0].Value + ")" + "; "+ DGV_operation[1, 0].Value; 
                    break;
                case "change_operation":
                    status = "Изменение операции: " + DGV_operation[0, 0].Value + " (" + DGV_operation[3, 0].Value + ")" + "; " + DGV_operation[2, 0].Value + "; " + DGV_operation[1, 0].Value;
                    break;
                case "delete_operation":
                    status = "Удаление операции: " + DGV_operation[0, 0].Value + " (" + DGV_operation[3, 0].Value + ")" + "; " + DGV_operation[1, 0].Value ; 
                    break;
                case "delete_all_operation":
                    status = "Удаление всех операций";
                    break;
                case "add_people":
                    status = "Добавление участника: " + DGV_people[0,0].Value;
                    break;
                case "delete_people":
                    status = "Исключение участника: " + DGV_people[0, global_index_people].Value;
                    break;
                case "load_data":
                    status = "Запуск приложения: загрузка информации";
                    break;
                case "save_data":
                    status = "Сохранение информации";
                    break;
                case "clear_logs":
                    status = "Очистка старых логов: очищено 85% старых логов";
                    break;
                default:
                    status = "Непредвиденная процедура";
                    break;
            }

            DGV_logs[0, 0].Value = DateTime.Now;
            DGV_logs[1, 0].Value = status;

            if (DGV_logs.RowCount >= 3000)
            {
                while (DGV_logs.RowCount >= 500)
                    DGV_logs.Rows.RemoveAt(DGV_logs.RowCount-1);
                update_logs("clear_logs");
            }

        }
        private void update_data()
        {
            double sum = 0;

            //индивидуальный вклад
            for (int i = 0; i < DGV_people.RowCount; i++)
            {
                for (int j = 0; j < DGV_operation.RowCount; j++)
                    if (Convert.ToString(DGV_people[0, i].Value) == Convert.ToString(DGV_operation[1, j].Value) && Convert.ToString(DGV_operation[0, j].Value) == "зачисление")
                        sum += Convert.ToDouble(DGV_operation[3, j].Value);
                    else
                        if (Convert.ToString(DGV_people[0, i].Value) == Convert.ToString(DGV_operation[1, j].Value) && Convert.ToString(DGV_operation[0, j].Value) == "списание")
                        sum -= Convert.ToDouble(DGV_operation[3, j].Value);

                DGV_people[2, i].Value = Convert.ToString(sum);
                sum = 0;
            }

            //общее кол-во средств
            double all_sum = 0;
            for (int i = 0; i < DGV_operation.RowCount; i++)
                if (Convert.ToString(DGV_operation[0, i].Value) == "зачисление" || Convert.ToString(DGV_operation[0, i].Value) == "вклад (%)")
                    all_sum += Convert.ToDouble(DGV_operation[3, i].Value);
                else
                    all_sum -= Convert.ToDouble(DGV_operation[3, i].Value);

            all_money.Text = Convert.ToString(all_sum);

            //кол-во внесенных средств
            double vnes_sum = 0;
            for (int i = 0; i < DGV_operation.RowCount; i++)
                if (Convert.ToString(DGV_operation[0, i].Value) == "зачисление")
                    vnes_sum += Convert.ToDouble(DGV_operation[3, i].Value);

            clear_money.Text = Convert.ToString(vnes_sum);

            //расчет % от всех средств
            for (int i = 0; i < DGV_people.RowCount; i++)
                DGV_people[3, i].Value = Math.Round(Convert.ToDouble(DGV_people[2, i].Value) / vnes_sum * 100.0, 2);

            //кол-во средств от вклада
            double vclad_sum = 0;
            for (int i = 0; i < DGV_operation.RowCount; i++)
                if (Convert.ToString(DGV_operation[0, i].Value) == "вклад (%)")
                    vclad_sum += Convert.ToDouble(DGV_operation[3, i].Value);

            vclad_money.Text = Convert.ToString(vclad_sum);

            //построение графиков
            chart1.Series[0].Points.Clear();
            switch (CB_vid.SelectedIndex)
            {
                case 1: //анализ средств (диаграмма)
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    double pol_sum = 0;
                    double otr_sum = 0;

                    for (int i = 0; i < DGV_people.RowCount; i++)
                        if (Convert.ToDouble(DGV_people[2, i].Value) >= 0)
                            pol_sum += Convert.ToDouble(DGV_people[2, i].Value);
                        else
                            otr_sum += Convert.ToDouble(DGV_people[2, i].Value);

                    //chart1.Series[0].LegendText = "";
                    if (((pol_sum + vclad_sum) + otr_sum) >= 0)
                        chart1.Series[0].Points.AddXY("имеющиеся средства (" + ((pol_sum + vclad_sum) + otr_sum) + ")", ((pol_sum + vclad_sum) + otr_sum));
                    if (otr_sum < 0)
                        chart1.Series[0].Points.AddXY("отсутствующие средства (" + otr_sum + ")", otr_sum);

                    break;
                case 2: //тенденции средств (плоскость)
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    int c = DGV_operation.RowCount - 1;
                    double chart_sum = 0;
                    //string[] diapazon = new string[DGV_operation.RowCount];
                    //int k = 0;

                    for (int i = DGV_operation.RowCount - 1; i >= 0;)
                        while (true)
                        {
                            if (c > 0 && Convert.ToString(DGV_operation[2, c].Value) == Convert.ToString(DGV_operation[2, c - 1].Value))
                            {
                                if (Convert.ToString(DGV_operation[0, i].Value) == "списание")
                                    chart_sum -= Convert.ToDouble(DGV_operation[3, i].Value);
                                else
                                    chart_sum += Convert.ToDouble(DGV_operation[3, i].Value);
                            }
                            else
                            {
                                if (Convert.ToString(DGV_operation[0, i].Value) == "списание")
                                    chart_sum -= Convert.ToDouble(DGV_operation[3, c].Value);
                                else
                                    chart_sum += Convert.ToDouble(DGV_operation[3, c].Value);
                                //if (c > 0)
                                //diapazon[k] = Convert.ToString(DGV_operation[2, c].Value);
                                chart1.Series[0].Points.AddXY(DGV_operation[2, i].Value, chart_sum);
                                c--;
                               // k++;
                                i = c;
                                break;
                            }
                            c--;
                        }



                    break;
                case 3: //сопоставление участников (столбики)
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;

                    string[] array_name;
                    for (int i = 0; i < DGV_people.RowCount; i++)
                    {
                        array_name = Convert.ToString(DGV_people[0, i].Value).Split(' ');
                        chart1.Series[0].Points.AddXY(array_name[1], DGV_people[2, i].Value);
                    }
                        break;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_data();
            lock_button(false);
            DGV_people.ClearSelection();
            DGV_operation.ClearSelection();
            DGV_logs.ClearSelection();
        }

        private void lock_button(bool flag)
        {
            if (!flag)
            {
                change_operation.Enabled = false;
                delete_operation.Enabled = false;
                change_operation.BackColor = Color.Salmon;
                delete_operation.BackColor = Color.Salmon;

                delete_people.Enabled = false;
                information.Enabled = false;
                delete_people.BackColor = Color.Salmon;
                information.BackColor = Color.Salmon;
            }
            else
            {
                change_operation.Enabled = true;
                delete_operation.Enabled = true;
                change_operation.BackColor = Color.Tomato;
                delete_operation.BackColor = Color.Tomato;

                delete_people.Enabled = true;
                information.Enabled = true;
                delete_people.BackColor = Color.Tomato;
                information.BackColor = Color.Tomato;
            }
        }
        private void delete_operation_Click(object sender, EventArgs e)
        {
            if ((DGV_operation.CurrentRow != null) && (MessageBox.Show("удалить безвозвратно операцию \"" + DGV_operation[0, DGV_operation.CurrentRow.Index].Value + " " + DGV_operation[1, DGV_operation.CurrentRow.Index].Value + "\"?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                update_logs("delete_operation");
                DGV_operation.Rows.RemoveAt(DGV_operation.CurrentRow.Index);
                DGV_operation.ClearSelection();
                lock_button(false);
                update_data();
                save_data();
            }
        }
        private void delete_all_operation_Click(object sender, EventArgs e)
        {
            if ((DGV_operation.CurrentRow != null) && (MessageBox.Show("удалить безвозвратно ВСЕ операции? ", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                update_logs("delete_all_operation");
                while (DGV_operation.RowCount > 0)
                    DGV_operation.Rows.RemoveAt(0);
                DGV_operation.ClearSelection();
                lock_button(false);
                update_data();
                save_data();
            }
        }

        private void delete_people_Click(object sender, EventArgs e)
        {
            if ((DGV_people.CurrentRow != null) && (MessageBox.Show("удалить безвозвратно участника \"" + DGV_people[0, DGV_people.CurrentRow.Index].Value + "\"?", "предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                update_logs("delete_people");
                DGV_people.Rows.RemoveAt(DGV_people.CurrentRow.Index);
                DGV_people.ClearSelection();
                lock_button(false);
                update_data();
                save_data();
            }
        }

        private void DGV_operation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DGV_operation.Rows[e.RowIndex].Selected = true;
                global_index_operation = e.RowIndex;
            }
            catch { }
            lock_button(true);
        }

        private void DGV_people_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            { 
                DGV_people.Rows[e.RowIndex].Selected = true;
                global_index_people = e.RowIndex;
            } 
            catch { }
            lock_button(true);
        }
        private void DGV_logs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DGV_logs.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void CB_vid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_vid.SelectedIndex == 0)
            {
                DGV_operation.Visible = true;
                chart1.Visible = false;
            }
            else
            {
                chart1.Visible = true;
                DGV_operation.Visible = false;
            }

            if (CB_vid.SelectedIndex == 2)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }

            DGV_operation.ClearSelection();
            lock_button(false);
            update_data();
        }

    }
}