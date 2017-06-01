namespace MHTPDHSSIC
{
    partial class Form1
    {

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.computeButton = new System.Windows.Forms.Button();
            this.mathKernel = new Wolfram.NETLink.MathKernel();
            this.graphicsBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTcool = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbT2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbT1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTout = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.cbMaxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRout = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRcool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbV2 = new System.Windows.Forms.TextBox();
            this.tbV1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьГрафикКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображатьMaxTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.рамкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввпаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкойРасчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приИзменииДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.PaleGreen;
            this.computeButton.Location = new System.Drawing.Point(3, 296);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(332, 33);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "Расчёт";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mathKernel
            // 
            this.mathKernel.AutoCloseLink = true;
            this.mathKernel.CaptureGraphics = true;
            this.mathKernel.CaptureMessages = true;
            this.mathKernel.CapturePrint = true;
            this.mathKernel.GraphicsFormat = "Automatic";
            this.mathKernel.GraphicsHeight = 0;
            this.mathKernel.GraphicsResolution = 0;
            this.mathKernel.GraphicsWidth = 0;
            this.mathKernel.HandleEvents = true;
            this.mathKernel.Input = null;
            this.mathKernel.Link = null;
            this.mathKernel.LinkArguments = null;
            this.mathKernel.PageWidth = 0;
            this.mathKernel.ResultFormat = Wolfram.NETLink.MathKernel.ResultFormatType.OutputForm;
            this.mathKernel.UseFrontEnd = true;
            // 
            // graphicsBox
            // 
            this.graphicsBox.Image = global::MHTPDHSSIC.Properties.Resources.mtJvjfSX8Ak;
            this.graphicsBox.ImageLocation = "";
            this.graphicsBox.Location = new System.Drawing.Point(350, 23);
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.Size = new System.Drawing.Size(525, 322);
            this.graphicsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.graphicsBox.TabIndex = 1;
            this.graphicsBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTcool);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbT2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbT1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTout);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Температура";
            // 
            // tbTcool
            // 
            this.tbTcool.Location = new System.Drawing.Point(90, 97);
            this.tbTcool.Name = "tbTcool";
            this.tbTcool.Size = new System.Drawing.Size(40, 20);
            this.tbTcool.TabIndex = 4;
            this.tbTcool.Text = "70";
            this.tbTcool.TextChanged += new System.EventHandler(this.tbTcool_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "t теплонос-ля";
            // 
            // tbT2
            // 
            this.tbT2.Location = new System.Drawing.Point(90, 71);
            this.tbT2.Name = "tbT2";
            this.tbT2.Size = new System.Drawing.Size(40, 20);
            this.tbT2.TabIndex = 4;
            this.tbT2.Text = "12";
            this.tbT2.TextChanged += new System.EventHandler(this.tbT2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "t контура";
            // 
            // tbT1
            // 
            this.tbT1.Location = new System.Drawing.Point(90, 45);
            this.tbT1.Name = "tbT1";
            this.tbT1.Size = new System.Drawing.Size(40, 20);
            this.tbT1.TabIndex = 4;
            this.tbT1.Text = "7.5";
            this.tbT1.TextChanged += new System.EventHandler(this.tbT1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "t помещения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "t вн-ней среды";
            // 
            // tbTout
            // 
            this.tbTout.Location = new System.Drawing.Point(90, 19);
            this.tbTout.Name = "tbTout";
            this.tbTout.Size = new System.Drawing.Size(40, 20);
            this.tbTout.TabIndex = 4;
            this.tbTout.Text = "-17";
            this.tbTout.TextChanged += new System.EventHandler(this.tbTout_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(350, 351);
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.resultBox.Size = new System.Drawing.Size(525, 35);
            this.resultBox.TabIndex = 4;
            this.resultBox.Text = "Здесь будут выводиться результаты вычислений и ошибки";
            // 
            // cbMaxt
            // 
            this.cbMaxt.FormattingEnabled = true;
            this.cbMaxt.Items.AddRange(new object[] {
            "All",
            "30",
            "25",
            "22",
            "20"});
            this.cbMaxt.Location = new System.Drawing.Point(478, 23);
            this.cbMaxt.Name = "cbMaxt";
            this.cbMaxt.Size = new System.Drawing.Size(43, 21);
            this.cbMaxt.TabIndex = 5;
            this.cbMaxt.Text = "All";
            this.cbMaxt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "max C° = ";
            this.label5.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCk);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbRout);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbRcool);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коэффециэнты";
            // 
            // tbCk
            // 
            this.tbCk.Location = new System.Drawing.Point(236, 64);
            this.tbCk.Name = "tbCk";
            this.tbCk.Size = new System.Drawing.Size(35, 20);
            this.tbCk.TabIndex = 5;
            this.tbCk.Text = "30.8";
            this.tbCk.TextChanged += new System.EventHandler(this.tbCk_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Теплоёмкость контура";
            // 
            // tbRout
            // 
            this.tbRout.Location = new System.Drawing.Point(236, 39);
            this.tbRout.Name = "tbRout";
            this.tbRout.Size = new System.Drawing.Size(35, 20);
            this.tbRout.TabIndex = 3;
            this.tbRout.Text = "3.2";
            this.tbRout.TextChanged += new System.EventHandler(this.tbRout_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Сопротивление излучения во вн среду";
            // 
            // tbRcool
            // 
            this.tbRcool.Location = new System.Drawing.Point(236, 13);
            this.tbRcool.Name = "tbRcool";
            this.tbRcool.Size = new System.Drawing.Size(35, 20);
            this.tbRcool.TabIndex = 1;
            this.tbRcool.Text = "2.6";
            this.tbRcool.TextChanged += new System.EventHandler(this.tbRcool_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сопротевление теплопередачи тепло-ля";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 363);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbTime);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.computeButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прямой ввод коэффециентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Интересующий период времени в минутах";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(242, 271);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(35, 20);
            this.tbTime.TabIndex = 10;
            this.tbTime.Text = "120";
            this.tbTime.TextChanged += new System.EventHandler(this.tbTime_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbC2);
            this.groupBox4.Controls.Add(this.tbC1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(154, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 76);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удельная теплоёмкость";
            // 
            // tbC2
            // 
            this.tbC2.Location = new System.Drawing.Point(88, 48);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(35, 20);
            this.tbC2.TabIndex = 10;
            this.tbC2.Text = "3.2";
            this.tbC2.TextChanged += new System.EventHandler(this.tbC2_TextChanged);
            // 
            // tbC1
            // 
            this.tbC1.Location = new System.Drawing.Point(88, 18);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(35, 20);
            this.tbC1.TabIndex = 10;
            this.tbC1.Text = "1.005";
            this.tbC1.TextChanged += new System.EventHandler(this.tbC1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "q воздуха";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "q контура";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbV2);
            this.groupBox3.Controls.Add(this.tbV1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(154, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 76);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Объем";
            // 
            // tbV2
            // 
            this.tbV2.Location = new System.Drawing.Point(88, 48);
            this.tbV2.Name = "tbV2";
            this.tbV2.Size = new System.Drawing.Size(35, 20);
            this.tbV2.TabIndex = 3;
            this.tbV2.Text = "22";
            this.tbV2.TextChanged += new System.EventHandler(this.tbV2_TextChanged);
            // 
            // tbV1
            // 
            this.tbV1.Location = new System.Drawing.Point(88, 19);
            this.tbV1.Name = "tbV1";
            this.tbV1.Size = new System.Drawing.Size(35, 20);
            this.tbV1.TabIndex = 2;
            this.tbV1.Text = "45";
            this.tbV1.TextChanged += new System.EventHandler(this.tbV1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "V контура";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "V помещения";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ввод с предварительными расчётами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.расчётToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьГрафикКакToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьГрафикКакToolStripMenuItem
            // 
            this.сохранитьГрафикКакToolStripMenuItem.Name = "сохранитьГрафикКакToolStripMenuItem";
            this.сохранитьГрафикКакToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьГрафикКакToolStripMenuItem.Text = "Сохранить график как";
            this.сохранитьГрафикКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьГрафикКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Checked = true;
            this.видToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отображатьMaxTToolStripMenuItem,
            this.рамкаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // отображатьMaxTToolStripMenuItem
            // 
            this.отображатьMaxTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.отображатьMaxTToolStripMenuItem.Name = "отображатьMaxTToolStripMenuItem";
            this.отображатьMaxTToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.отображатьMaxTToolStripMenuItem.Text = "Отображать max C° =";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem3.Text = "30";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem4.Text = "25";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem5.Text = "22";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem6.Text = "20";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // рамкаToolStripMenuItem
            // 
            this.рамкаToolStripMenuItem.Checked = true;
            this.рамкаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.рамкаToolStripMenuItem.Name = "рамкаToolStripMenuItem";
            this.рамкаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.рамкаToolStripMenuItem.Text = "Рамка";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчётToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // расчётToolStripMenuItem
            // 
            this.расчётToolStripMenuItem.Name = "расчётToolStripMenuItem";
            this.расчётToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.расчётToolStripMenuItem.Text = "Расчёт";
            this.расчётToolStripMenuItem.Click += new System.EventHandler(this.расчётToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввпаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ввпаToolStripMenuItem
            // 
            this.ввпаToolStripMenuItem.Name = "ввпаToolStripMenuItem";
            this.ввпаToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ввпаToolStripMenuItem.Text = "Автор: Бажутов АИ";
            // 
            // расчётToolStripMenuItem1
            // 
            this.расчётToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кнопкойРасчётToolStripMenuItem,
            this.приИзменииДанныхToolStripMenuItem});
            this.расчётToolStripMenuItem1.Name = "расчётToolStripMenuItem1";
            this.расчётToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.расчётToolStripMenuItem1.Text = "Расчёт";
            // 
            // кнопкойРасчётToolStripMenuItem
            // 
            this.кнопкойРасчётToolStripMenuItem.Checked = true;
            this.кнопкойРасчётToolStripMenuItem.CheckOnClick = true;
            this.кнопкойРасчётToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.кнопкойРасчётToolStripMenuItem.Enabled = false;
            this.кнопкойРасчётToolStripMenuItem.Name = "кнопкойРасчётToolStripMenuItem";
            this.кнопкойРасчётToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.кнопкойРасчётToolStripMenuItem.Text = "Кнопкой \"Расчёт\"";
            this.кнопкойРасчётToolStripMenuItem.CheckedChanged += new System.EventHandler(this.кнопкойРасчётToolStripMenuItem_CheckedChanged);
            // 
            // приИзменииДанныхToolStripMenuItem
            // 
            this.приИзменииДанныхToolStripMenuItem.CheckOnClick = true;
            this.приИзменииДанныхToolStripMenuItem.Name = "приИзменииДанныхToolStripMenuItem";
            this.приИзменииДанныхToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.приИзменииДанныхToolStripMenuItem.Text = "При измении данных";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaxt);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.graphicsBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расчёт и моделирование теплообмена помещения с нагревательным контуром отопления";
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button computeButton;
        private Wolfram.NETLink.MathKernel mathKernel;
        private System.Windows.Forms.PictureBox graphicsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbT2;
        private System.Windows.Forms.TextBox tbTcool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.ComboBox cbMaxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRcool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbV2;
        private System.Windows.Forms.TextBox tbV1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbC2;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьГрафикКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображатьMaxTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввпаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem приИзменииДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рамкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кнопкойРасчётToolStripMenuItem;
    }
}

