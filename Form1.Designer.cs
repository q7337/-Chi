
namespace HomeWork_LicenceTax
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AllYearRadioButton = new System.Windows.Forms.RadioButton();
            this.ForTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VehicleKindListBox1 = new System.Windows.Forms.ListBox();
            this.VolumeHorsepower = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalculationResult = new System.Windows.Forms.Label();
            this.SendCalculation = new System.Windows.Forms.Button();
            this.CencelAll = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllYearRadioButton
            // 
            this.AllYearRadioButton.AutoSize = true;
            this.AllYearRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.AllYearRadioButton.Location = new System.Drawing.Point(31, 31);
            this.AllYearRadioButton.Name = "AllYearRadioButton";
            this.AllYearRadioButton.Size = new System.Drawing.Size(93, 29);
            this.AllYearRadioButton.TabIndex = 0;
            this.AllYearRadioButton.TabStop = true;
            this.AllYearRadioButton.Text = "全年度";
            this.AllYearRadioButton.UseVisualStyleBackColor = true;
            this.AllYearRadioButton.CheckedChanged += new System.EventHandler(this.AllYearRadioButton_CheckedChanged);
            // 
            // ForTimeRadioButton
            // 
            this.ForTimeRadioButton.AutoSize = true;
            this.ForTimeRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.ForTimeRadioButton.Location = new System.Drawing.Point(142, 31);
            this.ForTimeRadioButton.Name = "ForTimeRadioButton";
            this.ForTimeRadioButton.Size = new System.Drawing.Size(93, 29);
            this.ForTimeRadioButton.TabIndex = 1;
            this.ForTimeRadioButton.TabStop = true;
            this.ForTimeRadioButton.Text = "依期間";
            this.ForTimeRadioButton.UseVisualStyleBackColor = true;
            this.ForTimeRadioButton.CheckedChanged += new System.EventHandler(this.ForTimeRadioButton_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(536, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "從";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(498, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "至";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllYearRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ForTimeRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(53, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用期間";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VehicleKindListBox1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(53, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 197);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "使用載具種類";
            // 
            // VehicleKindListBox1
            // 
            this.VehicleKindListBox1.FormattingEnabled = true;
            this.VehicleKindListBox1.ItemHeight = 25;
            this.VehicleKindListBox1.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業小客車"});
            this.VehicleKindListBox1.Location = new System.Drawing.Point(31, 33);
            this.VehicleKindListBox1.Name = "VehicleKindListBox1";
            this.VehicleKindListBox1.Size = new System.Drawing.Size(296, 154);
            this.VehicleKindListBox1.TabIndex = 9;
            this.VehicleKindListBox1.SelectedIndexChanged += new System.EventHandler(this.VehicleKindListBox1_SelectedIndexChanged_1);
            // 
            // VolumeHorsepower
            // 
            this.VolumeHorsepower.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VolumeHorsepower.FormattingEnabled = true;
            this.VolumeHorsepower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VolumeHorsepower.Items.AddRange(new object[] {
            "150以下"});
            this.VolumeHorsepower.Location = new System.Drawing.Point(31, 33);
            this.VolumeHorsepower.Name = "VolumeHorsepower";
            this.VolumeHorsepower.Size = new System.Drawing.Size(296, 33);
            this.VolumeHorsepower.TabIndex = 8;
            this.VolumeHorsepower.Text = "150以下";
            this.VolumeHorsepower.SelectedIndexChanged += new System.EventHandler(this.VolumeHorsepower_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VolumeHorsepower);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(53, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "汽缸容積/馬力功率";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(422, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 361);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "試算結果";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalculationResult);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 322);
            this.panel1.TabIndex = 1;
            // 
            // CalculationResult
            // 
            this.CalculationResult.AutoSize = true;
            this.CalculationResult.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalculationResult.ForeColor = System.Drawing.Color.Black;
            this.CalculationResult.Location = new System.Drawing.Point(3, 0);
            this.CalculationResult.Name = "CalculationResult";
            this.CalculationResult.Size = new System.Drawing.Size(22, 22);
            this.CalculationResult.TabIndex = 0;
            this.CalculationResult.Text = "...";
            this.CalculationResult.Click += new System.EventHandler(this.CalculationResult_Click);
            // 
            // SendCalculation
            // 
            this.SendCalculation.Location = new System.Drawing.Point(84, 513);
            this.SendCalculation.Name = "SendCalculation";
            this.SendCalculation.Size = new System.Drawing.Size(124, 52);
            this.SendCalculation.TabIndex = 11;
            this.SendCalculation.Text = "確定送出";
            this.SendCalculation.UseVisualStyleBackColor = true;
            this.SendCalculation.Click += new System.EventHandler(this.SendCalculation_Click);
            // 
            // CencelAll
            // 
            this.CencelAll.Location = new System.Drawing.Point(256, 513);
            this.CencelAll.Name = "CencelAll";
            this.CencelAll.Size = new System.Drawing.Size(124, 52);
            this.CencelAll.TabIndex = 12;
            this.CencelAll.Text = "取消重填";
            this.CencelAll.UseVisualStyleBackColor = true;
            this.CencelAll.Click += new System.EventHandler(this.CencelAll_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(808, 204);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 361);
            this.vScrollBar1.TabIndex = 13;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(233, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "使用牌照稅應納稅額試算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.CencelAll);
            this.Controls.Add(this.SendCalculation);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AllYearRadioButton;
        private System.Windows.Forms.RadioButton ForTimeRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox VehicleKindListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label CalculationResult;
        private System.Windows.Forms.Button SendCalculation;
        private System.Windows.Forms.Button CencelAll;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VolumeHorsepower;
    }
}

