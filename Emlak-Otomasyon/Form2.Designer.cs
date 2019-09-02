namespace Emlak_Otomasyon
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbboxsite = new System.Windows.Forms.ComboBox();
            this.cmbboxsatkira = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboxoda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmertekare = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtnot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbboxblok = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnkırlnagıc = new System.Windows.Forms.Button();
            this.btnmasmavi = new System.Windows.Forms.Button();
            this.btnbahtiyar = new System.Windows.Forms.Button();
            this.btnasır = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngoruntule = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdaireno = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GayrimenkulBilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(798, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SİTE";
            // 
            // cmbboxsite
            // 
            this.cmbboxsite.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxsite.FormattingEnabled = true;
            this.cmbboxsite.Items.AddRange(new object[] {
            "Kırlangıç",
            "Masmavi",
            "Bahtiyarlar",
            "Asır"});
            this.cmbboxsite.Location = new System.Drawing.Point(94, 60);
            this.cmbboxsite.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxsite.Name = "cmbboxsite";
            this.cmbboxsite.Size = new System.Drawing.Size(160, 24);
            this.cmbboxsite.TabIndex = 2;
            this.cmbboxsite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbboxsatkira
            // 
            this.cmbboxsatkira.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxsatkira.FormattingEnabled = true;
            this.cmbboxsatkira.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cmbboxsatkira.Location = new System.Drawing.Point(94, 96);
            this.cmbboxsatkira.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxsatkira.Name = "cmbboxsatkira";
            this.cmbboxsatkira.Size = new System.Drawing.Size(160, 24);
            this.cmbboxsatkira.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat/Kira:";
            // 
            // cmboxoda
            // 
            this.cmboxoda.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxoda.FormattingEnabled = true;
            this.cmboxoda.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "1+2",
            "1+3",
            "1+4"});
            this.cmboxoda.Location = new System.Drawing.Point(94, 135);
            this.cmboxoda.Margin = new System.Windows.Forms.Padding(4);
            this.cmboxoda.Name = "cmboxoda";
            this.cmboxoda.Size = new System.Drawing.Size(160, 24);
            this.cmboxoda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "MetreKare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(444, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Notlar:";
            // 
            // txtmertekare
            // 
            this.txtmertekare.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmertekare.Location = new System.Drawing.Point(94, 167);
            this.txtmertekare.Name = "txtmertekare";
            this.txtmertekare.Size = new System.Drawing.Size(160, 21);
            this.txtmertekare.TabIndex = 10;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(94, 199);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(160, 21);
            this.txtfiyat.TabIndex = 11;
            // 
            // txtnot
            // 
            this.txtnot.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnot.Location = new System.Drawing.Point(509, 154);
            this.txtnot.Multiline = true;
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(160, 109);
            this.txtnot.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(506, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(432, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(509, 63);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(160, 21);
            this.txtad.TabIndex = 15;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(509, 111);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(160, 21);
            this.txttel.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(444, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Blok:";
            // 
            // cmbboxblok
            // 
            this.cmbboxblok.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxblok.FormattingEnabled = true;
            this.cmbboxblok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbboxblok.Location = new System.Drawing.Point(64, 239);
            this.cmbboxblok.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxblok.Name = "cmbboxblok";
            this.cmbboxblok.Size = new System.Drawing.Size(36, 24);
            this.cmbboxblok.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(122, 243);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "DaireNO:";
            // 
            // btnkırlnagıc
            // 
            this.btnkırlnagıc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnkırlnagıc.Location = new System.Drawing.Point(770, 63);
            this.btnkırlnagıc.Name = "btnkırlnagıc";
            this.btnkırlnagıc.Size = new System.Drawing.Size(91, 55);
            this.btnkırlnagıc.TabIndex = 22;
            this.btnkırlnagıc.Text = "KIRLANGIÇ";
            this.btnkırlnagıc.UseVisualStyleBackColor = false;
            // 
            // btnmasmavi
            // 
            this.btnmasmavi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnmasmavi.Location = new System.Drawing.Point(689, 122);
            this.btnmasmavi.Name = "btnmasmavi";
            this.btnmasmavi.Size = new System.Drawing.Size(85, 55);
            this.btnmasmavi.TabIndex = 23;
            this.btnmasmavi.Text = "MASMAVİ";
            this.btnmasmavi.UseVisualStyleBackColor = false;
            // 
            // btnbahtiyar
            // 
            this.btnbahtiyar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnbahtiyar.Location = new System.Drawing.Point(770, 182);
            this.btnbahtiyar.Name = "btnbahtiyar";
            this.btnbahtiyar.Size = new System.Drawing.Size(91, 55);
            this.btnbahtiyar.TabIndex = 24;
            this.btnbahtiyar.Text = "BAHTİYAR";
            this.btnbahtiyar.UseVisualStyleBackColor = false;
            // 
            // btnasır
            // 
            this.btnasır.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnasır.Location = new System.Drawing.Point(856, 122);
            this.btnasır.Name = "btnasır";
            this.btnasır.Size = new System.Drawing.Size(75, 55);
            this.btnasır.TabIndex = 25;
            this.btnasır.Text = "ASIR";
            this.btnasır.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(47, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Site:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Location = new System.Drawing.Point(23, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(903, 158);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "site";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "oda";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "metre";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "fiyat";
            this.columnHeader5.Width = 58;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "blok";
            this.columnHeader6.Width = 57;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "no";
            this.columnHeader7.Width = 59;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "adsoyad";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "telefon";
            this.columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "notlar";
            this.columnHeader10.Width = 144;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "satkira";
            // 
            // btngoruntule
            // 
            this.btngoruntule.Location = new System.Drawing.Point(51, 289);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(102, 36);
            this.btngoruntule.TabIndex = 28;
            this.btngoruntule.Text = "Görüntüle";
            this.btngoruntule.UseVisualStyleBackColor = true;
            this.btngoruntule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(42, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "İd:";
            // 
            // txtdaireno
            // 
            this.txtdaireno.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdaireno.Location = new System.Drawing.Point(193, 243);
            this.txtdaireno.Name = "txtdaireno";
            this.txtdaireno.Size = new System.Drawing.Size(54, 21);
            this.txtdaireno.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(94, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 21);
            this.txtid.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdaireno);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btngoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnasır);
            this.Controls.Add(this.btnbahtiyar);
            this.Controls.Add(this.btnmasmavi);
            this.Controls.Add(this.btnkırlnagıc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbboxblok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnot);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtmertekare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboxoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbboxsatkira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbboxsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbboxsite;
        private System.Windows.Forms.ComboBox cmbboxsatkira;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboxoda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmertekare;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtnot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbboxblok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnkırlnagıc;
        private System.Windows.Forms.Button btnmasmavi;
        private System.Windows.Forms.Button btnbahtiyar;
        private System.Windows.Forms.Button btnasır;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdaireno;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
    }
}