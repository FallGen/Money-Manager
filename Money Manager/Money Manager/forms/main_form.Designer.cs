namespace Money_Manager
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.money = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_vid = new System.Windows.Forms.ComboBox();
            this.DGV_operation = new System.Windows.Forms.DataGridView();
            this.people = new System.Windows.Forms.TabPage();
            this.DGV_people = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_money = new yt_DesignUI.EgoldsGoogleTextBox();
            this.delete_all_operation = new yt_DesignUI.yt_Button();
            this.delete_operation = new yt_DesignUI.yt_Button();
            this.change_operation = new yt_DesignUI.yt_Button();
            this.add_operation = new yt_DesignUI.yt_Button();
            this.information = new yt_DesignUI.yt_Button();
            this.delete_people = new yt_DesignUI.yt_Button();
            this.add_people = new yt_DesignUI.yt_Button();
            this.all_money = new yt_DesignUI.EgoldsGoogleTextBox();
            this.vclad_money = new yt_DesignUI.EgoldsGoogleTextBox();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.TabPage();
            this.DGV_logs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_operation)).BeginInit();
            this.people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_people)).BeginInit();
            this.logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.money);
            this.tabControl1.Controls.Add(this.people);
            this.tabControl1.Controls.Add(this.logs);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 391);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.White;
            this.money.Controls.Add(this.label4);
            this.money.Controls.Add(this.label3);
            this.money.Controls.Add(this.label1);
            this.money.Controls.Add(this.comboBox2);
            this.money.Controls.Add(this.comboBox1);
            this.money.Controls.Add(this.delete_all_operation);
            this.money.Controls.Add(this.chart1);
            this.money.Controls.Add(this.label2);
            this.money.Controls.Add(this.CB_vid);
            this.money.Controls.Add(this.DGV_operation);
            this.money.Controls.Add(this.delete_operation);
            this.money.Controls.Add(this.change_operation);
            this.money.Controls.Add(this.add_operation);
            this.money.Location = new System.Drawing.Point(4, 26);
            this.money.Name = "money";
            this.money.Padding = new System.Windows.Forms.Padding(3);
            this.money.Size = new System.Drawing.Size(860, 361);
            this.money.TabIndex = 0;
            this.money.Text = "Средства";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(144, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(710, 318);
            this.chart1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(459, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "демонстрация данных";
            // 
            // CB_vid
            // 
            this.CB_vid.Font = new System.Drawing.Font("Arial", 11.25F);
            this.CB_vid.FormattingEnabled = true;
            this.CB_vid.Items.AddRange(new object[] {
            "история операций",
            "анализ средств",
            "тенденция средств",
            "сопоставление участников"});
            this.CB_vid.Location = new System.Drawing.Point(627, 330);
            this.CB_vid.Name = "CB_vid";
            this.CB_vid.Size = new System.Drawing.Size(227, 25);
            this.CB_vid.TabIndex = 8;
            this.CB_vid.SelectedIndexChanged += new System.EventHandler(this.CB_vid_SelectedIndexChanged);
            // 
            // DGV_operation
            // 
            this.DGV_operation.AllowUserToAddRows = false;
            this.DGV_operation.AllowUserToDeleteRows = false;
            this.DGV_operation.AllowUserToResizeColumns = false;
            this.DGV_operation.AllowUserToResizeRows = false;
            this.DGV_operation.BackgroundColor = System.Drawing.Color.White;
            this.DGV_operation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_operation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_operation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_operation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_operation.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_operation.GridColor = System.Drawing.Color.White;
            this.DGV_operation.Location = new System.Drawing.Point(146, 6);
            this.DGV_operation.Name = "DGV_operation";
            this.DGV_operation.ReadOnly = true;
            this.DGV_operation.RowHeadersVisible = false;
            this.DGV_operation.Size = new System.Drawing.Size(708, 318);
            this.DGV_operation.TabIndex = 3;
            this.DGV_operation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_operation_CellMouseClick);
            // 
            // people
            // 
            this.people.BackColor = System.Drawing.Color.White;
            this.people.Controls.Add(this.DGV_people);
            this.people.Controls.Add(this.information);
            this.people.Controls.Add(this.delete_people);
            this.people.Controls.Add(this.add_people);
            this.people.Location = new System.Drawing.Point(4, 26);
            this.people.Name = "people";
            this.people.Padding = new System.Windows.Forms.Padding(3);
            this.people.Size = new System.Drawing.Size(860, 361);
            this.people.TabIndex = 1;
            this.people.Text = "Участники";
            // 
            // DGV_people
            // 
            this.DGV_people.AllowUserToAddRows = false;
            this.DGV_people.AllowUserToDeleteRows = false;
            this.DGV_people.AllowUserToResizeColumns = false;
            this.DGV_people.AllowUserToResizeRows = false;
            this.DGV_people.BackgroundColor = System.Drawing.Color.White;
            this.DGV_people.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_people.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_people.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_people.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_people.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_people.GridColor = System.Drawing.Color.White;
            this.DGV_people.Location = new System.Drawing.Point(146, 6);
            this.DGV_people.Name = "DGV_people";
            this.DGV_people.ReadOnly = true;
            this.DGV_people.RowHeadersVisible = false;
            this.DGV_people.Size = new System.Drawing.Size(708, 349);
            this.DGV_people.TabIndex = 0;
            this.DGV_people.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_people_CellMouseClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Участник";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Дата добавление";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Общий вклад";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "% вклада";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clear_money
            // 
            this.clear_money.BackColor = System.Drawing.Color.White;
            this.clear_money.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.clear_money.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.clear_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clear_money.Font = new System.Drawing.Font("Arial", 11.25F);
            this.clear_money.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.clear_money.ForeColor = System.Drawing.Color.Black;
            this.clear_money.Location = new System.Drawing.Point(291, 398);
            this.clear_money.Name = "clear_money";
            this.clear_money.Size = new System.Drawing.Size(272, 40);
            this.clear_money.TabIndex = 7;
            this.clear_money.TextInput = "";
            this.clear_money.TextPreview = "внесенное количество средств";
            this.clear_money.UseSystemPasswordChar = false;
            // 
            // delete_all_operation
            // 
            this.delete_all_operation.BackColor = System.Drawing.Color.Tomato;
            this.delete_all_operation.BackColorAdditional = System.Drawing.Color.Gray;
            this.delete_all_operation.BackColorGradientEnabled = false;
            this.delete_all_operation.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.delete_all_operation.BorderColor = System.Drawing.Color.Tomato;
            this.delete_all_operation.BorderColorEnabled = false;
            this.delete_all_operation.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.delete_all_operation.BorderColorOnHoverEnabled = false;
            this.delete_all_operation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_all_operation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.delete_all_operation.ForeColor = System.Drawing.Color.White;
            this.delete_all_operation.Location = new System.Drawing.Point(6, 325);
            this.delete_all_operation.Name = "delete_all_operation";
            this.delete_all_operation.RippleColor = System.Drawing.Color.Black;
            this.delete_all_operation.RoundingEnable = false;
            this.delete_all_operation.Size = new System.Drawing.Size(132, 30);
            this.delete_all_operation.TabIndex = 11;
            this.delete_all_operation.Text = "Удалить все операции";
            this.delete_all_operation.TextHover = null;
            this.delete_all_operation.UseDownPressEffectOnClick = false;
            this.delete_all_operation.UseRippleEffect = true;
            this.delete_all_operation.UseZoomEffectOnHover = false;
            this.delete_all_operation.Click += new System.EventHandler(this.delete_all_operation_Click);
            // 
            // delete_operation
            // 
            this.delete_operation.BackColor = System.Drawing.Color.Tomato;
            this.delete_operation.BackColorAdditional = System.Drawing.Color.Gray;
            this.delete_operation.BackColorGradientEnabled = false;
            this.delete_operation.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.delete_operation.BorderColor = System.Drawing.Color.Tomato;
            this.delete_operation.BorderColorEnabled = false;
            this.delete_operation.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.delete_operation.BorderColorOnHoverEnabled = false;
            this.delete_operation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_operation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.delete_operation.ForeColor = System.Drawing.Color.White;
            this.delete_operation.Location = new System.Drawing.Point(6, 78);
            this.delete_operation.Name = "delete_operation";
            this.delete_operation.RippleColor = System.Drawing.Color.Black;
            this.delete_operation.RoundingEnable = false;
            this.delete_operation.Size = new System.Drawing.Size(132, 30);
            this.delete_operation.TabIndex = 2;
            this.delete_operation.Text = "Удалить операцию";
            this.delete_operation.TextHover = null;
            this.delete_operation.UseDownPressEffectOnClick = false;
            this.delete_operation.UseRippleEffect = true;
            this.delete_operation.UseZoomEffectOnHover = false;
            this.delete_operation.Click += new System.EventHandler(this.delete_operation_Click);
            // 
            // change_operation
            // 
            this.change_operation.BackColor = System.Drawing.Color.Tomato;
            this.change_operation.BackColorAdditional = System.Drawing.Color.Gray;
            this.change_operation.BackColorGradientEnabled = false;
            this.change_operation.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.change_operation.BorderColor = System.Drawing.Color.Tomato;
            this.change_operation.BorderColorEnabled = false;
            this.change_operation.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.change_operation.BorderColorOnHoverEnabled = false;
            this.change_operation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_operation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.change_operation.ForeColor = System.Drawing.Color.White;
            this.change_operation.Location = new System.Drawing.Point(6, 42);
            this.change_operation.Name = "change_operation";
            this.change_operation.RippleColor = System.Drawing.Color.Black;
            this.change_operation.RoundingEnable = false;
            this.change_operation.Size = new System.Drawing.Size(132, 30);
            this.change_operation.TabIndex = 1;
            this.change_operation.Text = "Внести изменение";
            this.change_operation.TextHover = null;
            this.change_operation.UseDownPressEffectOnClick = false;
            this.change_operation.UseRippleEffect = true;
            this.change_operation.UseZoomEffectOnHover = false;
            this.change_operation.Click += new System.EventHandler(this.change_operation_Click);
            // 
            // add_operation
            // 
            this.add_operation.BackColor = System.Drawing.Color.Tomato;
            this.add_operation.BackColorAdditional = System.Drawing.Color.Gray;
            this.add_operation.BackColorGradientEnabled = false;
            this.add_operation.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.add_operation.BorderColor = System.Drawing.Color.Tomato;
            this.add_operation.BorderColorEnabled = false;
            this.add_operation.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.add_operation.BorderColorOnHoverEnabled = false;
            this.add_operation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_operation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.add_operation.ForeColor = System.Drawing.Color.White;
            this.add_operation.Location = new System.Drawing.Point(6, 6);
            this.add_operation.Name = "add_operation";
            this.add_operation.RippleColor = System.Drawing.Color.Black;
            this.add_operation.RoundingEnable = false;
            this.add_operation.Size = new System.Drawing.Size(132, 30);
            this.add_operation.TabIndex = 0;
            this.add_operation.Text = "Добавить операцию";
            this.add_operation.TextHover = null;
            this.add_operation.UseDownPressEffectOnClick = false;
            this.add_operation.UseRippleEffect = true;
            this.add_operation.UseZoomEffectOnHover = false;
            this.add_operation.Click += new System.EventHandler(this.add_operation_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Tomato;
            this.information.BackColorAdditional = System.Drawing.Color.Gray;
            this.information.BackColorGradientEnabled = false;
            this.information.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.information.BorderColor = System.Drawing.Color.Tomato;
            this.information.BorderColorEnabled = false;
            this.information.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.information.BorderColorOnHoverEnabled = false;
            this.information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.information.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.information.ForeColor = System.Drawing.Color.White;
            this.information.Location = new System.Drawing.Point(6, 78);
            this.information.Name = "information";
            this.information.RippleColor = System.Drawing.Color.Black;
            this.information.RoundingEnable = false;
            this.information.Size = new System.Drawing.Size(132, 30);
            this.information.TabIndex = 3;
            this.information.Text = "Информация";
            this.information.TextHover = null;
            this.information.UseDownPressEffectOnClick = false;
            this.information.UseRippleEffect = true;
            this.information.UseZoomEffectOnHover = false;
            // 
            // delete_people
            // 
            this.delete_people.BackColor = System.Drawing.Color.Tomato;
            this.delete_people.BackColorAdditional = System.Drawing.Color.Gray;
            this.delete_people.BackColorGradientEnabled = false;
            this.delete_people.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.delete_people.BorderColor = System.Drawing.Color.Tomato;
            this.delete_people.BorderColorEnabled = false;
            this.delete_people.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.delete_people.BorderColorOnHoverEnabled = false;
            this.delete_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_people.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.delete_people.ForeColor = System.Drawing.Color.White;
            this.delete_people.Location = new System.Drawing.Point(6, 42);
            this.delete_people.Name = "delete_people";
            this.delete_people.RippleColor = System.Drawing.Color.Black;
            this.delete_people.RoundingEnable = false;
            this.delete_people.Size = new System.Drawing.Size(132, 30);
            this.delete_people.TabIndex = 2;
            this.delete_people.Text = "Исключить участника";
            this.delete_people.TextHover = null;
            this.delete_people.UseDownPressEffectOnClick = false;
            this.delete_people.UseRippleEffect = true;
            this.delete_people.UseZoomEffectOnHover = false;
            this.delete_people.Click += new System.EventHandler(this.delete_people_Click);
            // 
            // add_people
            // 
            this.add_people.BackColor = System.Drawing.Color.Tomato;
            this.add_people.BackColorAdditional = System.Drawing.Color.Gray;
            this.add_people.BackColorGradientEnabled = false;
            this.add_people.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.add_people.BorderColor = System.Drawing.Color.Tomato;
            this.add_people.BorderColorEnabled = false;
            this.add_people.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.add_people.BorderColorOnHoverEnabled = false;
            this.add_people.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_people.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.add_people.ForeColor = System.Drawing.Color.White;
            this.add_people.Location = new System.Drawing.Point(6, 6);
            this.add_people.Name = "add_people";
            this.add_people.RippleColor = System.Drawing.Color.Black;
            this.add_people.RoundingEnable = false;
            this.add_people.Size = new System.Drawing.Size(132, 30);
            this.add_people.TabIndex = 1;
            this.add_people.Text = "Добавить участника";
            this.add_people.TextHover = null;
            this.add_people.UseDownPressEffectOnClick = false;
            this.add_people.UseRippleEffect = true;
            this.add_people.UseZoomEffectOnHover = false;
            this.add_people.Click += new System.EventHandler(this.add_people_Click);
            // 
            // all_money
            // 
            this.all_money.BackColor = System.Drawing.Color.White;
            this.all_money.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.all_money.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.all_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.all_money.Font = new System.Drawing.Font("Arial", 11.25F);
            this.all_money.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.all_money.ForeColor = System.Drawing.Color.Black;
            this.all_money.Location = new System.Drawing.Point(569, 398);
            this.all_money.Name = "all_money";
            this.all_money.Size = new System.Drawing.Size(281, 40);
            this.all_money.TabIndex = 6;
            this.all_money.TextInput = "";
            this.all_money.TextPreview = "общее количество средств";
            this.all_money.UseSystemPasswordChar = false;
            // 
            // vclad_money
            // 
            this.vclad_money.BackColor = System.Drawing.Color.White;
            this.vclad_money.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.vclad_money.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.vclad_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vclad_money.Font = new System.Drawing.Font("Arial", 11.25F);
            this.vclad_money.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.vclad_money.ForeColor = System.Drawing.Color.Black;
            this.vclad_money.Location = new System.Drawing.Point(8, 398);
            this.vclad_money.Name = "vclad_money";
            this.vclad_money.Size = new System.Drawing.Size(277, 40);
            this.vclad_money.TabIndex = 5;
            this.vclad_money.TextInput = "";
            this.vclad_money.TextPreview = "количество средств от вклада";
            this.vclad_money.UseSystemPasswordChar = false;
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.None;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.DimGray;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderColorGradientEnable = false;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 18;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Операция";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Участник";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Сумма";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Комментарий";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 130;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 25);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(340, 330);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 25);
            this.comboBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(144, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(445, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(321, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "-";
            // 
            // logs
            // 
            this.logs.Controls.Add(this.DGV_logs);
            this.logs.Location = new System.Drawing.Point(4, 26);
            this.logs.Name = "logs";
            this.logs.Padding = new System.Windows.Forms.Padding(3);
            this.logs.Size = new System.Drawing.Size(860, 361);
            this.logs.TabIndex = 2;
            this.logs.Text = "Логи";
            this.logs.UseVisualStyleBackColor = true;
            // 
            // DGV_logs
            // 
            this.DGV_logs.AllowUserToAddRows = false;
            this.DGV_logs.AllowUserToDeleteRows = false;
            this.DGV_logs.AllowUserToResizeColumns = false;
            this.DGV_logs.AllowUserToResizeRows = false;
            this.DGV_logs.BackgroundColor = System.Drawing.Color.White;
            this.DGV_logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_logs.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_logs.GridColor = System.Drawing.Color.White;
            this.DGV_logs.Location = new System.Drawing.Point(3, 6);
            this.DGV_logs.Name = "DGV_logs";
            this.DGV_logs.ReadOnly = true;
            this.DGV_logs.RowHeadersVisible = false;
            this.DGV_logs.Size = new System.Drawing.Size(851, 349);
            this.DGV_logs.TabIndex = 4;
            this.DGV_logs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_logs_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата и время";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Событие";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clear_money);
            this.Controls.Add(this.all_money);
            this.Controls.Add(this.vclad_money);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет средств";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.money.ResumeLayout(false);
            this.money.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_operation)).EndInit();
            this.people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_people)).EndInit();
            this.logs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage money;
        private System.Windows.Forms.TabPage people;
        private System.Windows.Forms.DataGridView DGV_operation;
        private yt_DesignUI.yt_Button delete_operation;
        private yt_DesignUI.yt_Button change_operation;
        private yt_DesignUI.yt_Button add_operation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_vid;
        private yt_DesignUI.EgoldsGoogleTextBox all_money;
        private yt_DesignUI.EgoldsGoogleTextBox vclad_money;
        private System.Windows.Forms.DataGridView DGV_people;
        private yt_DesignUI.yt_Button information;
        private yt_DesignUI.yt_Button delete_people;
        private yt_DesignUI.yt_Button add_people;
        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private yt_DesignUI.EgoldsGoogleTextBox clear_money;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private yt_DesignUI.yt_Button delete_all_operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage logs;
        private System.Windows.Forms.DataGridView DGV_logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

