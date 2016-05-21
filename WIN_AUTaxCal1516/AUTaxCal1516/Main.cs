using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AUTaxCal1516
{
    public partial class Main : Form
    {
        TaxCalculation pTaxCal;
        public Main()
        {
            InitializeComponent();
            this.chart1.Series.Clear();
            //rdobtnBarChart.Checked = true;
            rdobtnBarChart.Enabled = false;
            rdobtnPieChart.Enabled = false;
            //chart1.Visible = false;
        }

        private void txtGrossAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double dGross = 0;
            //double dTexableAmout = 0;
            double dTax = 0;
            double dSuper = 0;
            double dTakeHome = 0;
            double dTaxPrcnt = 0;
            try
            {
                if (double.TryParse(txtGrossAmt.Text, out dGross))
                {
                    pTaxCal = new TaxCalculation();
                    pTaxCal.GrossAmount = dGross;
                    if (pTaxCal.Calculate())
                    {
                        dSuper = pTaxCal.AnnualSuper;
                        dTax = pTaxCal.AnnualTax;
                        dTakeHome = pTaxCal.AnnualtakeHome;
                        dTaxPrcnt = pTaxCal.TaxPercentagePaid;
                    }
                    //dSuper = dGross * 0.095; //9.5%
                    //while (dGross > 0)
                    //{
                    //    if (dGross <= 18200)
                    //    {
                    //        dTexableAmout = dGross - 0;
                    //        dTax = dTax + dTexableAmout * 0.0;
                    //        dGross = dGross - dTexableAmout;
                    //    }
                    //    else if (dGross > 18200 && dGross <= 37000)
                    //    {
                    //        dTexableAmout = dGross - 18200;
                    //        dTax = dTax + dTexableAmout * 0.19;
                    //        dGross = dGross - dTexableAmout;
                    //    }
                    //    else if (dGross > 37001 && dGross <= 80000)
                    //    {
                    //        dTexableAmout = dGross - 37000;
                    //        dTax = dTax + dTexableAmout * 0.325;
                    //        dGross = dGross - dTexableAmout;
                    //    }
                    //    else if (dGross > 80001 && dGross <= 180000)
                    //    {
                    //        dTexableAmout = dGross - 80000;
                    //        dTax = dTax + dTexableAmout * 0.37;
                    //        dGross = dGross - dTexableAmout;
                    //    }
                    //    else if (dGross > 180001)
                    //    {
                    //        dTexableAmout = dGross - 180000;
                    //        dTax = dTax + dTexableAmout * 0.45;
                    //        dGross = dGross - dTexableAmout;
                    //    }
                    //}
                    txtResult.Text = string.Format("Annual Tax:\t{0:C}\r\nMonthly Tax:\t{1:C}\r\nAnnual Super:\t{2:C}\r\nMonthly Super:\t{3:C}\r\nMonthly Take Home:\t{4:C}\r\nYearly Take Home:\t{5:C}\r\nTotal Tax Percentage Paid:\t{6:p1}",
                        dTax,dTax / 12,
                        dSuper,dSuper / 12,
                        dTakeHome/12,dTakeHome,
                        dTaxPrcnt);

                    double[] Parm = new double[4];
                    Parm[0] = Convert.ToDouble(txtGrossAmt.Text);
                    Parm[1] = dSuper;
                    Parm[2] = dTax;
                    Parm[3] = Parm[0] - dSuper - dTax;

                    rdobtnBarChart.Enabled = true;
                    rdobtnPieChart.Enabled = true;

                    if (rdobtnPieChart.Checked)
                        PlotGraphPie(Parm);
                    else
                        PlotGraphBar(Parm);
                }
                else
                    lblResult.Text = "Invalid Gross Income";
            }
            catch (Exception ex)
            { lblResult.Text = ex.Message; }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
        private void PlotGraphBar(double[] pointsArray)
        {
            chart1.ResetText();
            chart1.ResetAutoValues();
            this.chart1.Series.Clear();
            // Data arrays
            string[] seriesArray = { "Gross", "Super", "Tax", "Take Home" };

            // Set palette
            this.chart1.Palette = ChartColorPalette.BrightPastel;

            // Set title
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Tax Calculation");
            this.chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
                //series.ChartType = SeriesChartType.Column;
            }
        }
        private void PlotGraphPie(double[] pointsArray)
        {
            string[] seriesArray = { "Gross", "Super", "Tax", "Take Home" };
            this.chart1.Series.Clear();

            chart1.Palette = ChartColorPalette.EarthTones;
            chart1.BackColor = Color.LightYellow;
            this.chart1.Titles.Clear();
            chart1.Titles.Add("Tax Calculation");
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            Series series = new Series();
            series.IsVisibleInLegend = true;
            series.Color = System.Drawing.Color.Green;
            series.ChartType = SeriesChartType.Pie;
            //series.Legend = "#PERCENT";
            chart1.Series.Add(series);
            chart1.Series[0].Label = "#PERCENT";
            this.chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            // Add series.
            for (int i = 1; i < seriesArray.Length; i++)
            {
                //Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
                series.Points[i - 1].AxisLabel = pointsArray[i].ToString();
                series.Points[i - 1].LegendText = seriesArray[i];

            }
        }

        private void Abtn_Click(object sender, EventArgs e)
        {

            string ShowText = "-:Australia Tax Calculater:-\r\nThis AU Tax calculator calculates on specifications definition for 2015-16 based on https://www.ato.gov.au/rates/individual-income-tax-rates/\r\n";
            ShowText += string.Format("Design and developed by {0}\r\nThanks for your feedback..\r\n{1}", "Deepak SHAW", "deepak.shaw@gmail.com");
            txtResult.Text = ShowText;
        }

    }
}