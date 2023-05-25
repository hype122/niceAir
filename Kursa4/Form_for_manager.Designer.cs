namespace Kursa4
{
    partial class Form_for_manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otkuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogda_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plane_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.all_search_trip = new System.Windows.Forms.Button();
            this.kuda_trip = new System.Windows.Forms.TextBox();
            this.kogda_trip = new System.Windows.Forms.TextBox();
            this.plane_trip = new System.Windows.Forms.TextBox();
            this.gate_trip = new System.Windows.Forms.TextBox();
            this.price_trip = new System.Windows.Forms.TextBox();
            this.lbl_kuda = new System.Windows.Forms.Label();
            this.lbl_kogda = new System.Windows.Forms.Label();
            this.lbl_plane = new System.Windows.Forms.Label();
            this.lbl_gate = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cleartxt_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grid,
            this.otkuda_grid,
            this.kuda_grid,
            this.kogda_grid,
            this.plane_grid,
            this.gate_grid,
            this.price_grid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // id_grid
            // 
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
            // plane_grid
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.plane_grid.DefaultCellStyle = dataGridViewCellStyle10;
            this.plane_grid.HeaderText = "Самолёт";
            this.plane_grid.Name = "plane_grid";
            this.plane_grid.ReadOnly = true;
            this.plane_grid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gate_grid
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.gate_grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.gate_grid.HeaderText = "Корпус";
            this.gate_grid.Name = "gate_grid";
            this.gate_grid.ReadOnly = true;
            // 
            // price_grid
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.price_grid.DefaultCellStyle = dataGridViewCellStyle12;
            this.price_grid.HeaderText = "Цена";
            this.price_grid.Name = "price_grid";
            this.price_grid.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(474, 167);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // all_search_trip
            // 
            this.all_search_trip.Location = new System.Drawing.Point(329, 167);
            this.all_search_trip.Name = "all_search_trip";
            this.all_search_trip.Size = new System.Drawing.Size(139, 23);
            this.all_search_trip.TabIndex = 2;
            this.all_search_trip.Text = "Вывести все рейсы";
            this.all_search_trip.UseVisualStyleBackColor = true;
            this.all_search_trip.Click += new System.EventHandler(this.all_search_trip_Click);
            // 
            // kuda_trip
            // 
            this.kuda_trip.Location = new System.Drawing.Point(126, 20);
            this.kuda_trip.Name = "kuda_trip";
            this.kuda_trip.Size = new System.Drawing.Size(100, 23);
            this.kuda_trip.TabIndex = 4;
            // 
            // kogda_trip
            // 
            this.kogda_trip.Location = new System.Drawing.Point(126, 49);
            this.kogda_trip.Name = "kogda_trip";
            this.kogda_trip.Size = new System.Drawing.Size(100, 23);
            this.kogda_trip.TabIndex = 5;
            // 
            // plane_trip
            // 
            this.plane_trip.Location = new System.Drawing.Point(126, 78);
            this.plane_trip.Name = "plane_trip";
            this.plane_trip.Size = new System.Drawing.Size(100, 23);
            this.plane_trip.TabIndex = 7;
            // 
            // gate_trip
            // 
            this.gate_trip.Location = new System.Drawing.Point(126, 107);
            this.gate_trip.Name = "gate_trip";
            this.gate_trip.Size = new System.Drawing.Size(100, 23);
            this.gate_trip.TabIndex = 8;
            // 
            // price_trip
            // 
            this.price_trip.Location = new System.Drawing.Point(126, 138);
            this.price_trip.Name = "price_trip";
            this.price_trip.Size = new System.Drawing.Size(100, 23);
            this.price_trip.TabIndex = 9;
            // 
            // lbl_kuda
            // 
            this.lbl_kuda.AutoSize = true;
            this.lbl_kuda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kuda.Location = new System.Drawing.Point(12, 23);
            this.lbl_kuda.Name = "lbl_kuda";
            this.lbl_kuda.Size = new System.Drawing.Size(32, 15);
            this.lbl_kuda.TabIndex = 10;
            this.lbl_kuda.Text = "Куда";
            // 
            // lbl_kogda
            // 
            this.lbl_kogda.AutoSize = true;
            this.lbl_kogda.Location = new System.Drawing.Point(12, 52);
            this.lbl_kogda.Name = "lbl_kogda";
            this.lbl_kogda.Size = new System.Drawing.Size(38, 15);
            this.lbl_kogda.TabIndex = 11;
            this.lbl_kogda.Text = "Когда";
            // 
            // lbl_plane
            // 
            this.lbl_plane.AutoSize = true;
            this.lbl_plane.Location = new System.Drawing.Point(12, 81);
            this.lbl_plane.Name = "lbl_plane";
            this.lbl_plane.Size = new System.Drawing.Size(55, 15);
            this.lbl_plane.TabIndex = 13;
            this.lbl_plane.Text = "Самолёт";
            // 
            // lbl_gate
            // 
            this.lbl_gate.AutoSize = true;
            this.lbl_gate.Location = new System.Drawing.Point(12, 110);
            this.lbl_gate.Name = "lbl_gate";
            this.lbl_gate.Size = new System.Drawing.Size(47, 15);
            this.lbl_gate.TabIndex = 14;
            this.lbl_gate.Text = "Корпус";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(12, 141);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 15);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "Цена";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(248, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(555, 167);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 17;
            this.update_btn.Text = "Обновить";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cleartxt_btn
            // 
            this.cleartxt_btn.Location = new System.Drawing.Point(636, 167);
            this.cleartxt_btn.Name = "cleartxt_btn";
            this.cleartxt_btn.Size = new System.Drawing.Size(75, 23);
            this.cleartxt_btn.TabIndex = 18;
            this.cleartxt_btn.Text = "Очистить";
            this.cleartxt_btn.UseVisualStyleBackColor = true;
            this.cleartxt_btn.Click += new System.EventHandler(this.cleartxt_btn_Click);
            // 
            // Form_for_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cleartxt_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_gate);
            this.Controls.Add(this.lbl_plane);
            this.Controls.Add(this.lbl_kogda);
            this.Controls.Add(this.lbl_kuda);
            this.Controls.Add(this.price_trip);
            this.Controls.Add(this.gate_trip);
            this.Controls.Add(this.plane_trip);
            this.Controls.Add(this.kogda_trip);
            this.Controls.Add(this.kuda_trip);
            this.Controls.Add(this.all_search_trip);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_for_manager";
            this.Text = "Form_for_manager";
            this.Load += new System.EventHandler(this.Form_for_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_delete;
        private Button all_search_trip;
        private TextBox kuda_trip;
        private TextBox kogda_trip;
        private TextBox plane_trip;
        private TextBox gate_trip;
        private TextBox price_trip;
        private Label lbl_kuda;
        private Label lbl_kogda;
        private Label lbl_plane;
        private Label lbl_gate;
        private Label lbl_price;
        private Button btn_add;
        private DataGridViewTextBoxColumn id_grid;
        private DataGridViewTextBoxColumn otkuda_grid;
        private DataGridViewTextBoxColumn kuda_grid;
        private DataGridViewTextBoxColumn kogda_grid;
        private DataGridViewTextBoxColumn plane_grid;
        private DataGridViewTextBoxColumn gate_grid;
        private DataGridViewTextBoxColumn price_grid;
        private Button update_btn;
        private Button cleartxt_btn;
    }
}