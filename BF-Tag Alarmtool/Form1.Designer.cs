namespace BF_Tag_Alarmtool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEinsatzId = new System.Windows.Forms.TextBox();
            this.btAlarm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSachverhalt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEinsatzstichwort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEinsatzbeginn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEinsatznummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btNeuerEinsatz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlarmdurchsage = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.einsatzIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apiKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einsatzbeginnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einsatzstichwortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachverhaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einsatznummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAlarmiertDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alarmdurchsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEinsätzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.einsätze = new BF_Tag_Alarmtool.Einsätze();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEinsätzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.einsätze)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1767, 879);
            this.splitContainer1.SplitterDistance = 852;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.einsatzIdDataGridViewTextBoxColumn,
            this.apiKeyDataGridViewTextBoxColumn,
            this.einsatzbeginnDataGridViewTextBoxColumn,
            this.einsatzstichwortDataGridViewTextBoxColumn,
            this.sachverhaltDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.einsatznummerDataGridViewTextBoxColumn,
            this.isAlarmiertDataGridViewCheckBoxColumn,
            this.alarmdurchsageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEinsätzeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(852, 879);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.tbApiKey);
            this.splitContainer2.Panel2.Controls.Add(this.tbAdresse);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.tbSachverhalt);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.cbEinsatzstichwort);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.dtpEinsatzbeginn);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.tbEinsatznummer);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(910, 879);
            this.splitContainer2.SplitterDistance = 467;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "Alarmdurchsage", true));
            this.textBox5.Location = new System.Drawing.Point(207, 277);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(455, 22);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "ApiKey", true));
            this.textBox4.Location = new System.Drawing.Point(207, 188);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(455, 80);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "Adresse", true));
            this.textBox3.Location = new System.Drawing.Point(207, 156);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(455, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "Sachverhalt", true));
            this.textBox2.Location = new System.Drawing.Point(207, 124);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(455, 22);
            this.textBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "Einsatzstichwort", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "F BMA",
            "F BUS Y",
            "F FLUG 1 Y",
            "F FLUG 2 Y",
            "F GAS 1",
            "F GAS 2",
            "F LKW",
            "F RWM",
            "F SCHIFF 1",
            "F SCHIFF 2",
            "F SCHIFF GEFAHR",
            "F SCHIFF 2 Y",
            "F SCHIFF 3",
            "F WALD 1",
            "F WALD 2",
            "F ZUG",
            "F ZUG Y",
            "F1",
            "F2",
            "F2 - DACHSTUHL",
            "F2Y",
            "F3",
            "F3Y",
            "F4",
            "H ABST Y",
            "H EINST Y",
            "H ELEK",
            "H FLUSS",
            "H FLUSS Y",
            "H GAS 1",
            "H GAS 2",
            "H GEFAHR 1",
            "H GEFAHR 2",
            "H KLEMM 1 Y",
            "H KLEMM 2 Y",
            "H ÖL FLUSS",
            "H ÖL WASS",
            "H RADIOAKTIV",
            "H SCHIFF",
            "H TIER",
            "H WASS",
            "H WASS Y",
            "H ZUG 1 Y",
            "H ZUG 2 Y",
            "H1",
            "H1 - Fahrbahneinschr",
            "H1 - First Responder",
            "H1 - Personensuche",
            "H1 - THL einfach",
            "H1 - Überschwemmung",
            "H1 Y - DLK",
            "H1 Y - TÜR",
            "H2",
            "H1Y",
            "Ü",
            "RTZ-Einsatz"});
            this.comboBox1.Location = new System.Drawing.Point(207, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEinsätzeBindingSource, "Einsatzbeginn", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "Einsatznummer", true));
            this.textBox1.Location = new System.Drawing.Point(207, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(4, 281);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Alarmdurchsage:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Api-Key (Connect): *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Adresse: *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sachverhalt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Stichwort: *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Einsatzbeginn: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Einsatznummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbEinsatzId);
            this.groupBox2.Controls.Add(this.btAlarm);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(910, 467);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ausgewälten Einsatz bearbeiten";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BF_Tag_Alarmtool.Properties.Resources._88x31;
            this.pictureBox1.Location = new System.Drawing.Point(795, 421);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 357);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(795, 102);
            this.label17.TabIndex = 26;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "DB-ID:";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::BF_Tag_Alarmtool.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(672, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbEinsatzId
            // 
            this.tbEinsatzId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEinsätzeBindingSource, "EinsatzId", true));
            this.tbEinsatzId.Enabled = false;
            this.tbEinsatzId.Location = new System.Drawing.Point(404, 27);
            this.tbEinsatzId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEinsatzId.Name = "tbEinsatzId";
            this.tbEinsatzId.Size = new System.Drawing.Size(68, 22);
            this.tbEinsatzId.TabIndex = 1;
            // 
            // btAlarm
            // 
            this.btAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlarm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAlarm.FlatAppearance.BorderSize = 5;
            this.btAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarm.ForeColor = System.Drawing.Color.Red;
            this.btAlarm.Image = global::BF_Tag_Alarmtool.Properties.Resources.turn_notifications_on_button;
            this.btAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlarm.Location = new System.Drawing.Point(207, 309);
            this.btAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(172, 44);
            this.btAlarm.TabIndex = 0;
            this.btAlarm.Text = "Jetzt alarmieren";
            this.btAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.BtAlarm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Api-Key (Connect): *";
            // 
            // tbApiKey
            // 
            this.tbApiKey.BackColor = System.Drawing.Color.White;
            this.tbApiKey.Location = new System.Drawing.Point(207, 176);
            this.tbApiKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApiKey.Multiline = true;
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(455, 80);
            this.tbApiKey.TabIndex = 11;
            // 
            // tbAdresse
            // 
            this.tbAdresse.BackColor = System.Drawing.Color.White;
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(207, 144);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(455, 23);
            this.tbAdresse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresse: *";
            // 
            // tbSachverhalt
            // 
            this.tbSachverhalt.BackColor = System.Drawing.Color.White;
            this.tbSachverhalt.Location = new System.Drawing.Point(207, 112);
            this.tbSachverhalt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSachverhalt.Name = "tbSachverhalt";
            this.tbSachverhalt.Size = new System.Drawing.Size(455, 22);
            this.tbSachverhalt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sachverhalt:";
            // 
            // cbEinsatzstichwort
            // 
            this.cbEinsatzstichwort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEinsatzstichwort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEinsatzstichwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEinsatzstichwort.FormattingEnabled = true;
            this.cbEinsatzstichwort.Items.AddRange(new object[] {
            "F BMA",
            "F BUS Y",
            "F FLUG 1 Y",
            "F FLUG 2 Y",
            "F GAS 1",
            "F GAS 2",
            "F LKW",
            "F RWM",
            "F SCHIFF 1",
            "F SCHIFF 2",
            "F SCHIFF GEFAHR",
            "F SCHIFF 2 Y",
            "F SCHIFF 3",
            "F WALD 1",
            "F WALD 2",
            "F ZUG",
            "F ZUG Y",
            "F1",
            "F2",
            "F2 - DACHSTUHL",
            "F2Y",
            "F3",
            "F3Y",
            "F4",
            "H ABST Y",
            "H EINST Y",
            "H ELEK",
            "H FLUSS",
            "H FLUSS Y",
            "H GAS 1",
            "H GAS 2",
            "H GEFAHR 1",
            "H GEFAHR 2",
            "H KLEMM 1 Y",
            "H KLEMM 2 Y",
            "H ÖL FLUSS",
            "H ÖL WASS",
            "H RADIOAKTIV",
            "H SCHIFF",
            "H TIER",
            "H WASS",
            "H WASS Y",
            "H ZUG 1 Y",
            "H ZUG 2 Y",
            "H1",
            "H1 - Fahrbahneinschr",
            "H1 - First Responder",
            "H1 - Personensuche",
            "H1 - THL einfach",
            "H1 - Überschwemmung",
            "H1 Y - DLK",
            "H1 Y - TÜR",
            "H2",
            "H1Y",
            "Ü",
            "RTZ-Einsatz"});
            this.cbEinsatzstichwort.Location = new System.Drawing.Point(207, 79);
            this.cbEinsatzstichwort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEinsatzstichwort.Name = "cbEinsatzstichwort";
            this.cbEinsatzstichwort.Size = new System.Drawing.Size(265, 25);
            this.cbEinsatzstichwort.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stichwort: *";
            // 
            // dtpEinsatzbeginn
            // 
            this.dtpEinsatzbeginn.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtpEinsatzbeginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEinsatzbeginn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEinsatzbeginn.Location = new System.Drawing.Point(207, 47);
            this.dtpEinsatzbeginn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEinsatzbeginn.Name = "dtpEinsatzbeginn";
            this.dtpEinsatzbeginn.Size = new System.Drawing.Size(265, 23);
            this.dtpEinsatzbeginn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Einsatzbeginn: *";
            // 
            // tbEinsatznummer
            // 
            this.tbEinsatznummer.BackColor = System.Drawing.Color.White;
            this.tbEinsatznummer.Location = new System.Drawing.Point(207, 15);
            this.tbEinsatznummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEinsatznummer.Name = "tbEinsatznummer";
            this.tbEinsatznummer.Size = new System.Drawing.Size(132, 22);
            this.tbEinsatznummer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Einsatznummer:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.btNeuerEinsatz);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbAlarmdurchsage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(910, 407);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuen Einsatz erstellen";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(204, 357);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(351, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Die mit * gekennzeichneten Felder müssen ausgefüllt sein!";
            // 
            // btSearch
            // 
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Image = global::BF_Tag_Alarmtool.Properties.Resources.search;
            this.btSearch.Location = new System.Drawing.Point(672, 265);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(49, 43);
            this.btSearch.TabIndex = 15;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // btNeuerEinsatz
            // 
            this.btNeuerEinsatz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNeuerEinsatz.ForeColor = System.Drawing.Color.Black;
            this.btNeuerEinsatz.Image = global::BF_Tag_Alarmtool.Properties.Resources.add_button_inside_black_circle;
            this.btNeuerEinsatz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNeuerEinsatz.Location = new System.Drawing.Point(207, 311);
            this.btNeuerEinsatz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNeuerEinsatz.Name = "btNeuerEinsatz";
            this.btNeuerEinsatz.Size = new System.Drawing.Size(172, 42);
            this.btNeuerEinsatz.TabIndex = 0;
            this.btNeuerEinsatz.Text = "Einsatz erstellen!";
            this.btNeuerEinsatz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNeuerEinsatz.UseVisualStyleBackColor = true;
            this.btNeuerEinsatz.Click += new System.EventHandler(this.BtNeuerEinsatz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alarmdurchsage:";
            // 
            // tbAlarmdurchsage
            // 
            this.tbAlarmdurchsage.BackColor = System.Drawing.Color.White;
            this.tbAlarmdurchsage.Location = new System.Drawing.Point(208, 265);
            this.tbAlarmdurchsage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAlarmdurchsage.Name = "tbAlarmdurchsage";
            this.tbAlarmdurchsage.Size = new System.Drawing.Size(455, 22);
            this.tbAlarmdurchsage.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // einsatzIdDataGridViewTextBoxColumn
            // 
            this.einsatzIdDataGridViewTextBoxColumn.DataPropertyName = "EinsatzId";
            this.einsatzIdDataGridViewTextBoxColumn.HeaderText = "EinsatzId";
            this.einsatzIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.einsatzIdDataGridViewTextBoxColumn.Name = "einsatzIdDataGridViewTextBoxColumn";
            this.einsatzIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.einsatzIdDataGridViewTextBoxColumn.Visible = false;
            this.einsatzIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // apiKeyDataGridViewTextBoxColumn
            // 
            this.apiKeyDataGridViewTextBoxColumn.DataPropertyName = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn.HeaderText = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apiKeyDataGridViewTextBoxColumn.Name = "apiKeyDataGridViewTextBoxColumn";
            this.apiKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.apiKeyDataGridViewTextBoxColumn.Visible = false;
            this.apiKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // einsatzbeginnDataGridViewTextBoxColumn
            // 
            this.einsatzbeginnDataGridViewTextBoxColumn.DataPropertyName = "Einsatzbeginn";
            this.einsatzbeginnDataGridViewTextBoxColumn.DividerWidth = 10;
            this.einsatzbeginnDataGridViewTextBoxColumn.HeaderText = "Einsatzbeginn";
            this.einsatzbeginnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.einsatzbeginnDataGridViewTextBoxColumn.Name = "einsatzbeginnDataGridViewTextBoxColumn";
            this.einsatzbeginnDataGridViewTextBoxColumn.ReadOnly = true;
            this.einsatzbeginnDataGridViewTextBoxColumn.Width = 125;
            // 
            // einsatzstichwortDataGridViewTextBoxColumn
            // 
            this.einsatzstichwortDataGridViewTextBoxColumn.DataPropertyName = "Einsatzstichwort";
            this.einsatzstichwortDataGridViewTextBoxColumn.HeaderText = "Einsatzstichwort";
            this.einsatzstichwortDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.einsatzstichwortDataGridViewTextBoxColumn.Name = "einsatzstichwortDataGridViewTextBoxColumn";
            this.einsatzstichwortDataGridViewTextBoxColumn.ReadOnly = true;
            this.einsatzstichwortDataGridViewTextBoxColumn.Width = 125;
            // 
            // sachverhaltDataGridViewTextBoxColumn
            // 
            this.sachverhaltDataGridViewTextBoxColumn.DataPropertyName = "Sachverhalt";
            this.sachverhaltDataGridViewTextBoxColumn.HeaderText = "Sachverhalt";
            this.sachverhaltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sachverhaltDataGridViewTextBoxColumn.Name = "sachverhaltDataGridViewTextBoxColumn";
            this.sachverhaltDataGridViewTextBoxColumn.ReadOnly = true;
            this.sachverhaltDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // einsatznummerDataGridViewTextBoxColumn
            // 
            this.einsatznummerDataGridViewTextBoxColumn.DataPropertyName = "Einsatznummer";
            this.einsatznummerDataGridViewTextBoxColumn.HeaderText = "Einsatznummer";
            this.einsatznummerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.einsatznummerDataGridViewTextBoxColumn.Name = "einsatznummerDataGridViewTextBoxColumn";
            this.einsatznummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.einsatznummerDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAlarmiertDataGridViewCheckBoxColumn
            // 
            this.isAlarmiertDataGridViewCheckBoxColumn.DataPropertyName = "isAlarmiert";
            this.isAlarmiertDataGridViewCheckBoxColumn.HeaderText = "isAlarmiert";
            this.isAlarmiertDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isAlarmiertDataGridViewCheckBoxColumn.Name = "isAlarmiertDataGridViewCheckBoxColumn";
            this.isAlarmiertDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAlarmiertDataGridViewCheckBoxColumn.Width = 125;
            // 
            // alarmdurchsageDataGridViewTextBoxColumn
            // 
            this.alarmdurchsageDataGridViewTextBoxColumn.DataPropertyName = "Alarmdurchsage";
            this.alarmdurchsageDataGridViewTextBoxColumn.HeaderText = "Alarmdurchsage";
            this.alarmdurchsageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmdurchsageDataGridViewTextBoxColumn.Name = "alarmdurchsageDataGridViewTextBoxColumn";
            this.alarmdurchsageDataGridViewTextBoxColumn.ReadOnly = true;
            this.alarmdurchsageDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblEinsätzeBindingSource
            // 
            this.tblEinsätzeBindingSource.DataMember = "tblEinsätze";
            this.tblEinsätzeBindingSource.DataSource = this.einsätze;
            // 
            // einsätze
            // 
            this.einsätze.DataSetName = "Einsätze";
            this.einsätze.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 879);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Berufsfeuerwehrtag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEinsätzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.einsätze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource tblEinsätzeBindingSource;
        private Einsätze einsätze;
        private System.Windows.Forms.Button btNeuerEinsatz;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DateTimePicker dtpEinsatzbeginn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEinsatznummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEinsatzstichwort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSachverhalt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbAlarmdurchsage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAlarm;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbEinsatzId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn einsatzIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apiKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einsatzbeginnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einsatzstichwortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachverhaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einsatznummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAlarmiertDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmdurchsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
    }
}

