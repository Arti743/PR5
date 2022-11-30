
namespace Guide_to_Teyvat
{
    partial class Table_Char
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genshin_InfoDataSet = new Guide_to_Teyvat.Genshin_InfoDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Admin = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.charactersTableAdapter = new Guide_to_Teyvat.Genshin_InfoDataSetTableAdapters.CharactersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eyeofGodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rarityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versiongameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genshin_InfoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameCharDataGridViewTextBoxColumn,
            this.genderCharDataGridViewTextBoxColumn,
            this.eyeofGodDataGridViewTextBoxColumn,
            this.weaponDataGridViewTextBoxColumn,
            this.rarityDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.versiongameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.charactersBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "Characters";
            this.charactersBindingSource.DataSource = this.genshin_InfoDataSet;
            // 
            // genshin_InfoDataSet
            // 
            this.genshin_InfoDataSet.DataSetName = "Genshin_InfoDataSet";
            this.genshin_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 494);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(626, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(139, 453);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.radioButton4);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(131, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильтр";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Мондштадт",
            "Ли Юэ",
            "Инадзума",
            "Сумеру",
            "Снежная"});
            this.comboBox3.Location = new System.Drawing.Point(3, 266);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(9, 225);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Женский";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(9, 201);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Мужской";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Одноручный меч",
            "Двуручный меч",
            "Лук",
            "Копье",
            "Катализатор"});
            this.comboBox2.Location = new System.Drawing.Point(3, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(9, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4*";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(9, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5*";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Редкость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Глаз бога";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Регион";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оружие";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.button_Admin);
            this.tabPage2.Controls.Add(this.button_Del);
            this.tabPage2.Controls.Add(this.button_Update);
            this.tabPage2.Controls.Add(this.button_Add);
            this.tabPage2.Controls.Add(this.button_Save);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(131, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            // 
            // button_Admin
            // 
            this.button_Admin.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Admin.Location = new System.Drawing.Point(6, 6);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(116, 32);
            this.button_Admin.TabIndex = 4;
            this.button_Admin.Text = "Администратор";
            this.button_Admin.UseVisualStyleBackColor = false;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // button_Del
            // 
            this.button_Del.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.Location = new System.Drawing.Point(20, 269);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(86, 32);
            this.button_Del.TabIndex = 3;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Visible = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Location = new System.Drawing.Point(20, 217);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(86, 32);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Обновить";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Visible = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(20, 165);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 32);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Visible = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(20, 113);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(86, 32);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // charactersTableAdapter
            // 
            this.charactersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(3, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameCharDataGridViewTextBoxColumn
            // 
            this.nameCharDataGridViewTextBoxColumn.DataPropertyName = "Name_Char";
            this.nameCharDataGridViewTextBoxColumn.HeaderText = "Name_Char";
            this.nameCharDataGridViewTextBoxColumn.Name = "nameCharDataGridViewTextBoxColumn";
            this.nameCharDataGridViewTextBoxColumn.Width = 80;
            // 
            // genderCharDataGridViewTextBoxColumn
            // 
            this.genderCharDataGridViewTextBoxColumn.DataPropertyName = "Gender_Char";
            this.genderCharDataGridViewTextBoxColumn.HeaderText = "Gender_Char";
            this.genderCharDataGridViewTextBoxColumn.Name = "genderCharDataGridViewTextBoxColumn";
            this.genderCharDataGridViewTextBoxColumn.Width = 80;
            // 
            // eyeofGodDataGridViewTextBoxColumn
            // 
            this.eyeofGodDataGridViewTextBoxColumn.DataPropertyName = "Eye_of_God";
            this.eyeofGodDataGridViewTextBoxColumn.HeaderText = "Eye_of_God";
            this.eyeofGodDataGridViewTextBoxColumn.Name = "eyeofGodDataGridViewTextBoxColumn";
            this.eyeofGodDataGridViewTextBoxColumn.Width = 70;
            // 
            // weaponDataGridViewTextBoxColumn
            // 
            this.weaponDataGridViewTextBoxColumn.DataPropertyName = "Weapon";
            this.weaponDataGridViewTextBoxColumn.HeaderText = "Weapon";
            this.weaponDataGridViewTextBoxColumn.Name = "weaponDataGridViewTextBoxColumn";
            this.weaponDataGridViewTextBoxColumn.Width = 90;
            // 
            // rarityDataGridViewTextBoxColumn
            // 
            this.rarityDataGridViewTextBoxColumn.DataPropertyName = "Rarity";
            this.rarityDataGridViewTextBoxColumn.HeaderText = "Rarity";
            this.rarityDataGridViewTextBoxColumn.Name = "rarityDataGridViewTextBoxColumn";
            this.rarityDataGridViewTextBoxColumn.Width = 40;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.Width = 65;
            // 
            // versiongameDataGridViewTextBoxColumn
            // 
            this.versiongameDataGridViewTextBoxColumn.DataPropertyName = "Version_game";
            this.versiongameDataGridViewTextBoxColumn.HeaderText = "Version_game";
            this.versiongameDataGridViewTextBoxColumn.Name = "versiongameDataGridViewTextBoxColumn";
            this.versiongameDataGridViewTextBoxColumn.Width = 78;
            // 
            // Table_Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 494);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table_Char";
            this.Text = "Table_Char";
            this.Load += new System.EventHandler(this.Table_Char_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genshin_InfoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Genshin_InfoDataSet genshin_InfoDataSet;
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private Genshin_InfoDataSetTableAdapters.CharactersTableAdapter charactersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eyeofGodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rarityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versiongameDataGridViewTextBoxColumn;
    }
}