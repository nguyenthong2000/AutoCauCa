
namespace AutoCauCa
{
    partial class AutoPlayTogether
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_loaigialap = new System.Windows.Forms.Label();
            this.cbb_gialap = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numdelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_cancau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_pid = new System.Windows.Forms.Label();
            this.lb_titlepid = new System.Windows.Forms.Label();
            this.bt_batdau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tangtocdo = new System.Windows.Forms.CheckBox();
            this.cb_locbongca = new System.Windows.Forms.CheckBox();
            this.lb_trangthaikichhoat = new System.Windows.Forms.Label();
            this.cbb_bongca = new System.Windows.Forms.ComboBox();
            this.bt_kichhoat = new System.Windows.Forms.Button();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdelay)).BeginInit();
            this.gb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 226);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 380;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HWND";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PID";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 206;
            // 
            // lb_loaigialap
            // 
            this.lb_loaigialap.AutoSize = true;
            this.lb_loaigialap.Location = new System.Drawing.Point(37, 251);
            this.lb_loaigialap.Name = "lb_loaigialap";
            this.lb_loaigialap.Size = new System.Drawing.Size(43, 13);
            this.lb_loaigialap.TabIndex = 5;
            this.lb_loaigialap.Text = "Giả lập:";
            // 
            // cbb_gialap
            // 
            this.cbb_gialap.FormattingEnabled = true;
            this.cbb_gialap.Location = new System.Drawing.Point(127, 251);
            this.cbb_gialap.Name = "cbb_gialap";
            this.cbb_gialap.Size = new System.Drawing.Size(121, 21);
            this.cbb_gialap.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numdelay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbb_cancau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_pid);
            this.groupBox1.Controls.Add(this.lb_titlepid);
            this.groupBox1.Controls.Add(this.bt_batdau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_tangtocdo);
            this.groupBox1.Controls.Add(this.cb_locbongca);
            this.groupBox1.Controls.Add(this.lb_trangthaikichhoat);
            this.groupBox1.Controls.Add(this.cbb_bongca);
            this.groupBox1.Controls.Add(this.bt_kichhoat);
            this.groupBox1.Location = new System.Drawing.Point(254, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numdelay
            // 
            this.numdelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numdelay.Location = new System.Drawing.Point(413, 18);
            this.numdelay.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numdelay.Name = "numdelay";
            this.numdelay.Size = new System.Drawing.Size(106, 20);
            this.numdelay.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Độ trễ (ms) :";
            // 
            // cbb_cancau
            // 
            this.cbb_cancau.FormattingEnabled = true;
            this.cbb_cancau.Location = new System.Drawing.Point(214, 63);
            this.cbb_cancau.Name = "cbb_cancau";
            this.cbb_cancau.Size = new System.Drawing.Size(106, 21);
            this.cbb_cancau.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cần câu:";
            // 
            // lb_pid
            // 
            this.lb_pid.AutoSize = true;
            this.lb_pid.Location = new System.Drawing.Point(62, 20);
            this.lb_pid.Name = "lb_pid";
            this.lb_pid.Size = new System.Drawing.Size(0, 13);
            this.lb_pid.TabIndex = 14;
            // 
            // lb_titlepid
            // 
            this.lb_titlepid.AutoSize = true;
            this.lb_titlepid.Location = new System.Drawing.Point(28, 20);
            this.lb_titlepid.Name = "lb_titlepid";
            this.lb_titlepid.Size = new System.Drawing.Size(28, 13);
            this.lb_titlepid.TabIndex = 13;
            this.lb_titlepid.Text = "PID:";
            // 
            // bt_batdau
            // 
            this.bt_batdau.Location = new System.Drawing.Point(346, 104);
            this.bt_batdau.Name = "bt_batdau";
            this.bt_batdau.Size = new System.Drawing.Size(173, 48);
            this.bt_batdau.TabIndex = 11;
            this.bt_batdau.Text = "Bắt Đầu";
            this.bt_batdau.UseVisualStyleBackColor = true;
            this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bóng cá:";
            // 
            // cb_tangtocdo
            // 
            this.cb_tangtocdo.AutoSize = true;
            this.cb_tangtocdo.Location = new System.Drawing.Point(28, 85);
            this.cb_tangtocdo.Name = "cb_tangtocdo";
            this.cb_tangtocdo.Size = new System.Drawing.Size(85, 17);
            this.cb_tangtocdo.TabIndex = 9;
            this.cb_tangtocdo.Text = "Tăng tốc độ";
            this.cb_tangtocdo.UseVisualStyleBackColor = true;
            // 
            // cb_locbongca
            // 
            this.cb_locbongca.AutoSize = true;
            this.cb_locbongca.Location = new System.Drawing.Point(28, 52);
            this.cb_locbongca.Name = "cb_locbongca";
            this.cb_locbongca.Size = new System.Drawing.Size(86, 17);
            this.cb_locbongca.TabIndex = 8;
            this.cb_locbongca.Text = "Lọc bóng cá";
            this.cb_locbongca.UseVisualStyleBackColor = true;
            // 
            // lb_trangthaikichhoat
            // 
            this.lb_trangthaikichhoat.AutoSize = true;
            this.lb_trangthaikichhoat.Location = new System.Drawing.Point(25, 132);
            this.lb_trangthaikichhoat.Name = "lb_trangthaikichhoat";
            this.lb_trangthaikichhoat.Size = new System.Drawing.Size(81, 13);
            this.lb_trangthaikichhoat.TabIndex = 7;
            this.lb_trangthaikichhoat.Text = "Chưa kích hoạt";
            // 
            // cbb_bongca
            // 
            this.cbb_bongca.FormattingEnabled = true;
            this.cbb_bongca.Location = new System.Drawing.Point(214, 14);
            this.cbb_bongca.Name = "cbb_bongca";
            this.cbb_bongca.Size = new System.Drawing.Size(106, 21);
            this.cbb_bongca.TabIndex = 6;
            // 
            // bt_kichhoat
            // 
            this.bt_kichhoat.Location = new System.Drawing.Point(146, 104);
            this.bt_kichhoat.Name = "bt_kichhoat";
            this.bt_kichhoat.Size = new System.Drawing.Size(174, 48);
            this.bt_kichhoat.TabIndex = 4;
            this.bt_kichhoat.Text = "Kích hoạt";
            this.bt_kichhoat.UseVisualStyleBackColor = true;
            this.bt_kichhoat.Click += new System.EventHandler(this.bt_kichhoat_Click);
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_thongtin.Controls.Add(this.label7);
            this.gb_thongtin.Controls.Add(this.label4);
            this.gb_thongtin.Controls.Add(this.linkLabel1);
            this.gb_thongtin.Controls.Add(this.label3);
            this.gb_thongtin.Controls.Add(this.label2);
            this.gb_thongtin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_thongtin.Location = new System.Drawing.Point(12, 288);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Size = new System.Drawing.Size(236, 154);
            this.gb_thongtin.TabIndex = 9;
            this.gb_thongtin.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Không bản quyền.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miễn phí, Dùng thoải mái luôn.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(82, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nguyễn Thông";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Youtube:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tác giả: NT";
            // 
            // AutoPlayTogether
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_gialap);
            this.Controls.Add(this.lb_loaigialap);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "AutoPlayTogether";
            this.Text = "Auto Play Together";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdelay)).EndInit();
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lb_loaigialap;
        private System.Windows.Forms.ComboBox cbb_gialap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_kichhoat;
        private System.Windows.Forms.ComboBox cbb_bongca;
        private System.Windows.Forms.Button bt_batdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_tangtocdo;
        private System.Windows.Forms.CheckBox cb_locbongca;
        private System.Windows.Forms.Label lb_pid;
        private System.Windows.Forms.Label lb_titlepid;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numdelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_cancau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_trangthaikichhoat;
    }
}

