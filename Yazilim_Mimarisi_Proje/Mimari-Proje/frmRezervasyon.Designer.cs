
namespace Mimari_Proje
{
    partial class frmRezervasyon
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.dtpGidis = new System.Windows.Forms.DateTimePicker();
            this.dtpDonus = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvKonaklama = new System.Windows.Forms.DataGridView();
            this.dgvUlasim = new System.Windows.Forms.DataGridView();
            this.btnRezervasyonOnizle = new System.Windows.Forms.Button();
            this.rdbUcak = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grpUlasim = new System.Windows.Forms.GroupBox();
            this.grpKonaklama = new System.Windows.Forms.GroupBox();
            this.rdbÇadır = new System.Windows.Forms.RadioButton();
            this.rdbOtel = new System.Windows.Forms.RadioButton();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblGidisTarihi = new System.Windows.Forms.Label();
            this.lblDonus = new System.Windows.Forms.Label();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblIsım = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatulasim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonaklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlasim)).BeginInit();
            this.grpUlasim.SuspendLayout();
            this.grpKonaklama.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKonum
            // 
            this.cmbKonum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            this.cmbKonum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Items.AddRange(new object[] {
            "Fethiye",
            "Bodrum",
            "Marmaris"});
            this.cmbKonum.Location = new System.Drawing.Point(216, 313);
            this.cmbKonum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(306, 30);
            this.cmbKonum.TabIndex = 0;
            // 
            // dtpGidis
            // 
            this.dtpGidis.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpGidis.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.dtpGidis.Location = new System.Drawing.Point(216, 368);
            this.dtpGidis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGidis.Name = "dtpGidis";
            this.dtpGidis.Size = new System.Drawing.Size(306, 29);
            this.dtpGidis.TabIndex = 1;
            // 
            // dtpDonus
            // 
            this.dtpDonus.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.dtpDonus.Location = new System.Drawing.Point(216, 418);
            this.dtpDonus.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDonus.Name = "dtpDonus";
            this.dtpDonus.Size = new System.Drawing.Size(306, 29);
            this.dtpDonus.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Location = new System.Drawing.Point(251, 600);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(271, 67);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Seçenekleri Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvKonaklama
            // 
            this.dgvKonaklama.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonaklama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKonaklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonaklama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirmaAdi,
            this.Fiyat,
            this.toplamFiyat});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonaklama.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKonaklama.GridColor = System.Drawing.Color.LightCoral;
            this.dgvKonaklama.Location = new System.Drawing.Point(557, 66);
            this.dgvKonaklama.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKonaklama.Name = "dgvKonaklama";
            this.dgvKonaklama.RowHeadersWidth = 51;
            this.dgvKonaklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvKonaklama.Size = new System.Drawing.Size(623, 245);
            this.dgvKonaklama.TabIndex = 4;
            // 
            // dgvUlasim
            // 
            this.dgvUlasim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUlasim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUlasim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUlasim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.fiyatulasim});
            this.dgvUlasim.GridColor = System.Drawing.Color.LightCoral;
            this.dgvUlasim.Location = new System.Drawing.Point(557, 319);
            this.dgvUlasim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUlasim.Name = "dgvUlasim";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUlasim.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUlasim.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.dgvUlasim.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUlasim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUlasim.Size = new System.Drawing.Size(623, 255);
            this.dgvUlasim.TabIndex = 5;
            // 
            // btnRezervasyonOnizle
            // 
            this.btnRezervasyonOnizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.btnRezervasyonOnizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonOnizle.Location = new System.Drawing.Point(909, 600);
            this.btnRezervasyonOnizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervasyonOnizle.Name = "btnRezervasyonOnizle";
            this.btnRezervasyonOnizle.Size = new System.Drawing.Size(271, 67);
            this.btnRezervasyonOnizle.TabIndex = 6;
            this.btnRezervasyonOnizle.Text = "Rezervasyonu Önizle";
            this.btnRezervasyonOnizle.UseVisualStyleBackColor = false;
            this.btnRezervasyonOnizle.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // rdbUcak
            // 
            this.rdbUcak.AutoSize = true;
            this.rdbUcak.Location = new System.Drawing.Point(17, 38);
            this.rdbUcak.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUcak.Name = "rdbUcak";
            this.rdbUcak.Size = new System.Drawing.Size(72, 24);
            this.rdbUcak.TabIndex = 7;
            this.rdbUcak.TabStop = true;
            this.rdbUcak.Text = "Uçak";
            this.rdbUcak.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(111, 38);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Otobüs";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grpUlasim
            // 
            this.grpUlasim.Controls.Add(this.rdbUcak);
            this.grpUlasim.Controls.Add(this.radioButton2);
            this.grpUlasim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUlasim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUlasim.ForeColor = System.Drawing.Color.Ivory;
            this.grpUlasim.Location = new System.Drawing.Point(307, 494);
            this.grpUlasim.Margin = new System.Windows.Forms.Padding(4);
            this.grpUlasim.Name = "grpUlasim";
            this.grpUlasim.Padding = new System.Windows.Forms.Padding(4);
            this.grpUlasim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpUlasim.Size = new System.Drawing.Size(215, 80);
            this.grpUlasim.TabIndex = 9;
            this.grpUlasim.TabStop = false;
            this.grpUlasim.Text = "Ulaşım Yöntemi";
            // 
            // grpKonaklama
            // 
            this.grpKonaklama.Controls.Add(this.rdbÇadır);
            this.grpKonaklama.Controls.Add(this.rdbOtel);
            this.grpKonaklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpKonaklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKonaklama.ForeColor = System.Drawing.Color.Ivory;
            this.grpKonaklama.Location = new System.Drawing.Point(71, 494);
            this.grpKonaklama.Margin = new System.Windows.Forms.Padding(4);
            this.grpKonaklama.Name = "grpKonaklama";
            this.grpKonaklama.Padding = new System.Windows.Forms.Padding(4);
            this.grpKonaklama.Size = new System.Drawing.Size(215, 80);
            this.grpKonaklama.TabIndex = 10;
            this.grpKonaklama.TabStop = false;
            this.grpKonaklama.Text = "Konaklama Şekli";
            // 
            // rdbÇadır
            // 
            this.rdbÇadır.AutoSize = true;
            this.rdbÇadır.Location = new System.Drawing.Point(124, 37);
            this.rdbÇadır.Margin = new System.Windows.Forms.Padding(4);
            this.rdbÇadır.Name = "rdbÇadır";
            this.rdbÇadır.Size = new System.Drawing.Size(75, 24);
            this.rdbÇadır.TabIndex = 12;
            this.rdbÇadır.TabStop = true;
            this.rdbÇadır.Text = "Çadır";
            this.rdbÇadır.UseVisualStyleBackColor = true;
            // 
            // rdbOtel
            // 
            this.rdbOtel.AutoSize = true;
            this.rdbOtel.Location = new System.Drawing.Point(16, 37);
            this.rdbOtel.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOtel.Name = "rdbOtel";
            this.rdbOtel.Size = new System.Drawing.Size(65, 24);
            this.rdbOtel.TabIndex = 11;
            this.rdbOtel.TabStop = true;
            this.rdbOtel.Text = "Otel";
            this.rdbOtel.UseVisualStyleBackColor = true;
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(58, 313);
            this.lblSehir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(144, 22);
            this.lblSehir.TabIndex = 11;
            this.lblSehir.Text = "Tatil Konum :";
            // 
            // lblGidisTarihi
            // 
            this.lblGidisTarihi.AutoSize = true;
            this.lblGidisTarihi.Location = new System.Drawing.Point(58, 373);
            this.lblGidisTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGidisTarihi.Name = "lblGidisTarihi";
            this.lblGidisTarihi.Size = new System.Drawing.Size(138, 22);
            this.lblGidisTarihi.TabIndex = 12;
            this.lblGidisTarihi.Text = "Gidiş Tarihi :";
            // 
            // lblDonus
            // 
            this.lblDonus.AutoSize = true;
            this.lblDonus.Location = new System.Drawing.Point(58, 424);
            this.lblDonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonus.Name = "lblDonus";
            this.lblDonus.Size = new System.Drawing.Size(151, 22);
            this.lblDonus.TabIndex = 13;
            this.lblDonus.Text = "Dönüş Tarihi :";
            // 
            // txtIsım
            // 
            this.txtIsım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            this.txtIsım.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.txtIsım.Location = new System.Drawing.Point(216, 157);
            this.txtIsım.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(306, 29);
            this.txtIsım.TabIndex = 14;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            this.txtSoyisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.txtSoyisim.Location = new System.Drawing.Point(216, 209);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(306, 29);
            this.txtSoyisim.TabIndex = 15;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(127)))), ((int)(((byte)(132)))));
            this.txtTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.txtTC.Location = new System.Drawing.Point(216, 261);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(306, 29);
            this.txtTC.TabIndex = 16;
            // 
            // lblIsım
            // 
            this.lblIsım.AutoSize = true;
            this.lblIsım.Location = new System.Drawing.Point(58, 161);
            this.lblIsım.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsım.Name = "lblIsım";
            this.lblIsım.Size = new System.Drawing.Size(69, 22);
            this.lblIsım.TabIndex = 17;
            this.lblIsım.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Soyisim :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(58, 262);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(82, 22);
            this.lblTC.TabIndex = 19;
            this.lblTC.Text = "T.C No:";
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.BackColor = System.Drawing.Color.Transparent;
            this.labelBaslik.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(164)))), ((int)(((byte)(176)))));
            this.labelBaslik.Location = new System.Drawing.Point(67, 53);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(453, 63);
            this.labelBaslik.TabIndex = 20;
            this.labelBaslik.Text = "Rezervasyon Sistemi";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Gidiş Saati";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dönüş Saati";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // fiyatulasim
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.fiyatulasim.DefaultCellStyle = dataGridViewCellStyle8;
            this.fiyatulasim.HeaderText = "Fiyat";
            this.fiyatulasim.MinimumWidth = 6;
            this.fiyatulasim.Name = "fiyatulasim";
            this.fiyatulasim.Width = 150;
            // 
            // FirmaAdi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.FirmaAdi.DefaultCellStyle = dataGridViewCellStyle2;
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.MinimumWidth = 6;
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.Width = 190;
            // 
            // Fiyat
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Ivory;
            this.Fiyat.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fiyat.HeaderText = "Gecelik Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 190;
            // 
            // toplamFiyat
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.toplamFiyat.DefaultCellStyle = dataGridViewCellStyle4;
            this.toplamFiyat.HeaderText = "Toplam Fiyat";
            this.toplamFiyat.MinimumWidth = 6;
            this.toplamFiyat.Name = "toplamFiyat";
            this.toplamFiyat.Width = 190;
            // 
            // frmRezervasyon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1219, 706);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIsım);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.lblDonus);
            this.Controls.Add(this.lblGidisTarihi);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.grpKonaklama);
            this.Controls.Add(this.grpUlasim);
            this.Controls.Add(this.btnRezervasyonOnizle);
            this.Controls.Add(this.dgvUlasim);
            this.Controls.Add(this.dgvKonaklama);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtpDonus);
            this.Controls.Add(this.dtpGidis);
            this.Controls.Add(this.cmbKonum);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Ivory;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezervasyon";
            this.Text = "Rezervasyon Sistemi";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonaklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlasim)).EndInit();
            this.grpUlasim.ResumeLayout(false);
            this.grpUlasim.PerformLayout();
            this.grpKonaklama.ResumeLayout(false);
            this.grpKonaklama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.DateTimePicker dtpGidis;
        private System.Windows.Forms.DateTimePicker dtpDonus;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvKonaklama;
        private System.Windows.Forms.DataGridView dgvUlasim;
        private System.Windows.Forms.Button btnRezervasyonOnizle;
        private System.Windows.Forms.RadioButton rdbUcak;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox grpUlasim;
        private System.Windows.Forms.GroupBox grpKonaklama;
        private System.Windows.Forms.RadioButton rdbÇadır;
        private System.Windows.Forms.RadioButton rdbOtel;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblGidisTarihi;
        private System.Windows.Forms.Label lblDonus;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblIsım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatulasim;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamFiyat;
    }
}

