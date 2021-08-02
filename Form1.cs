using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_LicenceTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point _startPoint;
        private void Initial()
        {
            AllYearRadioButton.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            VehicleKindListBox1.SelectedIndex = 0;
            VolumeHorsepower.SelectedIndex = 0;
            CalculationResult.Text = "...";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Initial();
            this._startPoint = this.CalculationResult.Location;
        }
        private void AllYearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllYearRadioButton.Checked)
            {
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.dateTimePicker1.Visible = false;
                this.dateTimePicker2.Visible = false;
            }
        }
        private void ForTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ForTimeRadioButton.Checked)
            {
                this.label1.Visible = true;
                this.label2.Visible = true;
                this.dateTimePicker1.Visible = true;
                this.dateTimePicker2.Visible = true;
            }
        }        
        private void VehicleKindListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string carType = this.VehicleKindListBox1.SelectedItem.ToString();
            this.VolumeHorsepower.Items.Clear();
            
            switch (carType)
            {
                case "機車":
                    this.VolumeHorsepower.Items.AddRange(new String[] { "150以下", "150~250", "251~500", "501~600", "601~1200", "1201~1800", "1801或以上" });
                    break;
                case "貨車":
                    this.VolumeHorsepower.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                    break;
                case "大客車":
                    this.VolumeHorsepower.Items.AddRange(new String[] { "600以下", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                    break;
                case "自用小客車":
                    this.VolumeHorsepower.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                    break;
                case "營業小客車":
                    this.VolumeHorsepower.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                    break;                
            }
            this.VolumeHorsepower.SelectedIndex = 0;
        }        
        private Decimal TexForYear()
        {
            if (this.VehicleKindListBox1.SelectedIndex == -1) return 0;

            int ct_index = this.VolumeHorsepower.SelectedIndex;
            string carType = this.VehicleKindListBox1.Text;
            string ccType = this.VolumeHorsepower.Text;

            decimal TexForYear = 0;

            switch (carType)
            {
                case "機車":
                    switch (ccType)
                    {
                        case "150~250":
                            TexForYear = 800;
                            break;
                        case "251~500":
                            TexForYear = 1620;
                            break;
                        case "501~600":
                            TexForYear = 2160;
                            break;
                        case "601~1200":
                            TexForYear = 4320;
                            break;
                        case "1201~1800":
                            TexForYear = 7120;
                            break;
                        case "1801或以上":
                            TexForYear = 11230;
                            break;
                    }
                    break;
                case "貨車":
                    switch (ccType)
                    {
                        case "500以下":
                            TexForYear = 900;
                            break;
                        case "501~600":
                            TexForYear = 1080;
                            break;
                        case "601~1200":
                            TexForYear = 1800;
                            break;
                        default:
                            ct_index -= 2;
                            TexForYear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;
                case "大客車":
                    switch (ccType)
                    {
                        case "600以下":
                            TexForYear = 1080;
                            break;
                        case "601~1200":
                            TexForYear = 1800;
                            break;
                        default:
                            ct_index -= 1;
                            TexForYear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;
                case "自用小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            TexForYear = 1620;
                            break;
                        case "501~600":
                            TexForYear = 2160;
                            break;
                        case "601~1200":
                            TexForYear = 4320;
                            break;
                        case "1201~1800":
                            TexForYear = 7120;
                            break;
                        case "1801~2400":
                            TexForYear = 11230;
                            break;
                        case "2401~3000":
                            TexForYear = 15210;
                            break;
                        case "3001~4200":
                            TexForYear = 28220;
                            break;
                        case "4201~5400":
                            TexForYear = 46170;
                            break;
                        case "5401~6600":
                            TexForYear = 69690;
                            break;
                        case "6601~7800":
                            TexForYear = 117000;
                            break;
                        case "7801以上":
                            TexForYear = 151200;
                            break;
                        default:
                            TexForYear = 1620;
                            break;
                    }
                    break;
                case "營業小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            TexForYear = 900;
                            break;
                        case "501~600":
                            TexForYear = 1260;
                            break;
                        case "601~1200":
                            TexForYear = 2160;
                            break;
                        case "1201~1800":
                            TexForYear = 3060;
                            break;
                        case "1801~2400":
                            TexForYear = 6480;
                            break;
                        case "2401~3000":
                            TexForYear = 9900;
                            break;
                        case "3001~4200":
                            TexForYear = 16380;
                            break;
                        case "4201~5400":
                            TexForYear = 24300;
                            break;
                        case "5401~6600":
                            TexForYear = 33660;
                            break;
                        case "6601~7800":
                            TexForYear = 44460;
                            break;
                        case "7801以上":
                            TexForYear = 56700;
                            break;
                        default:
                            TexForYear = 900;
                            break;
                    }
                    break;                

                default:
                    break;
            }
            return TexForYear;
        }        
        private void SendCalculation_Click(object sender, EventArgs e)
        {
            this.CalculationResult.Text = String.Empty; //洗白

            DateTime from_date = this.dateTimePicker1.Value;
            DateTime to_date = this.dateTimePicker2.Value;

            //測是否日期打反，打反則校正回歸
            if ((to_date - from_date).Days < 0)
            {
                this.dateTimePicker1.Value = to_date;
                this.dateTimePicker2.Value = from_date;
                from_date = this.dateTimePicker1.Value;
                to_date = this.dateTimePicker2.Value;
            }

            decimal dayofyear; //年計算的分母
            decimal taxperyear = TexForYear(); //取得年繳稅
            int subtract = to_date.Year - from_date.Year;

            if (ForTimeRadioButton.Checked) //使用者想要自訂日期
            {
                decimal daycnt;
                if (subtract == 0) //處理不足一年
                {
                    daycnt = (to_date - from_date).Days + 1;
                    if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                    else dayofyear = 365;

                    this.CalculationResult.Text += $"使用期間: {from_date.ToString("yyyy-MM-dd")} ~ {to_date.ToString("yyyy-MM-dd")}" +
                    $"\n計算天數: {daycnt}" +
                    $"\n汽缸CC數/馬力: {this.VolumeHorsepower.Text}" +
                    $"\n用途: {this.VehicleKindListBox1.SelectedItem}" +
                    $"\n計算公式: {taxperyear} * {daycnt}/{dayofyear}" +
                    $"\n應納稅額: {Math.Truncate(taxperyear * (daycnt / dayofyear))} 元";
                }
                else //使用者自訂很多年
                {

                    decimal total = 0;
                    for (int i = 0; i < subtract + 1; i++)
                    {
                        decimal tax_ans;
                        if (i == 0)//第一條不一定是一整年
                        {
                            if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                            else dayofyear = 365;
                            decimal temp = (new DateTime(from_date.Year + 1, 1, 1) - from_date).Days;
                            tax_ans = Math.Truncate(taxperyear * (temp / dayofyear));
                            total += tax_ans;
                            this.CalculationResult.Text += $"使用期間: {from_date.ToString("yyyy-MM-dd")} ~ {from_date.Year}-12-31" +
                            $"\n計算天數: {temp}" +
                            $"\n汽缸CC數/馬力: {this.VolumeHorsepower.Text}" +
                            $"\n用途: {this.VehicleKindListBox1.SelectedItem}" +
                            $"\n計算公式: {taxperyear} * {temp}/{dayofyear}" +
                            $"\n應納稅額: {tax_ans} 元";
                        }
                        else if (i == (subtract)) //最後一條
                        {
                            if (DateTime.IsLeapYear(to_date.Year)) dayofyear = 366;
                            else dayofyear = 365;
                            daycnt = (to_date - new DateTime(to_date.Year, 1, 1)).Days + 1;//使用者自訂的天數
                            tax_ans = Math.Truncate(taxperyear * (daycnt / dayofyear));
                            total += tax_ans;
                            this.CalculationResult.Text += $"\n\n使用期間: {to_date.Year}-1-1 ~ {to_date.ToString("yyyy-MM-dd")}" +
                            $"\n計算天數: {daycnt}" +
                            $"\n汽缸CC數/馬力: {this.VolumeHorsepower.Text}" +
                            $"\n用途: {this.VehicleKindListBox1.SelectedItem}" +
                            $"\n計算公式: {taxperyear} * {daycnt}/{dayofyear}" +
                            $"\n應納稅額: {tax_ans} 元";
                        }
                        else
                        {
                            if (DateTime.IsLeapYear(from_date.Year + i)) dayofyear = 366;
                            else dayofyear = 365;
                            total += taxperyear;
                            this.CalculationResult.Text += $"\n\n使用期間: {from_date.Year + i}-1-1 ~ {from_date.Year + i}-12-31" +
                            $"\n計算天數: {dayofyear}" +
                            $"\n汽缸CC數/馬力: {this.VolumeHorsepower.Text}" +
                            $"\n用途: {this.VehicleKindListBox1.SelectedItem}" +
                            $"\n計算公式: {taxperyear} * {dayofyear}/{dayofyear}" +
                            $"\n應納稅額: {taxperyear} 元";
                        }
                    }
                    if (subtract > 0) this.CalculationResult.Text += $"\n\n全部應納稅額: 共 {total} 元";
                }
            }
            else //使用者使用全年度
            {
                if (DateTime.IsLeapYear(from_date.Year)) dayofyear = 366;
                else dayofyear = 365;

                this.CalculationResult.Text = $"使用期間: {DateTime.Now.ToString("yyyy")}-01-01 ~ {DateTime.Now.ToString("yyyy")}-12-31" +
                $"\n計算天數: {dayofyear}" +
                $"\n汽缸CC數/馬力: {this.VolumeHorsepower.Text}" +
                $"\n用途: {this.VehicleKindListBox1.SelectedItem}" +
                $"\n計算公式: {taxperyear} * {dayofyear}/{dayofyear}" +
                $"\n應納稅額: {taxperyear} 元";
            }
            this.vScrollBar1.Maximum = this.CalculationResult.Text.Length * 5 / 3;

        }
        private void CencelAll_Click(object sender, EventArgs e)
        {
            Initial();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var newPoint = new Point(
           this.CalculationResult.Location.X,
           this._startPoint.Y - this.vScrollBar1.Value);
            this.CalculationResult.Location = newPoint;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){}
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e){}
        private void VolumeHorsepower_SelectedIndexChanged(object sender, EventArgs e){}
        private void CalculationResult_Click(object sender, EventArgs e){}       
        private void label1_Click(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
    }
}
