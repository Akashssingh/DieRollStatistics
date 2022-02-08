
namespace DieRollAkashResubmission
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.die1Pic = new System.Windows.Forms.PictureBox();
            this.die2Pic = new System.Windows.Forms.PictureBox();
            this.die1label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.seedText = new System.Windows.Forms.TextBox();
            this.seedBoxLabel = new System.Windows.Forms.Label();
            this.sotButton = new System.Windows.Forms.Button();
            this.comboBoxLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.titleProject = new System.Windows.Forms.Label();
            this.dieImageList = new System.Windows.Forms.ImageList(this.components);
            this.statHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsTitle = new System.Windows.Forms.Label();
            this.die1StatLabel = new System.Windows.Forms.Label();
            this.die2StatLabel = new System.Windows.Forms.Label();
            this.sotStatLabel = new System.Windows.Forms.Label();
            this.meanDie1Label = new System.Windows.Forms.Label();
            this.die2MeanLabel = new System.Windows.Forms.Label();
            this.sotMeanLabel = new System.Windows.Forms.Label();
            this.die1MeanText = new System.Windows.Forms.Label();
            this.die2MeanText = new System.Windows.Forms.Label();
            this.sotMeanText = new System.Windows.Forms.Label();
            this.die1MinFaceLabel = new System.Windows.Forms.Label();
            this.die2MinFaceLabel = new System.Windows.Forms.Label();
            this.sotMinFaceLabel = new System.Windows.Forms.Label();
            this.die1MaxvalLabel = new System.Windows.Forms.Label();
            this.die2MaxvalLabel = new System.Windows.Forms.Label();
            this.sotMaxvalLabel = new System.Windows.Forms.Label();
            this.die1MaxfaceLabel = new System.Windows.Forms.Label();
            this.die2MaxfaceLabel = new System.Windows.Forms.Label();
            this.sotMaxfaceLabel = new System.Windows.Forms.Label();
            this.die1MaxfaceText = new System.Windows.Forms.Label();
            this.die2MaxfaceText = new System.Windows.Forms.Label();
            this.sotMaxfaceText = new System.Windows.Forms.Label();
            this.die1MaxvalText = new System.Windows.Forms.Label();
            this.die2MaxvalText = new System.Windows.Forms.Label();
            this.sotMaxvalText = new System.Windows.Forms.Label();
            this.die1MinfaceText = new System.Windows.Forms.Label();
            this.die2MinfaceText = new System.Windows.Forms.Label();
            this.sotMinfaceText = new System.Windows.Forms.Label();
            this.die1MinvalText = new System.Windows.Forms.Label();
            this.die2MinvalText = new System.Windows.Forms.Label();
            this.sotMinvalText = new System.Windows.Forms.Label();
            this.die1MinvalLabel = new System.Windows.Forms.Label();
            this.die2minvalLabel = new System.Windows.Forms.Label();
            this.sotMinvalLabel = new System.Windows.Forms.Label();
            this.die1MeanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.die1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // die1Pic
            // 
            this.die1Pic.Location = new System.Drawing.Point(38, 81);
            this.die1Pic.Name = "die1Pic";
            this.die1Pic.Size = new System.Drawing.Size(145, 147);
            this.die1Pic.TabIndex = 1;
            this.die1Pic.TabStop = false;
            // 
            // die2Pic
            // 
            this.die2Pic.Location = new System.Drawing.Point(204, 81);
            this.die2Pic.Name = "die2Pic";
            this.die2Pic.Size = new System.Drawing.Size(150, 147);
            this.die2Pic.TabIndex = 2;
            this.die2Pic.TabStop = false;
            // 
            // die1label
            // 
            this.die1label.AutoSize = true;
            this.die1label.Location = new System.Drawing.Point(81, 244);
            this.die1label.Name = "die1label";
            this.die1label.Size = new System.Drawing.Size(62, 25);
            this.die1label.TabIndex = 3;
            this.die1label.Text = "Die 1";
            this.die1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // die2Label
            // 
            this.die2Label.AutoSize = true;
            this.die2Label.Location = new System.Drawing.Point(245, 244);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(62, 25);
            this.die2Label.TabIndex = 4;
            this.die2Label.Text = "Die 2";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(12, 284);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(100, 46);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "ROLL";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // statButton
            // 
            this.statButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.statButton.Location = new System.Drawing.Point(118, 284);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(135, 46);
            this.statButton.TabIndex = 6;
            this.statButton.Text = "STATISTICS!";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(259, 284);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 46);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // seedText
            // 
            this.seedText.Location = new System.Drawing.Point(418, 344);
            this.seedText.Name = "seedText";
            this.seedText.Size = new System.Drawing.Size(112, 31);
            this.seedText.TabIndex = 8;
            this.seedText.Text = "999";
            // 
            // seedBoxLabel
            // 
            this.seedBoxLabel.AutoSize = true;
            this.seedBoxLabel.Location = new System.Drawing.Point(287, 344);
            this.seedBoxLabel.Name = "seedBoxLabel";
            this.seedBoxLabel.Size = new System.Drawing.Size(125, 25);
            this.seedBoxLabel.TabIndex = 10;
            this.seedBoxLabel.Text = "Enter Seed:";
            this.seedBoxLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // sotButton
            // 
            this.sotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.sotButton.Location = new System.Drawing.Point(376, 284);
            this.sotButton.Name = "sotButton";
            this.sotButton.Size = new System.Drawing.Size(154, 46);
            this.sotButton.TabIndex = 11;
            this.sotButton.Text = "Sum of 2 Dice";
            this.sotButton.UseVisualStyleBackColor = true;
            this.sotButton.Click += new System.EventHandler(this.sotButton_Click);
            // 
            // comboBoxLabel
            // 
            this.comboBoxLabel.AutoSize = true;
            this.comboBoxLabel.Location = new System.Drawing.Point(12, 344);
            this.comboBoxLabel.Name = "comboBoxLabel";
            this.comboBoxLabel.Size = new System.Drawing.Size(192, 25);
            this.comboBoxLabel.TabIndex = 12;
            this.comboBoxLabel.Text = "Select # of rounds:";
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Items.AddRange(new object[] {
            "60",
            "600",
            "6000",
            "60000"});
            this.listBox.Location = new System.Drawing.Point(204, 344);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(77, 104);
            this.listBox.TabIndex = 13;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // titleProject
            // 
            this.titleProject.AutoSize = true;
            this.titleProject.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleProject.Location = new System.Drawing.Point(265, 9);
            this.titleProject.Name = "titleProject";
            this.titleProject.Size = new System.Drawing.Size(520, 32);
            this.titleProject.TabIndex = 14;
            this.titleProject.Text = "Software Sys Dev Project 1 - Akash Singh";
            this.titleProject.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dieImageList
            // 
            this.dieImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dieImageList.ImageStream")));
            this.dieImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dieImageList.Images.SetKeyName(0, "die1.png");
            this.dieImageList.Images.SetKeyName(1, "die2.png");
            this.dieImageList.Images.SetKeyName(2, "die3.png");
            this.dieImageList.Images.SetKeyName(3, "die4.png");
            this.dieImageList.Images.SetKeyName(4, "die5.png");
            this.dieImageList.Images.SetKeyName(5, "die6.png");
            // 
            // statHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.statHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statHistogram.Legends.Add(legend1);
            this.statHistogram.Location = new System.Drawing.Point(556, 69);
            this.statHistogram.Name = "statHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Die 1 Stats";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Die 2 Stats";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SOTD Stats";
            this.statHistogram.Series.Add(series1);
            this.statHistogram.Series.Add(series2);
            this.statHistogram.Series.Add(series3);
            this.statHistogram.Size = new System.Drawing.Size(477, 306);
            this.statHistogram.TabIndex = 15;
            this.statHistogram.Text = "Histogram";
            // 
            // statsTitle
            // 
            this.statsTitle.AutoSize = true;
            this.statsTitle.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTitle.Location = new System.Drawing.Point(7, 458);
            this.statsTitle.Name = "statsTitle";
            this.statsTitle.Size = new System.Drawing.Size(126, 32);
            this.statsTitle.TabIndex = 16;
            this.statsTitle.Text = "Statistics";
            // 
            // die1StatLabel
            // 
            this.die1StatLabel.AutoSize = true;
            this.die1StatLabel.Location = new System.Drawing.Point(7, 520);
            this.die1StatLabel.Name = "die1StatLabel";
            this.die1StatLabel.Size = new System.Drawing.Size(68, 25);
            this.die1StatLabel.TabIndex = 17;
            this.die1StatLabel.Text = "Die 1:";
            // 
            // die2StatLabel
            // 
            this.die2StatLabel.AutoSize = true;
            this.die2StatLabel.Location = new System.Drawing.Point(7, 560);
            this.die2StatLabel.Name = "die2StatLabel";
            this.die2StatLabel.Size = new System.Drawing.Size(68, 25);
            this.die2StatLabel.TabIndex = 18;
            this.die2StatLabel.Text = "Die 2:";
            // 
            // sotStatLabel
            // 
            this.sotStatLabel.AutoSize = true;
            this.sotStatLabel.Location = new System.Drawing.Point(7, 596);
            this.sotStatLabel.Name = "sotStatLabel";
            this.sotStatLabel.Size = new System.Drawing.Size(76, 25);
            this.sotStatLabel.TabIndex = 19;
            this.sotStatLabel.Text = "SOTD:";
            // 
            // meanDie1Label
            // 
            this.meanDie1Label.AutoSize = true;
            this.meanDie1Label.Location = new System.Drawing.Point(81, 520);
            this.meanDie1Label.Name = "meanDie1Label";
            this.meanDie1Label.Size = new System.Drawing.Size(0, 25);
            this.meanDie1Label.TabIndex = 20;
            // 
            // die2MeanLabel
            // 
            this.die2MeanLabel.AutoSize = true;
            this.die2MeanLabel.Location = new System.Drawing.Point(81, 560);
            this.die2MeanLabel.Name = "die2MeanLabel";
            this.die2MeanLabel.Size = new System.Drawing.Size(72, 25);
            this.die2MeanLabel.TabIndex = 21;
            this.die2MeanLabel.Text = "Mean:";
            // 
            // sotMeanLabel
            // 
            this.sotMeanLabel.AutoSize = true;
            this.sotMeanLabel.Location = new System.Drawing.Point(81, 596);
            this.sotMeanLabel.Name = "sotMeanLabel";
            this.sotMeanLabel.Size = new System.Drawing.Size(72, 25);
            this.sotMeanLabel.TabIndex = 22;
            this.sotMeanLabel.Text = "Mean:";
            // 
            // die1MeanText
            // 
            this.die1MeanText.AutoSize = true;
            this.die1MeanText.Location = new System.Drawing.Point(159, 520);
            this.die1MeanText.Name = "die1MeanText";
            this.die1MeanText.Size = new System.Drawing.Size(24, 25);
            this.die1MeanText.TabIndex = 23;
            this.die1MeanText.Text = "0";
            // 
            // die2MeanText
            // 
            this.die2MeanText.AutoSize = true;
            this.die2MeanText.Location = new System.Drawing.Point(159, 560);
            this.die2MeanText.Name = "die2MeanText";
            this.die2MeanText.Size = new System.Drawing.Size(24, 25);
            this.die2MeanText.TabIndex = 24;
            this.die2MeanText.Text = "0";
            // 
            // sotMeanText
            // 
            this.sotMeanText.AutoSize = true;
            this.sotMeanText.Location = new System.Drawing.Point(159, 596);
            this.sotMeanText.Name = "sotMeanText";
            this.sotMeanText.Size = new System.Drawing.Size(24, 25);
            this.sotMeanText.TabIndex = 25;
            this.sotMeanText.Text = "0";
            // 
            // die1MinFaceLabel
            // 
            this.die1MinFaceLabel.AutoSize = true;
            this.die1MinFaceLabel.Location = new System.Drawing.Point(391, 520);
            this.die1MinFaceLabel.Name = "die1MinFaceLabel";
            this.die1MinFaceLabel.Size = new System.Drawing.Size(107, 25);
            this.die1MinFaceLabel.TabIndex = 26;
            this.die1MinFaceLabel.Text = "Min Face:";
            // 
            // die2MinFaceLabel
            // 
            this.die2MinFaceLabel.AutoSize = true;
            this.die2MinFaceLabel.Location = new System.Drawing.Point(391, 560);
            this.die2MinFaceLabel.Name = "die2MinFaceLabel";
            this.die2MinFaceLabel.Size = new System.Drawing.Size(107, 25);
            this.die2MinFaceLabel.TabIndex = 27;
            this.die2MinFaceLabel.Text = "Min Face:";
            // 
            // sotMinFaceLabel
            // 
            this.sotMinFaceLabel.AutoSize = true;
            this.sotMinFaceLabel.Location = new System.Drawing.Point(391, 596);
            this.sotMinFaceLabel.Name = "sotMinFaceLabel";
            this.sotMinFaceLabel.Size = new System.Drawing.Size(107, 25);
            this.sotMinFaceLabel.TabIndex = 28;
            this.sotMinFaceLabel.Text = "Min Face:";
            // 
            // die1MaxvalLabel
            // 
            this.die1MaxvalLabel.AutoSize = true;
            this.die1MaxvalLabel.Location = new System.Drawing.Point(567, 520);
            this.die1MaxvalLabel.Name = "die1MaxvalLabel";
            this.die1MaxvalLabel.Size = new System.Drawing.Size(96, 25);
            this.die1MaxvalLabel.TabIndex = 29;
            this.die1MaxvalLabel.Text = "Max Val:";
            // 
            // die2MaxvalLabel
            // 
            this.die2MaxvalLabel.AutoSize = true;
            this.die2MaxvalLabel.Location = new System.Drawing.Point(567, 560);
            this.die2MaxvalLabel.Name = "die2MaxvalLabel";
            this.die2MaxvalLabel.Size = new System.Drawing.Size(96, 25);
            this.die2MaxvalLabel.TabIndex = 30;
            this.die2MaxvalLabel.Text = "Max Val:";
            // 
            // sotMaxvalLabel
            // 
            this.sotMaxvalLabel.AutoSize = true;
            this.sotMaxvalLabel.Location = new System.Drawing.Point(567, 596);
            this.sotMaxvalLabel.Name = "sotMaxvalLabel";
            this.sotMaxvalLabel.Size = new System.Drawing.Size(96, 25);
            this.sotMaxvalLabel.TabIndex = 31;
            this.sotMaxvalLabel.Text = "Max Val:";
            // 
            // die1MaxfaceLabel
            // 
            this.die1MaxfaceLabel.AutoSize = true;
            this.die1MaxfaceLabel.Location = new System.Drawing.Point(735, 520);
            this.die1MaxfaceLabel.Name = "die1MaxfaceLabel";
            this.die1MaxfaceLabel.Size = new System.Drawing.Size(113, 25);
            this.die1MaxfaceLabel.TabIndex = 32;
            this.die1MaxfaceLabel.Text = "Max Face:";
            // 
            // die2MaxfaceLabel
            // 
            this.die2MaxfaceLabel.AutoSize = true;
            this.die2MaxfaceLabel.Location = new System.Drawing.Point(735, 560);
            this.die2MaxfaceLabel.Name = "die2MaxfaceLabel";
            this.die2MaxfaceLabel.Size = new System.Drawing.Size(113, 25);
            this.die2MaxfaceLabel.TabIndex = 33;
            this.die2MaxfaceLabel.Text = "Max Face:";
            // 
            // sotMaxfaceLabel
            // 
            this.sotMaxfaceLabel.AutoSize = true;
            this.sotMaxfaceLabel.Location = new System.Drawing.Point(735, 596);
            this.sotMaxfaceLabel.Name = "sotMaxfaceLabel";
            this.sotMaxfaceLabel.Size = new System.Drawing.Size(113, 25);
            this.sotMaxfaceLabel.TabIndex = 34;
            this.sotMaxfaceLabel.Text = "Max Face:";
            // 
            // die1MaxfaceText
            // 
            this.die1MaxfaceText.AutoSize = true;
            this.die1MaxfaceText.Location = new System.Drawing.Point(854, 520);
            this.die1MaxfaceText.Name = "die1MaxfaceText";
            this.die1MaxfaceText.Size = new System.Drawing.Size(19, 25);
            this.die1MaxfaceText.TabIndex = 36;
            this.die1MaxfaceText.Text = "-";
            // 
            // die2MaxfaceText
            // 
            this.die2MaxfaceText.AutoSize = true;
            this.die2MaxfaceText.Location = new System.Drawing.Point(854, 560);
            this.die2MaxfaceText.Name = "die2MaxfaceText";
            this.die2MaxfaceText.Size = new System.Drawing.Size(19, 25);
            this.die2MaxfaceText.TabIndex = 37;
            this.die2MaxfaceText.Text = "-";
            // 
            // sotMaxfaceText
            // 
            this.sotMaxfaceText.AutoSize = true;
            this.sotMaxfaceText.Location = new System.Drawing.Point(854, 596);
            this.sotMaxfaceText.Name = "sotMaxfaceText";
            this.sotMaxfaceText.Size = new System.Drawing.Size(19, 25);
            this.sotMaxfaceText.TabIndex = 38;
            this.sotMaxfaceText.Text = "-";
            // 
            // die1MaxvalText
            // 
            this.die1MaxvalText.AutoSize = true;
            this.die1MaxvalText.Location = new System.Drawing.Point(669, 520);
            this.die1MaxvalText.Name = "die1MaxvalText";
            this.die1MaxvalText.Size = new System.Drawing.Size(24, 25);
            this.die1MaxvalText.TabIndex = 39;
            this.die1MaxvalText.Text = "0";
            // 
            // die2MaxvalText
            // 
            this.die2MaxvalText.AutoSize = true;
            this.die2MaxvalText.Location = new System.Drawing.Point(669, 560);
            this.die2MaxvalText.Name = "die2MaxvalText";
            this.die2MaxvalText.Size = new System.Drawing.Size(24, 25);
            this.die2MaxvalText.TabIndex = 40;
            this.die2MaxvalText.Text = "0";
            // 
            // sotMaxvalText
            // 
            this.sotMaxvalText.AutoSize = true;
            this.sotMaxvalText.Location = new System.Drawing.Point(669, 596);
            this.sotMaxvalText.Name = "sotMaxvalText";
            this.sotMaxvalText.Size = new System.Drawing.Size(24, 25);
            this.sotMaxvalText.TabIndex = 41;
            this.sotMaxvalText.Text = "0";
            // 
            // die1MinfaceText
            // 
            this.die1MinfaceText.AutoSize = true;
            this.die1MinfaceText.Location = new System.Drawing.Point(504, 520);
            this.die1MinfaceText.Name = "die1MinfaceText";
            this.die1MinfaceText.Size = new System.Drawing.Size(19, 25);
            this.die1MinfaceText.TabIndex = 42;
            this.die1MinfaceText.Text = "-";
            // 
            // die2MinfaceText
            // 
            this.die2MinfaceText.AutoSize = true;
            this.die2MinfaceText.Location = new System.Drawing.Point(504, 560);
            this.die2MinfaceText.Name = "die2MinfaceText";
            this.die2MinfaceText.Size = new System.Drawing.Size(19, 25);
            this.die2MinfaceText.TabIndex = 43;
            this.die2MinfaceText.Text = "-";
            // 
            // sotMinfaceText
            // 
            this.sotMinfaceText.AutoSize = true;
            this.sotMinfaceText.Location = new System.Drawing.Point(504, 596);
            this.sotMinfaceText.Name = "sotMinfaceText";
            this.sotMinfaceText.Size = new System.Drawing.Size(19, 25);
            this.sotMinfaceText.TabIndex = 44;
            this.sotMinfaceText.Text = "-";
            // 
            // die1MinvalText
            // 
            this.die1MinvalText.AutoSize = true;
            this.die1MinvalText.Location = new System.Drawing.Point(331, 520);
            this.die1MinvalText.Name = "die1MinvalText";
            this.die1MinvalText.Size = new System.Drawing.Size(24, 25);
            this.die1MinvalText.TabIndex = 45;
            this.die1MinvalText.Text = "0";
            // 
            // die2MinvalText
            // 
            this.die2MinvalText.AutoSize = true;
            this.die2MinvalText.Location = new System.Drawing.Point(330, 560);
            this.die2MinvalText.Name = "die2MinvalText";
            this.die2MinvalText.Size = new System.Drawing.Size(24, 25);
            this.die2MinvalText.TabIndex = 46;
            this.die2MinvalText.Text = "0";
            // 
            // sotMinvalText
            // 
            this.sotMinvalText.AutoSize = true;
            this.sotMinvalText.Location = new System.Drawing.Point(331, 596);
            this.sotMinvalText.Name = "sotMinvalText";
            this.sotMinvalText.Size = new System.Drawing.Size(24, 25);
            this.sotMinvalText.TabIndex = 47;
            this.sotMinvalText.Text = "0";
            // 
            // die1MinvalLabel
            // 
            this.die1MinvalLabel.AutoSize = true;
            this.die1MinvalLabel.Location = new System.Drawing.Point(235, 520);
            this.die1MinvalLabel.Name = "die1MinvalLabel";
            this.die1MinvalLabel.Size = new System.Drawing.Size(90, 25);
            this.die1MinvalLabel.TabIndex = 48;
            this.die1MinvalLabel.Text = "Min Val:";
            // 
            // die2minvalLabel
            // 
            this.die2minvalLabel.AutoSize = true;
            this.die2minvalLabel.Location = new System.Drawing.Point(235, 560);
            this.die2minvalLabel.Name = "die2minvalLabel";
            this.die2minvalLabel.Size = new System.Drawing.Size(90, 25);
            this.die2minvalLabel.TabIndex = 49;
            this.die2minvalLabel.Text = "Min Val:";
            // 
            // sotMinvalLabel
            // 
            this.sotMinvalLabel.AutoSize = true;
            this.sotMinvalLabel.Location = new System.Drawing.Point(235, 596);
            this.sotMinvalLabel.Name = "sotMinvalLabel";
            this.sotMinvalLabel.Size = new System.Drawing.Size(90, 25);
            this.sotMinvalLabel.TabIndex = 50;
            this.sotMinvalLabel.Text = "Min Val:";
            // 
            // die1MeanLabel
            // 
            this.die1MeanLabel.AutoSize = true;
            this.die1MeanLabel.Location = new System.Drawing.Point(81, 520);
            this.die1MeanLabel.Name = "die1MeanLabel";
            this.die1MeanLabel.Size = new System.Drawing.Size(72, 25);
            this.die1MeanLabel.TabIndex = 51;
            this.die1MeanLabel.Text = "Mean:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 647);
            this.Controls.Add(this.die1MeanLabel);
            this.Controls.Add(this.sotMinvalLabel);
            this.Controls.Add(this.die2minvalLabel);
            this.Controls.Add(this.die1MinvalLabel);
            this.Controls.Add(this.sotMinvalText);
            this.Controls.Add(this.die2MinvalText);
            this.Controls.Add(this.die1MinvalText);
            this.Controls.Add(this.sotMinfaceText);
            this.Controls.Add(this.die2MinfaceText);
            this.Controls.Add(this.die1MinfaceText);
            this.Controls.Add(this.sotMaxvalText);
            this.Controls.Add(this.die2MaxvalText);
            this.Controls.Add(this.die1MaxvalText);
            this.Controls.Add(this.sotMaxfaceText);
            this.Controls.Add(this.die2MaxfaceText);
            this.Controls.Add(this.die1MaxfaceText);
            this.Controls.Add(this.sotMaxfaceLabel);
            this.Controls.Add(this.die2MaxfaceLabel);
            this.Controls.Add(this.die1MaxfaceLabel);
            this.Controls.Add(this.sotMaxvalLabel);
            this.Controls.Add(this.die2MaxvalLabel);
            this.Controls.Add(this.die1MaxvalLabel);
            this.Controls.Add(this.sotMinFaceLabel);
            this.Controls.Add(this.die2MinFaceLabel);
            this.Controls.Add(this.die1MinFaceLabel);
            this.Controls.Add(this.sotMeanText);
            this.Controls.Add(this.die2MeanText);
            this.Controls.Add(this.die1MeanText);
            this.Controls.Add(this.sotMeanLabel);
            this.Controls.Add(this.die2MeanLabel);
            this.Controls.Add(this.meanDie1Label);
            this.Controls.Add(this.sotStatLabel);
            this.Controls.Add(this.die2StatLabel);
            this.Controls.Add(this.die1StatLabel);
            this.Controls.Add(this.statsTitle);
            this.Controls.Add(this.statHistogram);
            this.Controls.Add(this.titleProject);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBoxLabel);
            this.Controls.Add(this.sotButton);
            this.Controls.Add(this.seedBoxLabel);
            this.Controls.Add(this.seedText);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1label);
            this.Controls.Add(this.die2Pic);
            this.Controls.Add(this.die1Pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.die1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox die1Pic;
        private System.Windows.Forms.PictureBox die2Pic;
        private System.Windows.Forms.Label die1label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox seedText;
        private System.Windows.Forms.Label seedBoxLabel;
        private System.Windows.Forms.Button sotButton;
        private System.Windows.Forms.Label comboBoxLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label titleProject;
        private System.Windows.Forms.ImageList dieImageList;
        private System.Windows.Forms.DataVisualization.Charting.Chart statHistogram;
        private System.Windows.Forms.Label statsTitle;
        private System.Windows.Forms.Label die1StatLabel;
        private System.Windows.Forms.Label die2StatLabel;
        private System.Windows.Forms.Label sotStatLabel;
        private System.Windows.Forms.Label meanDie1Label;
        private System.Windows.Forms.Label die2MeanLabel;
        private System.Windows.Forms.Label sotMeanLabel;
        private System.Windows.Forms.Label die1MeanText;
        private System.Windows.Forms.Label die2MeanText;
        private System.Windows.Forms.Label sotMeanText;
        private System.Windows.Forms.Label die1MinFaceLabel;
        private System.Windows.Forms.Label die2MinFaceLabel;
        private System.Windows.Forms.Label sotMinFaceLabel;
        private System.Windows.Forms.Label die1MaxvalLabel;
        private System.Windows.Forms.Label die2MaxvalLabel;
        private System.Windows.Forms.Label sotMaxvalLabel;
        private System.Windows.Forms.Label die1MaxfaceLabel;
        private System.Windows.Forms.Label die2MaxfaceLabel;
        private System.Windows.Forms.Label sotMaxfaceLabel;
        private System.Windows.Forms.Label die1MaxfaceText;
        private System.Windows.Forms.Label die2MaxfaceText;
        private System.Windows.Forms.Label sotMaxfaceText;
        private System.Windows.Forms.Label die1MaxvalText;
        private System.Windows.Forms.Label die2MaxvalText;
        private System.Windows.Forms.Label sotMaxvalText;
        private System.Windows.Forms.Label die1MinfaceText;
        private System.Windows.Forms.Label die2MinfaceText;
        private System.Windows.Forms.Label sotMinfaceText;
        private System.Windows.Forms.Label die1MinvalText;
        private System.Windows.Forms.Label die2MinvalText;
        private System.Windows.Forms.Label sotMinvalText;
        private System.Windows.Forms.Label die1MinvalLabel;
        private System.Windows.Forms.Label die2minvalLabel;
        private System.Windows.Forms.Label sotMinvalLabel;
        private System.Windows.Forms.Label die1MeanLabel;
    }
}

