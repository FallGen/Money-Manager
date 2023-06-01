namespace Money_Manager.forms
{
    partial class operation_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_operation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_people = new System.Windows.Forms.ComboBox();
            this.TB_date = new yt_DesignUI.EgoldsGoogleTextBox();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.TB_comm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.TB_money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "операция";
            // 
            // CB_operation
            // 
            this.CB_operation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.CB_operation.FormattingEnabled = true;
            this.CB_operation.Items.AddRange(new object[] {
            "зачисление",
            "списание",
            "вклад (%)"});
            this.CB_operation.Location = new System.Drawing.Point(92, 9);
            this.CB_operation.Name = "CB_operation";
            this.CB_operation.Size = new System.Drawing.Size(223, 21);
            this.CB_operation.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "участник";
            // 
            // CB_people
            // 
            this.CB_people.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.CB_people.FormattingEnabled = true;
            this.CB_people.Items.AddRange(new object[] {
            "банк",
            "общее"});
            this.CB_people.Location = new System.Drawing.Point(92, 36);
            this.CB_people.Name = "CB_people";
            this.CB_people.Size = new System.Drawing.Size(223, 21);
            this.CB_people.TabIndex = 13;
            // 
            // TB_date
            // 
            this.TB_date.BackColor = System.Drawing.Color.White;
            this.TB_date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TB_date.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.TB_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_date.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TB_date.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TB_date.ForeColor = System.Drawing.Color.Black;
            this.TB_date.Location = new System.Drawing.Point(12, 63);
            this.TB_date.Name = "TB_date";
            this.TB_date.Size = new System.Drawing.Size(303, 40);
            this.TB_date.TabIndex = 14;
            this.TB_date.TextInput = "";
            this.TB_date.TextPreview = "дата";
            this.TB_date.UseSystemPasswordChar = false;
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = null;
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
            // TB_comm
            // 
            this.TB_comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_comm.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.TB_comm.Location = new System.Drawing.Point(13, 153);
            this.TB_comm.Multiline = true;
            this.TB_comm.Name = "TB_comm";
            this.TB_comm.Size = new System.Drawing.Size(303, 82);
            this.TB_comm.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "комментарий / пояснение";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Tomato;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(213, 248);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 23);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(104, 248);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // TB_money
            // 
            this.TB_money.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.TB_money.Location = new System.Drawing.Point(92, 109);
            this.TB_money.Name = "TB_money";
            this.TB_money.Size = new System.Drawing.Size(223, 21);
            this.TB_money.TabIndex = 23;
            this.TB_money.Text = "100";
            this.TB_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_money_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "сумма";
            // 
            // operation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_money);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_comm);
            this.Controls.Add(this.TB_date);
            this.Controls.Add(this.CB_people);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_operation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "operation_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработчик операций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.operation_form_FormClosing);
            this.Load += new System.EventHandler(this.operation_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.ComboBox CB_operation;
        public System.Windows.Forms.ComboBox CB_people;
        public yt_DesignUI.EgoldsGoogleTextBox TB_date;
        public System.Windows.Forms.TextBox TB_comm;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TB_money;
    }
}