﻿

namespace Kursa4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.passagers = new System.Windows.Forms.TabPage();
            this.reg_pass_panel = new System.Windows.Forms.Panel();
            this.reg_passport_lbl = new System.Windows.Forms.Label();
            this.reg_fio_lbl = new System.Windows.Forms.Label();
            this.reg_data_lbl = new System.Windows.Forms.Label();
            this.reg_data_pass = new System.Windows.Forms.DateTimePicker();
            this.reg_passport_passager = new System.Windows.Forms.MaskedTextBox();
            this.reg_btn_passager = new System.Windows.Forms.Button();
            this.reg_fio_passager = new System.Windows.Forms.TextBox();
            this.reg_pass_lbl = new System.Windows.Forms.Label();
            this.search_pass_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_passport = new System.Windows.Forms.Label();
            this.btn_choise_passager = new System.Windows.Forms.Button();
            this.pasport_pass = new System.Windows.Forms.MaskedTextBox();
            this.seacrh_pass_lbl = new System.Windows.Forms.Label();
            this.search_fio_pass = new System.Windows.Forms.TextBox();
            this.search_passager = new System.Windows.Forms.Button();
            this.search_passport_pass = new System.Windows.Forms.TextBox();
            this.search_page = new System.Windows.Forms.TabPage();
            this.dateTime_kogda = new System.Windows.Forms.TextBox();
            this.kuda = new System.Windows.Forms.TextBox();
            this.otkuda = new System.Windows.Forms.TextBox();
            this.trip_page = new System.Windows.Forms.TabPage();
            this.lbl_search_city = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_grid_kuda = new System.Windows.Forms.TextBox();
            this.btn_grid_accept = new System.Windows.Forms.Button();
            this.btn_grid_search = new System.Windows.Forms.Button();
            this.trip_grid = new System.Windows.Forms.DataGridView();
            this.profile_page = new System.Windows.Forms.TabPage();
            this.exit_btn = new System.Windows.Forms.Button();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.surname_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.log_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.user_anim = new System.Windows.Forms.PictureBox();
            this.phone_box_auth = new System.Windows.Forms.TextBox();
            this.name_box_auth = new System.Windows.Forms.TextBox();
            this.login_box_auth = new System.Windows.Forms.TextBox();
            this.surname_box_auth = new System.Windows.Forms.TextBox();
            this.reg_bag_check = new System.Windows.Forms.CheckBox();
            this.buy_ticket = new System.Windows.Forms.Button();
            this.Pass_lbl_down = new System.Windows.Forms.Label();
            this.Trip_lbl_down = new System.Windows.Forms.Label();
            this.id_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otkuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.passagers.SuspendLayout();
            this.reg_pass_panel.SuspendLayout();
            this.search_pass_panel.SuspendLayout();
            this.search_page.SuspendLayout();
            this.trip_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trip_grid)).BeginInit();
            this.profile_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_anim)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Location = new System.Drawing.Point(498, 109);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(101, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Buy ticket";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.passagers);
            this.tabControl1.Controls.Add(this.search_page);
            this.tabControl1.Controls.Add(this.trip_page);
            this.tabControl1.Controls.Add(this.profile_page);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 430);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // passagers
            // 
            this.passagers.Controls.Add(this.reg_pass_panel);
            this.passagers.Controls.Add(this.search_pass_panel);
            this.passagers.Location = new System.Drawing.Point(4, 24);
            this.passagers.Name = "passagers";
            this.passagers.Size = new System.Drawing.Size(780, 402);
            this.passagers.TabIndex = 3;
            this.passagers.Text = "Пассажир";
            this.passagers.UseVisualStyleBackColor = true;
            // 
            // reg_pass_panel
            // 
            this.reg_pass_panel.Controls.Add(this.reg_passport_lbl);
            this.reg_pass_panel.Controls.Add(this.reg_fio_lbl);
            this.reg_pass_panel.Controls.Add(this.reg_data_lbl);
            this.reg_pass_panel.Controls.Add(this.reg_data_pass);
            this.reg_pass_panel.Controls.Add(this.reg_passport_passager);
            this.reg_pass_panel.Controls.Add(this.reg_btn_passager);
            this.reg_pass_panel.Controls.Add(this.reg_fio_passager);
            this.reg_pass_panel.Controls.Add(this.reg_pass_lbl);
            this.reg_pass_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.reg_pass_panel.Location = new System.Drawing.Point(392, 0);
            this.reg_pass_panel.Name = "reg_pass_panel";
            this.reg_pass_panel.Size = new System.Drawing.Size(388, 402);
            this.reg_pass_panel.TabIndex = 5;
            // 
            // reg_passport_lbl
            // 
            this.reg_passport_lbl.AutoSize = true;
            this.reg_passport_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_passport_lbl.Location = new System.Drawing.Point(10, 101);
            this.reg_passport_lbl.Name = "reg_passport_lbl";
            this.reg_passport_lbl.Size = new System.Drawing.Size(54, 15);
            this.reg_passport_lbl.TabIndex = 8;
            this.reg_passport_lbl.Text = "Паспорт";
            // 
            // reg_fio_lbl
            // 
            this.reg_fio_lbl.AutoSize = true;
            this.reg_fio_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_fio_lbl.Location = new System.Drawing.Point(10, 134);
            this.reg_fio_lbl.Name = "reg_fio_lbl";
            this.reg_fio_lbl.Size = new System.Drawing.Size(34, 15);
            this.reg_fio_lbl.TabIndex = 7;
            this.reg_fio_lbl.Text = "ФИО";
            // 
            // reg_data_lbl
            // 
            this.reg_data_lbl.AutoSize = true;
            this.reg_data_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_data_lbl.Location = new System.Drawing.Point(10, 161);
            this.reg_data_lbl.Name = "reg_data_lbl";
            this.reg_data_lbl.Size = new System.Drawing.Size(90, 15);
            this.reg_data_lbl.TabIndex = 6;
            this.reg_data_lbl.Text = "Дата рождения";
            // 
            // reg_data_pass
            // 
            this.reg_data_pass.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reg_data_pass.Location = new System.Drawing.Point(123, 155);
            this.reg_data_pass.MaxDate = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.reg_data_pass.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.reg_data_pass.Name = "reg_data_pass";
            this.reg_data_pass.Size = new System.Drawing.Size(174, 23);
            this.reg_data_pass.TabIndex = 5;
            this.reg_data_pass.Value = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // reg_passport_passager
            // 
            this.reg_passport_passager.Location = new System.Drawing.Point(123, 98);
            this.reg_passport_passager.Mask = "0000-999999";
            this.reg_passport_passager.Name = "reg_passport_passager";
            this.reg_passport_passager.Size = new System.Drawing.Size(174, 23);
            this.reg_passport_passager.TabIndex = 4;
            // 
            // reg_btn_passager
            // 
            this.reg_btn_passager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_btn_passager.Location = new System.Drawing.Point(177, 201);
            this.reg_btn_passager.Name = "reg_btn_passager";
            this.reg_btn_passager.Size = new System.Drawing.Size(75, 23);
            this.reg_btn_passager.TabIndex = 3;
            this.reg_btn_passager.Text = "Добавить";
            this.reg_btn_passager.UseVisualStyleBackColor = true;
            this.reg_btn_passager.Click += new System.EventHandler(this.reg_btn_passager_Click);
            // 
            // reg_fio_passager
            // 
            this.reg_fio_passager.Location = new System.Drawing.Point(123, 126);
            this.reg_fio_passager.Name = "reg_fio_passager";
            this.reg_fio_passager.Size = new System.Drawing.Size(174, 23);
            this.reg_fio_passager.TabIndex = 1;
            this.reg_fio_passager.WordWrap = false;
            this.reg_fio_passager.Click += new System.EventHandler(this.reg_fio_passager_Click);
            this.reg_fio_passager.TextChanged += new System.EventHandler(this.reg_fio_passager_TextChanged);
            this.reg_fio_passager.Enter += new System.EventHandler(this.reg_fio_passager_Enter);
            this.reg_fio_passager.Leave += new System.EventHandler(this.reg_fio_passager_Leave);
            // 
            // reg_pass_lbl
            // 
            this.reg_pass_lbl.AutoSize = true;
            this.reg_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_pass_lbl.Location = new System.Drawing.Point(123, 39);
            this.reg_pass_lbl.Name = "reg_pass_lbl";
            this.reg_pass_lbl.Size = new System.Drawing.Size(139, 15);
            this.reg_pass_lbl.TabIndex = 0;
            this.reg_pass_lbl.Text = "Регистрация пассажира";
            // 
            // search_pass_panel
            // 
            this.search_pass_panel.Controls.Add(this.label3);
            this.search_pass_panel.Controls.Add(this.label2);
            this.search_pass_panel.Controls.Add(this.lbl_passport);
            this.search_pass_panel.Controls.Add(this.btn_choise_passager);
            this.search_pass_panel.Controls.Add(this.pasport_pass);
            this.search_pass_panel.Controls.Add(this.seacrh_pass_lbl);
            this.search_pass_panel.Controls.Add(this.search_fio_pass);
            this.search_pass_panel.Controls.Add(this.search_passager);
            this.search_pass_panel.Controls.Add(this.search_passport_pass);
            this.search_pass_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_pass_panel.Location = new System.Drawing.Point(0, 0);
            this.search_pass_panel.Name = "search_pass_panel";
            this.search_pass_panel.Size = new System.Drawing.Size(374, 402);
            this.search_pass_panel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Паспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО";
            // 
            // lbl_passport
            // 
            this.lbl_passport.AutoSize = true;
            this.lbl_passport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_passport.Location = new System.Drawing.Point(7, 100);
            this.lbl_passport.Name = "lbl_passport";
            this.lbl_passport.Size = new System.Drawing.Size(98, 15);
            this.lbl_passport.TabIndex = 7;
            this.lbl_passport.Text = "Введите паспорт";
            // 
            // btn_choise_passager
            // 
            this.btn_choise_passager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_choise_passager.Location = new System.Drawing.Point(141, 279);
            this.btn_choise_passager.Name = "btn_choise_passager";
            this.btn_choise_passager.Size = new System.Drawing.Size(75, 23);
            this.btn_choise_passager.TabIndex = 6;
            this.btn_choise_passager.Text = "Выбрать";
            this.btn_choise_passager.UseVisualStyleBackColor = true;
            this.btn_choise_passager.Click += new System.EventHandler(this.btn_choise_passager_Click);
            // 
            // pasport_pass
            // 
            this.pasport_pass.Location = new System.Drawing.Point(111, 97);
            this.pasport_pass.Mask = "0000-999999";
            this.pasport_pass.Name = "pasport_pass";
            this.pasport_pass.Size = new System.Drawing.Size(139, 23);
            this.pasport_pass.TabIndex = 5;
            // 
            // seacrh_pass_lbl
            // 
            this.seacrh_pass_lbl.AutoSize = true;
            this.seacrh_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seacrh_pass_lbl.Location = new System.Drawing.Point(111, 39);
            this.seacrh_pass_lbl.Name = "seacrh_pass_lbl";
            this.seacrh_pass_lbl.Size = new System.Drawing.Size(105, 15);
            this.seacrh_pass_lbl.TabIndex = 4;
            this.seacrh_pass_lbl.Text = "Поиск пассажира";
            // 
            // search_fio_pass
            // 
            this.search_fio_pass.Location = new System.Drawing.Point(111, 205);
            this.search_fio_pass.Name = "search_fio_pass";
            this.search_fio_pass.ReadOnly = true;
            this.search_fio_pass.Size = new System.Drawing.Size(165, 23);
            this.search_fio_pass.TabIndex = 3;
            // 
            // search_passager
            // 
            this.search_passager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_passager.Location = new System.Drawing.Point(265, 97);
            this.search_passager.Name = "search_passager";
            this.search_passager.Size = new System.Drawing.Size(75, 23);
            this.search_passager.TabIndex = 1;
            this.search_passager.Text = "Поиск";
            this.search_passager.UseVisualStyleBackColor = true;
            this.search_passager.Click += new System.EventHandler(this.search_passager_Click);
            // 
            // search_passport_pass
            // 
            this.search_passport_pass.Location = new System.Drawing.Point(111, 176);
            this.search_passport_pass.Name = "search_passport_pass";
            this.search_passport_pass.ReadOnly = true;
            this.search_passport_pass.Size = new System.Drawing.Size(165, 23);
            this.search_passport_pass.TabIndex = 2;
            this.search_passport_pass.TextChanged += new System.EventHandler(this.search_passport_pass_TextChanged);
            // 
            // search_page
            // 
            this.search_page.Controls.Add(this.dateTime_kogda);
            this.search_page.Controls.Add(this.kuda);
            this.search_page.Controls.Add(this.otkuda);
            this.search_page.Controls.Add(this.search);
            this.search_page.Location = new System.Drawing.Point(4, 24);
            this.search_page.Name = "search_page";
            this.search_page.Padding = new System.Windows.Forms.Padding(3);
            this.search_page.Size = new System.Drawing.Size(780, 402);
            this.search_page.TabIndex = 0;
            this.search_page.Text = "Поиск";
            this.search_page.UseVisualStyleBackColor = true;
            this.search_page.Click += new System.EventHandler(this.ticket_Click);
            // 
            // dateTime_kogda
            // 
            this.dateTime_kogda.Location = new System.Drawing.Point(332, 109);
            this.dateTime_kogda.Name = "dateTime_kogda";
            this.dateTime_kogda.Size = new System.Drawing.Size(100, 23);
            this.dateTime_kogda.TabIndex = 12;
            this.dateTime_kogda.Click += new System.EventHandler(this.dateTime_kogda_Click);
            this.dateTime_kogda.TextChanged += new System.EventHandler(this.dateTime_kogda_TextChanged);
            this.dateTime_kogda.Leave += new System.EventHandler(this.dateTime_kogda_Leave);
            // 
            // kuda
            // 
            this.kuda.Location = new System.Drawing.Point(197, 109);
            this.kuda.Name = "kuda";
            this.kuda.Size = new System.Drawing.Size(100, 23);
            this.kuda.TabIndex = 11;
            this.kuda.Click += new System.EventHandler(this.kuda_Click_1);
            this.kuda.Leave += new System.EventHandler(this.kuda_Leave);
            // 
            // otkuda
            // 
            this.otkuda.Location = new System.Drawing.Point(66, 109);
            this.otkuda.Name = "otkuda";
            this.otkuda.ReadOnly = true;
            this.otkuda.Size = new System.Drawing.Size(100, 23);
            this.otkuda.TabIndex = 10;
            // 
            // trip_page
            // 
            this.trip_page.Controls.Add(this.lbl_search_city);
            this.trip_page.Controls.Add(this.label1);
            this.trip_page.Controls.Add(this.txt_grid_kuda);
            this.trip_page.Controls.Add(this.btn_grid_accept);
            this.trip_page.Controls.Add(this.btn_grid_search);
            this.trip_page.Controls.Add(this.trip_grid);
            this.trip_page.Location = new System.Drawing.Point(4, 24);
            this.trip_page.Name = "trip_page";
            this.trip_page.Size = new System.Drawing.Size(780, 402);
            this.trip_page.TabIndex = 2;
            this.trip_page.Text = "Рейсы";
            this.trip_page.UseVisualStyleBackColor = true;
            // 
            // lbl_search_city
            // 
            this.lbl_search_city.AutoSize = true;
            this.lbl_search_city.ForeColor = System.Drawing.Color.Black;
            this.lbl_search_city.Location = new System.Drawing.Point(8, 35);
            this.lbl_search_city.Name = "lbl_search_city";
            this.lbl_search_city.Size = new System.Drawing.Size(85, 15);
            this.lbl_search_city.TabIndex = 5;
            this.lbl_search_city.Text = "Введите город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // txt_grid_kuda
            // 
            this.txt_grid_kuda.Location = new System.Drawing.Point(123, 28);
            this.txt_grid_kuda.Name = "txt_grid_kuda";
            this.txt_grid_kuda.Size = new System.Drawing.Size(100, 23);
            this.txt_grid_kuda.TabIndex = 3;
            // 
            // btn_grid_accept
            // 
            this.btn_grid_accept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_grid_accept.Location = new System.Drawing.Point(372, 27);
            this.btn_grid_accept.Name = "btn_grid_accept";
            this.btn_grid_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_accept.TabIndex = 2;
            this.btn_grid_accept.Text = "Принять";
            this.btn_grid_accept.UseVisualStyleBackColor = true;
            this.btn_grid_accept.Click += new System.EventHandler(this.btn_grid_accept_Click);
            // 
            // btn_grid_search
            // 
            this.btn_grid_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_grid_search.Location = new System.Drawing.Point(291, 28);
            this.btn_grid_search.Name = "btn_grid_search";
            this.btn_grid_search.Size = new System.Drawing.Size(75, 23);
            this.btn_grid_search.TabIndex = 1;
            this.btn_grid_search.Text = "Поиск";
            this.btn_grid_search.UseVisualStyleBackColor = true;
            this.btn_grid_search.Click += new System.EventHandler(this.btn_grid_search_Click);
            // 
            // trip_grid
            // 
            this.trip_grid.AllowUserToDeleteRows = false;
            this.trip_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.trip_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trip_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grid,
            this.otkuda_grid,
            this.kuda_grid,
            this.kogda_grid,
            this.price});
            this.trip_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trip_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.trip_grid.Location = new System.Drawing.Point(0, 70);
            this.trip_grid.Name = "trip_grid";
            this.trip_grid.ReadOnly = true;
            this.trip_grid.RowTemplate.Height = 25;
            this.trip_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trip_grid.Size = new System.Drawing.Size(780, 332);
            this.trip_grid.TabIndex = 0;
            this.trip_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trip_grid_CellContentClick);
            this.trip_grid.ColumnStateChanged += new System.Windows.Forms.DataGridViewColumnStateChangedEventHandler(this.trip_grid_ColumnStateChanged);
            // 
            // profile_page
            // 
            this.profile_page.Controls.Add(this.exit_btn);
            this.profile_page.Controls.Add(this.phone_lbl);
            this.profile_page.Controls.Add(this.surname_lbl);
            this.profile_page.Controls.Add(this.name_lbl);
            this.profile_page.Controls.Add(this.log_lbl);
            this.profile_page.Controls.Add(this.welcome_lbl);
            this.profile_page.Controls.Add(this.user_anim);
            this.profile_page.Controls.Add(this.phone_box_auth);
            this.profile_page.Controls.Add(this.name_box_auth);
            this.profile_page.Controls.Add(this.login_box_auth);
            this.profile_page.Controls.Add(this.surname_box_auth);
            this.profile_page.Location = new System.Drawing.Point(4, 24);
            this.profile_page.Name = "profile_page";
            this.profile_page.Padding = new System.Windows.Forms.Padding(3);
            this.profile_page.Size = new System.Drawing.Size(780, 402);
            this.profile_page.TabIndex = 1;
            this.profile_page.Text = "Профиль";
            this.profile_page.UseVisualStyleBackColor = true;
            this.profile_page.Enter += new System.EventHandler(this.profile_Enter);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_btn.Location = new System.Drawing.Point(339, 267);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_lbl.Location = new System.Drawing.Point(299, 178);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(55, 15);
            this.phone_lbl.TabIndex = 11;
            this.phone_lbl.Text = "Телефон";
            // 
            // surname_lbl
            // 
            this.surname_lbl.AutoSize = true;
            this.surname_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.surname_lbl.Location = new System.Drawing.Point(299, 146);
            this.surname_lbl.Name = "surname_lbl";
            this.surname_lbl.Size = new System.Drawing.Size(58, 15);
            this.surname_lbl.TabIndex = 10;
            this.surname_lbl.Text = "Фамилия";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_lbl.Location = new System.Drawing.Point(299, 117);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(31, 15);
            this.name_lbl.TabIndex = 9;
            this.name_lbl.Text = "Имя";
            // 
            // log_lbl
            // 
            this.log_lbl.AutoSize = true;
            this.log_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log_lbl.Location = new System.Drawing.Point(299, 88);
            this.log_lbl.Name = "log_lbl";
            this.log_lbl.Size = new System.Drawing.Size(41, 15);
            this.log_lbl.TabIndex = 7;
            this.log_lbl.Text = "Логин";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome_lbl.Location = new System.Drawing.Point(275, 21);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(238, 32);
            this.welcome_lbl.TabIndex = 6;
            this.welcome_lbl.Text = "Добро пожаловать, ";
            // 
            // user_anim
            // 
            this.user_anim.Image = ((System.Drawing.Image)(resources.GetObject("user_anim.Image")));
            this.user_anim.Location = new System.Drawing.Point(38, 21);
            this.user_anim.Name = "user_anim";
            this.user_anim.Size = new System.Drawing.Size(192, 172);
            this.user_anim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_anim.TabIndex = 5;
            this.user_anim.TabStop = false;
            // 
            // phone_box_auth
            // 
            this.phone_box_auth.Location = new System.Drawing.Point(413, 175);
            this.phone_box_auth.Name = "phone_box_auth";
            this.phone_box_auth.ReadOnly = true;
            this.phone_box_auth.Size = new System.Drawing.Size(100, 23);
            this.phone_box_auth.TabIndex = 4;
            // 
            // name_box_auth
            // 
            this.name_box_auth.Location = new System.Drawing.Point(413, 114);
            this.name_box_auth.Name = "name_box_auth";
            this.name_box_auth.ReadOnly = true;
            this.name_box_auth.Size = new System.Drawing.Size(100, 23);
            this.name_box_auth.TabIndex = 3;
            // 
            // login_box_auth
            // 
            this.login_box_auth.Location = new System.Drawing.Point(413, 85);
            this.login_box_auth.Name = "login_box_auth";
            this.login_box_auth.ReadOnly = true;
            this.login_box_auth.Size = new System.Drawing.Size(100, 23);
            this.login_box_auth.TabIndex = 1;
            // 
            // surname_box_auth
            // 
            this.surname_box_auth.Location = new System.Drawing.Point(413, 143);
            this.surname_box_auth.Name = "surname_box_auth";
            this.surname_box_auth.ReadOnly = true;
            this.surname_box_auth.Size = new System.Drawing.Size(100, 23);
            this.surname_box_auth.TabIndex = 0;
            // 
            // reg_bag_check
            // 
            this.reg_bag_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reg_bag_check.AutoSize = true;
            this.reg_bag_check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_bag_check.Location = new System.Drawing.Point(548, 435);
            this.reg_bag_check.Name = "reg_bag_check";
            this.reg_bag_check.Size = new System.Drawing.Size(107, 19);
            this.reg_bag_check.TabIndex = 9;
            this.reg_bag_check.Text = "Есть ли багаж?";
            this.reg_bag_check.UseVisualStyleBackColor = true;
            // 
            // buy_ticket
            // 
            this.buy_ticket.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buy_ticket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buy_ticket.Location = new System.Drawing.Point(661, 432);
            this.buy_ticket.Name = "buy_ticket";
            this.buy_ticket.Size = new System.Drawing.Size(115, 23);
            this.buy_ticket.TabIndex = 10;
            this.buy_ticket.Text = "Оформить билет";
            this.buy_ticket.UseVisualStyleBackColor = true;
            this.buy_ticket.Click += new System.EventHandler(this.buy_ticket_Click);
            // 
            // Pass_lbl_down
            // 
            this.Pass_lbl_down.AutoSize = true;
            this.Pass_lbl_down.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pass_lbl_down.Location = new System.Drawing.Point(12, 436);
            this.Pass_lbl_down.Name = "Pass_lbl_down";
            this.Pass_lbl_down.Size = new System.Drawing.Size(0, 15);
            this.Pass_lbl_down.TabIndex = 11;
            // 
            // Trip_lbl_down
            // 
            this.Trip_lbl_down.AutoSize = true;
            this.Trip_lbl_down.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Trip_lbl_down.Location = new System.Drawing.Point(334, 436);
            this.Trip_lbl_down.Name = "Trip_lbl_down";
            this.Trip_lbl_down.Size = new System.Drawing.Size(13, 15);
            this.Trip_lbl_down.TabIndex = 12;
            this.Trip_lbl_down.Text = "0";
            // 
            // id_grid
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.id_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.id_grid.HeaderText = "id";
            this.id_grid.Name = "id_grid";
            this.id_grid.ReadOnly = true;
            // 
            // otkuda_grid
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.otkuda_grid.DefaultCellStyle = dataGridViewCellStyle7;
            this.otkuda_grid.HeaderText = "Откуда";
            this.otkuda_grid.Name = "otkuda_grid";
            this.otkuda_grid.ReadOnly = true;
            // 
            // kuda_grid
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.kuda_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.kuda_grid.HeaderText = "Куда";
            this.kuda_grid.Name = "kuda_grid";
            this.kuda_grid.ReadOnly = true;
            // 
            // kogda_grid
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.kogda_grid.DefaultCellStyle = dataGridViewCellStyle9;
            this.kogda_grid.HeaderText = "Когда";
            this.kogda_grid.Name = "kogda_grid";
            this.kogda_grid.ReadOnly = true;
            // 
            // price
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.price.DefaultCellStyle = dataGridViewCellStyle10;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 459);
            this.Controls.Add(this.Trip_lbl_down);
            this.Controls.Add(this.Pass_lbl_down);
            this.Controls.Add(this.buy_ticket);
            this.Controls.Add(this.reg_bag_check);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Enter += new System.EventHandler(this.Menu_Enter);
            this.tabControl1.ResumeLayout(false);
            this.passagers.ResumeLayout(false);
            this.reg_pass_panel.ResumeLayout(false);
            this.reg_pass_panel.PerformLayout();
            this.search_pass_panel.ResumeLayout(false);
            this.search_pass_panel.PerformLayout();
            this.search_page.ResumeLayout(false);
            this.search_page.PerformLayout();
            this.trip_page.ResumeLayout(false);
            this.trip_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trip_grid)).EndInit();
            this.profile_page.ResumeLayout(false);
            this.profile_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_anim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button search;
        private TabControl tabControl1;
        private TabPage search_page;
        private TabPage profile_page;
        private TextBox login_box_auth;
        private TextBox phone_box_auth;
		private TabPage trip_page;
		private TextBox otkuda;
		private TextBox dateTime_kogda;
		private TextBox kuda;
        private PictureBox user_anim;
        private Label welcome_lbl;
        private Label phone_lbl;
        private Label surname_lbl;
        private Label name_lbl;
        private Label log_lbl;
        private DataGridView trip_grid;
        private TabPage passagers;
        private Button search_passager;
        private Panel reg_pass_panel;
        private Label reg_pass_lbl;
        private Panel search_pass_panel;
        private Label seacrh_pass_lbl;
        private TextBox search_fio_pass;
        private TextBox search_passport_pass;
        private TextBox reg_fio_passager;
        private Button reg_btn_passager;
        private MaskedTextBox pasport_pass;
        private MaskedTextBox reg_passport_passager;
        private TextBox txt_grid_kuda;
        private Button btn_grid_accept;
        private Button btn_grid_search;
		private Button btn_choise_passager;
		private Label lbl_search_city;
		private Label label1;
		private Button exit_btn;
        private TextBox surname_box_auth;
        private TextBox name_box_auth;
        private Label label3;
        private Label label2;
        private Label lbl_passport;
        private Label reg_passport_lbl;
        private Label reg_fio_lbl;
        private Label reg_data_lbl;
        private DateTimePicker reg_data_pass;
        private CheckBox reg_bag_check;
        private Button buy_ticket;
        private Label Pass_lbl_down;
        private Label Trip_lbl_down;
        private DataGridViewTextBoxColumn id_grid;
        private DataGridViewTextBoxColumn otkuda_grid;
        private DataGridViewTextBoxColumn kuda_grid;
        private DataGridViewTextBoxColumn kogda_grid;
        private DataGridViewTextBoxColumn price;
    }
}