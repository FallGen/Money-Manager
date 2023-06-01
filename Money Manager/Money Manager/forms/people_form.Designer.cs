namespace Money_Manager.forms
{
    partial class people_form
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
            this.TB_fio = new yt_DesignUI.EgoldsGoogleTextBox();
            this.TB_name = new yt_DesignUI.EgoldsGoogleTextBox();
            this.TB_otchestvo = new yt_DesignUI.EgoldsGoogleTextBox();
            this.TB_date = new yt_DesignUI.EgoldsGoogleTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_fio
            // 
            this.TB_fio.BackColor = System.Drawing.Color.White;
            this.TB_fio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TB_fio.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.TB_fio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_fio.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TB_fio.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TB_fio.ForeColor = System.Drawing.Color.Black;
            this.TB_fio.Location = new System.Drawing.Point(12, 12);
            this.TB_fio.Name = "TB_fio";
            this.TB_fio.Size = new System.Drawing.Size(258, 40);
            this.TB_fio.TabIndex = 15;
            this.TB_fio.TextInput = "";
            this.TB_fio.TextPreview = "фамилия";
            this.TB_fio.UseSystemPasswordChar = false;
            // 
            // TB_name
            // 
            this.TB_name.BackColor = System.Drawing.Color.White;
            this.TB_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TB_name.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.TB_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_name.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TB_name.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TB_name.ForeColor = System.Drawing.Color.Black;
            this.TB_name.Location = new System.Drawing.Point(12, 58);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(258, 40);
            this.TB_name.TabIndex = 16;
            this.TB_name.TextInput = "";
            this.TB_name.TextPreview = "имя";
            this.TB_name.UseSystemPasswordChar = false;
            // 
            // TB_otchestvo
            // 
            this.TB_otchestvo.BackColor = System.Drawing.Color.White;
            this.TB_otchestvo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TB_otchestvo.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.TB_otchestvo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_otchestvo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TB_otchestvo.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TB_otchestvo.ForeColor = System.Drawing.Color.Black;
            this.TB_otchestvo.Location = new System.Drawing.Point(12, 104);
            this.TB_otchestvo.Name = "TB_otchestvo";
            this.TB_otchestvo.Size = new System.Drawing.Size(258, 40);
            this.TB_otchestvo.TabIndex = 17;
            this.TB_otchestvo.TextInput = "";
            this.TB_otchestvo.TextPreview = "отчество";
            this.TB_otchestvo.UseSystemPasswordChar = false;
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
            this.TB_date.Location = new System.Drawing.Point(12, 150);
            this.TB_date.Name = "TB_date";
            this.TB_date.Size = new System.Drawing.Size(258, 40);
            this.TB_date.TabIndex = 18;
            this.TB_date.TextInput = "";
            this.TB_date.TextPreview = "дата добавления";
            this.TB_date.UseSystemPasswordChar = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(58, 206);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Tomato;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(167, 206);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 23);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // people_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 250);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.TB_date);
            this.Controls.Add(this.TB_otchestvo);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.TB_fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "people_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработчик участников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.people_form_FormClosing);
            this.Load += new System.EventHandler(this.people_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public yt_DesignUI.EgoldsGoogleTextBox TB_fio;
        public yt_DesignUI.EgoldsGoogleTextBox TB_name;
        public yt_DesignUI.EgoldsGoogleTextBox TB_otchestvo;
        public yt_DesignUI.EgoldsGoogleTextBox TB_date;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}