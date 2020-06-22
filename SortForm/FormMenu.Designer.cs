namespace SortForm
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.toolStripSort = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItemRandomAnyCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.labelSortInstruction = new System.Windows.Forms.Label();
            this.buttonSortInSort = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.richTextBoxItems = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSortedList = new System.Windows.Forms.RichTextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowMas = new System.Windows.Forms.Button();
            this.pictureBoxCards = new System.Windows.Forms.PictureBox();
            this.buttonChart = new System.Windows.Forms.Button();
            this.chartSort = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripchart = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBackChart = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.toolStripSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSort)).BeginInit();
            this.toolStripchart.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.ForeColor = System.Drawing.Color.White;
            this.labelHello.Location = new System.Drawing.Point(12, 38);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(278, 58);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Добро пожаловать!\r\nЧто вы хотите сделать?";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.Location = new System.Drawing.Point(12, 112);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(266, 56);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Отсортировать";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.DarkRed;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(12, 174);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(266, 74);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Получить информацию о сортировке";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.BackColor = System.Drawing.Color.DarkRed;
            this.buttonInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstruction.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstruction.ForeColor = System.Drawing.Color.White;
            this.buttonInstruction.Location = new System.Drawing.Point(12, 316);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(266, 74);
            this.buttonInstruction.TabIndex = 3;
            this.buttonInstruction.Text = "Получить инструкцию по работе с приложением";
            this.buttonInstruction.UseVisualStyleBackColor = false;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // toolStripSort
            // 
            this.toolStripSort.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSort.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripSplitButton1,
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
            this.toolStripSort.Location = new System.Drawing.Point(0, 0);
            this.toolStripSort.Name = "toolStripSort";
            this.toolStripSort.Size = new System.Drawing.Size(1031, 38);
            this.toolStripSort.TabIndex = 5;
            this.toolStripSort.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonBack.Text = "Вернуться в меню";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRandomAnyCount,
            this.ToolStripMenuItemRandom});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 33);
            this.toolStripSplitButton1.Text = "Рандом";
            // 
            // ToolStripMenuItemRandomAnyCount
            // 
            this.ToolStripMenuItemRandomAnyCount.BackColor = System.Drawing.Color.Maroon;
            this.ToolStripMenuItemRandomAnyCount.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemRandomAnyCount.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemRandomAnyCount.Name = "ToolStripMenuItemRandomAnyCount";
            this.ToolStripMenuItemRandomAnyCount.Size = new System.Drawing.Size(567, 38);
            this.ToolStripMenuItemRandomAnyCount.Text = "Рандом с любым количеством элементов";
            this.ToolStripMenuItemRandomAnyCount.Click += new System.EventHandler(this.ToolStripMenuItemRandomAnyCount_Click);
            // 
            // ToolStripMenuItemRandom
            // 
            this.ToolStripMenuItemRandom.BackColor = System.Drawing.Color.Maroon;
            this.ToolStripMenuItemRandom.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemRandom.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemRandom.Name = "ToolStripMenuItemRandom";
            this.ToolStripMenuItemRandom.Size = new System.Drawing.Size(567, 38);
            this.ToolStripMenuItemRandom.Text = "Рандом с заданным количеством элементов";
            this.ToolStripMenuItemRandom.Click += new System.EventHandler(this.ToolStripMenuItemRandom_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonOpen.Text = "Открыть";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // labelSortInstruction
            // 
            this.labelSortInstruction.AutoSize = true;
            this.labelSortInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSortInstruction.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortInstruction.ForeColor = System.Drawing.Color.White;
            this.labelSortInstruction.Location = new System.Drawing.Point(0, 76);
            this.labelSortInstruction.Name = "labelSortInstruction";
            this.labelSortInstruction.Size = new System.Drawing.Size(211, 29);
            this.labelSortInstruction.TabIndex = 6;
            this.labelSortInstruction.Text = "Введите элементы";
            // 
            // buttonSortInSort
            // 
            this.buttonSortInSort.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSortInSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortInSort.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortInSort.ForeColor = System.Drawing.Color.White;
            this.buttonSortInSort.Location = new System.Drawing.Point(12, 253);
            this.buttonSortInSort.Name = "buttonSortInSort";
            this.buttonSortInSort.Size = new System.Drawing.Size(200, 57);
            this.buttonSortInSort.TabIndex = 8;
            this.buttonSortInSort.Text = "Отсортировать";
            this.buttonSortInSort.UseVisualStyleBackColor = false;
            this.buttonSortInSort.Click += new System.EventHandler(this.buttonSortInSort_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.DarkRed;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 337);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 31);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "label1";
            // 
            // richTextBoxItems
            // 
            this.richTextBoxItems.BackColor = System.Drawing.Color.Firebrick;
            this.richTextBoxItems.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxItems.ForeColor = System.Drawing.Color.White;
            this.richTextBoxItems.Location = new System.Drawing.Point(12, 82);
            this.richTextBoxItems.Name = "richTextBoxItems";
            this.richTextBoxItems.Size = new System.Drawing.Size(1031, 133);
            this.richTextBoxItems.TabIndex = 11;
            this.richTextBoxItems.Text = "";
            // 
            // richTextBoxSortedList
            // 
            this.richTextBoxSortedList.BackColor = System.Drawing.Color.DarkRed;
            this.richTextBoxSortedList.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSortedList.ForeColor = System.Drawing.Color.White;
            this.richTextBoxSortedList.Location = new System.Drawing.Point(12, 408);
            this.richTextBoxSortedList.Name = "richTextBoxSortedList";
            this.richTextBoxSortedList.ReadOnly = true;
            this.richTextBoxSortedList.Size = new System.Drawing.Size(1031, 171);
            this.richTextBoxSortedList.TabIndex = 12;
            this.richTextBoxSortedList.Text = "";
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxCount.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.ForeColor = System.Drawing.Color.White;
            this.textBoxCount.Location = new System.Drawing.Point(359, 50);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 35);
            this.textBoxCount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите количество элементов";
            // 
            // buttonShowMas
            // 
            this.buttonShowMas.BackColor = System.Drawing.Color.DarkRed;
            this.buttonShowMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMas.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowMas.ForeColor = System.Drawing.Color.White;
            this.buttonShowMas.Location = new System.Drawing.Point(12, 82);
            this.buttonShowMas.Name = "buttonShowMas";
            this.buttonShowMas.Size = new System.Drawing.Size(200, 56);
            this.buttonShowMas.TabIndex = 14;
            this.buttonShowMas.Text = "Вывести массив";
            this.buttonShowMas.UseVisualStyleBackColor = false;
            this.buttonShowMas.Click += new System.EventHandler(this.buttonShowMas_Click);
            // 
            // pictureBoxCards
            // 
            this.pictureBoxCards.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCards.Image")));
            this.pictureBoxCards.Location = new System.Drawing.Point(359, 24);
            this.pictureBoxCards.Name = "pictureBoxCards";
            this.pictureBoxCards.Size = new System.Drawing.Size(669, 555);
            this.pictureBoxCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCards.TabIndex = 19;
            this.pictureBoxCards.TabStop = false;
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.Color.DarkRed;
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChart.ForeColor = System.Drawing.Color.White;
            this.buttonChart.Location = new System.Drawing.Point(12, 254);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(266, 56);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Посмотреть график";
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // chartSort
            // 
            this.chartSort.BackColor = System.Drawing.Color.Black;
            this.chartSort.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chartSort.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Количество элементов";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Тики";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 50;
            chartArea1.Name = "ChartArea1";
            this.chartSort.ChartAreas.Add(chartArea1);
            this.chartSort.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartSort.Legends.Add(legend1);
            this.chartSort.Location = new System.Drawing.Point(0, 76);
            this.chartSort.Name = "chartSort";
            this.chartSort.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Асимптотика";
            series1.MarkerBorderColor = System.Drawing.Color.DarkRed;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "SeriesAsimptotic";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Cyan;
            series2.Legend = "Legend1";
            series2.LegendText = "Статистика";
            series2.MarkerColor = System.Drawing.Color.Cyan;
            series2.Name = "Series2";
            this.chartSort.Series.Add(series1);
            this.chartSort.Series.Add(series2);
            this.chartSort.Size = new System.Drawing.Size(1031, 974);
            this.chartSort.TabIndex = 16;
            this.chartSort.Text = "chart1";
            title1.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "График сортировки вставками";
            this.chartSort.Titles.Add(title1);
            // 
            // toolStripchart
            // 
            this.toolStripchart.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripchart.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripchart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBackChart});
            this.toolStripchart.Location = new System.Drawing.Point(0, 38);
            this.toolStripchart.Name = "toolStripchart";
            this.toolStripchart.Size = new System.Drawing.Size(1031, 38);
            this.toolStripchart.TabIndex = 17;
            this.toolStripchart.Text = "toolStrip1";
            // 
            // toolStripButtonBackChart
            // 
            this.toolStripButtonBackChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBackChart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBackChart.Image")));
            this.toolStripButtonBackChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackChart.Name = "toolStripButtonBackChart";
            this.toolStripButtonBackChart.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonBackChart.Text = "Вернуться в меню";
            this.toolStripButtonBackChart.Click += new System.EventHandler(this.toolStripButtonBackChart_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.Black;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.ForeColor = System.Drawing.Color.White;
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 76);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(1031, 974);
            this.richTextBoxInfo.TabIndex = 18;
            this.richTextBoxInfo.Text = "";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1031, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxSortedList);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonSortInSort);
            this.Controls.Add(this.buttonShowMas);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSortInstruction);
            this.Controls.Add(this.pictureBoxCards);
            this.Controls.Add(this.chartSort);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.richTextBoxItems);
            this.Controls.Add(this.toolStripchart);
            this.Controls.Add(this.toolStripSort);
            this.Controls.Add(this.labelHello);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.toolStripSort.ResumeLayout(false);
            this.toolStripSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSort)).EndInit();
            this.toolStripchart.ResumeLayout(false);
            this.toolStripchart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.ToolStrip toolStripSort;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.Label labelSortInstruction;
        private System.Windows.Forms.Button buttonSortInSort;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RichTextBox richTextBoxItems;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRandomAnyCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRandom;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.RichTextBox richTextBoxSortedList;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonShowMas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSort;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.ToolStrip toolStripchart;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackChart;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxCards;
    }
}

