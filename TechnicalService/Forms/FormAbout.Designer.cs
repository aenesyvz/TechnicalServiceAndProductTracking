﻿
namespace TechnicalService.Forms
{
    partial class FormAbout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(147)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.gaugeControl2);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 384);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.gaugeControl1);
            this.panel2.Location = new System.Drawing.Point(689, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 384);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel3.Location = new System.Drawing.Point(689, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 366);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.panel4.Location = new System.Drawing.Point(1, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 366);
            this.panel4.TabIndex = 13;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(679, 384);
            this.gaugeControl1.TabIndex = 4;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1,
            this.arcScaleBackgroundLayerComponent2});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 667, 372);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1,
            this.arcScaleComponent2});
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 14F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightGrey");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -11F;
            this.arcScaleComponent1.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F);
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -28F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -5F;
            this.arcScaleComponent1.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.5F, 1F);
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent1.Name = "arcScaleComponent7";
            this.arcScaleComponent1.RadiusX = 122F;
            this.arcScaleComponent1.RadiusY = 122F;
            this.arcScaleComponent1.StartAngle = -240F;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent2.EndAngle = -30F;
            this.arcScaleComponent2.MajorTickCount = 8;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -4F;
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_4;
            this.arcScaleComponent2.MajorTickmark.TextOffset = -15F;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 700F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent2.Name = "arcScaleComponent11";
            this.arcScaleComponent2.RadiusX = 65F;
            this.arcScaleComponent2.RadiusY = 65F;
            this.arcScaleComponent2.StartAngle = -240F;
            this.arcScaleComponent2.ZOrder = -1;
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent7";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent10";
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style5_1;
            this.arcScaleBackgroundLayerComponent2.Size = new System.Drawing.SizeF(216F, 216F);
            this.arcScaleBackgroundLayerComponent2.ZOrder = 999;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent7";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5;
            this.arcScaleNeedleComponent1.StartOffset = -23.5F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(147)))), ((int)(((byte)(43)))));
            this.gaugeControl2.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(682, 384);
            this.gaugeControl2.TabIndex = 1;
            // 
            // circularGauge2
            // 
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 670, 372);
            this.circularGauge2.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge2.Name = "circularGauge2";
            this.circularGauge2.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent3});
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.labelComponent1.Name = "circularGauge1_Label1";
            this.labelComponent1.Size = new System.Drawing.SizeF(140F, 60F);
            this.labelComponent1.Text = "0";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent3.EndAngle = 90F;
            this.arcScaleComponent3.MajorTickCount = 0;
            this.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent3.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 100F;
            this.arcScaleComponent3.MinorTickCount = 0;
            this.arcScaleComponent3.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent3.Name = "scale1";
            this.arcScaleComponent3.StartAngle = -270F;
            this.arcScaleComponent3.Value = 20F;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.arcScaleComponent3;
            this.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 80F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 753);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
    }
}