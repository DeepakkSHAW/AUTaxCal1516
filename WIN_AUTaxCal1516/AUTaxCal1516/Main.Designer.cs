namespace AUTaxCal1516
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblAmt = new System.Windows.Forms.Label();
            this.txtGrossAmt = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdobtnBarChart = new System.Windows.Forms.RadioButton();
            this.rdobtnPieChart = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Abtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(35, 9);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(133, 13);
            this.lblAmt.TabIndex = 0;
            this.lblAmt.Text = "Your Annual Gross Income";
            // 
            // txtGrossAmt
            // 
            this.txtGrossAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossAmt.Location = new System.Drawing.Point(38, 25);
            this.txtGrossAmt.MaxLength = 12;
            this.txtGrossAmt.Name = "txtGrossAmt";
            this.txtGrossAmt.Size = new System.Drawing.Size(142, 21);
            this.txtGrossAmt.TabIndex = 3;
            this.txtGrossAmt.Text = "85000";
            this.txtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtGrossAmt, "Gross Income");
            this.txtGrossAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossAmt_KeyPress);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(186, 23);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 58);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Tax \r\n&Calculate";
            this.toolTip1.SetToolTip(this.btnCal, "Tax Calculate");
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(-5, 85);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(306, 105);
            this.txtResult.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtResult, "Tax Calculation Result");
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(0, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(180, 16);
            this.lblResult.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.Location = new System.Drawing.Point(7, 23);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(25, 25);
            this.btnCalc.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnCalc, "Launch Calculator");
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rdobtnBarChart
            // 
            this.rdobtnBarChart.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdobtnBarChart.Checked = true;
            this.rdobtnBarChart.Image = ((System.Drawing.Image)(resources.GetObject("rdobtnBarChart.Image")));
            this.rdobtnBarChart.Location = new System.Drawing.Point(265, 23);
            this.rdobtnBarChart.Name = "rdobtnBarChart";
            this.rdobtnBarChart.Size = new System.Drawing.Size(24, 25);
            this.rdobtnBarChart.TabIndex = 9;
            this.rdobtnBarChart.TabStop = true;
            this.toolTip1.SetToolTip(this.rdobtnBarChart, "Bar Chart");
            this.rdobtnBarChart.UseVisualStyleBackColor = true;
            this.rdobtnBarChart.CheckedChanged += new System.EventHandler(this.btnCal_Click);
            // 
            // rdobtnPieChart
            // 
            this.rdobtnPieChart.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdobtnPieChart.Image = ((System.Drawing.Image)(resources.GetObject("rdobtnPieChart.Image")));
            this.rdobtnPieChart.Location = new System.Drawing.Point(265, 56);
            this.rdobtnPieChart.Name = "rdobtnPieChart";
            this.rdobtnPieChart.Size = new System.Drawing.Size(24, 25);
            this.rdobtnPieChart.TabIndex = 10;
            this.rdobtnPieChart.TabStop = true;
            this.toolTip1.SetToolTip(this.rdobtnPieChart, "Pie Chart");
            this.rdobtnPieChart.UseVisualStyleBackColor = true;
            this.rdobtnPieChart.CheckedChanged += new System.EventHandler(this.btnCal_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 196);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(298, 141);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Abtn
            // 
            this.Abtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Abtn.Image = ((System.Drawing.Image)(resources.GetObject("Abtn.Image")));
            this.Abtn.Location = new System.Drawing.Point(273, 312);
            this.Abtn.Name = "Abtn";
            this.Abtn.Size = new System.Drawing.Size(28, 25);
            this.Abtn.TabIndex = 11;
            this.Abtn.UseVisualStyleBackColor = true;
            this.Abtn.Click += new System.EventHandler(this.Abtn_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 337);
            this.Controls.Add(this.Abtn);
            this.Controls.Add(this.rdobtnPieChart);
            this.Controls.Add(this.rdobtnBarChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtGrossAmt);
            this.Controls.Add(this.lblAmt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AU Tax Calculater 2015-16";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.TextBox txtGrossAmt;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rdobtnBarChart;
        private System.Windows.Forms.RadioButton rdobtnPieChart;
        private System.Windows.Forms.Button Abtn;
    }
}

