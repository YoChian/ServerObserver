
namespace ServerObserver
{
	partial class MonitorTab
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.MonitorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.MonitorChart)).BeginInit();
			this.SuspendLayout();
			// 
			// MonitorChart
			// 
			chartArea4.Name = "ChartArea1";
			this.MonitorChart.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.MonitorChart.Legends.Add(legend4);
			this.MonitorChart.Location = new System.Drawing.Point(4, 4);
			this.MonitorChart.Name = "MonitorChart";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			series4.YValuesPerPoint = 4;
			this.MonitorChart.Series.Add(series4);
			this.MonitorChart.Size = new System.Drawing.Size(543, 320);
			this.MonitorChart.TabIndex = 0;
			this.MonitorChart.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MonitorTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MonitorChart);
			this.Name = "MonitorTab";
			this.Size = new System.Drawing.Size(550, 327);
			((System.ComponentModel.ISupportInitialize)(this.MonitorChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart MonitorChart;
		private System.Windows.Forms.Timer timer1;
	}
}
