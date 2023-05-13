namespace oop1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbfirst = new TextBox();
            btn_low = new Button();
            btn_up = new Button();
            domain_up_down = new DomainUpDown();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            ToolStripMenuItem = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            изменениеРазмераОкнаToolStripMenuItem = new ToolStripMenuItem();
            х500ToolStripMenuItem = new ToolStripMenuItem();
            х900ToolStripMenuItem = new ToolStripMenuItem();
            х1080ToolStripMenuItem = new ToolStripMenuItem();
            вестиВручнуюToolStripMenuItem = new ToolStripMenuItem();
            выходИзПрограммыToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            buttonAllDelete = new Button();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            monthCalendar1 = new MonthCalendar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            MainTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ToolStripMenuItem.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbfirst
            // 
            tbfirst.BackColor = Color.Honeydew;
            tbfirst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbfirst.Location = new Point(345, 31);
            tbfirst.Name = "tbfirst";
            tbfirst.Size = new Size(659, 34);
            tbfirst.TabIndex = 0;
            tbfirst.Text = "Я буду обьяснять что здесь происходит";
            tbfirst.TextAlign = HorizontalAlignment.Center;
            tbfirst.MouseEnter += tbfirst_MouseEnter;
            tbfirst.MouseLeave += tbfirst_MouseLeave;
            // 
            // btn_low
            // 
            btn_low.BackColor = SystemColors.Window;
            btn_low.Location = new Point(8, 22);
            btn_low.Name = "btn_low";
            btn_low.Size = new Size(91, 29);
            btn_low.TabIndex = 1;
            btn_low.Text = "+1";
            btn_low.UseVisualStyleBackColor = false;
            btn_low.Click += btn_low_Click;
            btn_low.MouseEnter += btn_low_MouseEnter;
            btn_low.MouseLeave += btn_low_MouseLeave;
            // 
            // btn_up
            // 
            btn_up.BackColor = SystemColors.Window;
            btn_up.Location = new Point(8, 90);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(91, 29);
            btn_up.TabIndex = 2;
            btn_up.Text = "-1";
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_up_Click;
            btn_up.MouseEnter += btn_up_MouseEnter;
            btn_up.MouseLeave += btn_up_MouseLeave;
            // 
            // domain_up_down
            // 
            domain_up_down.Location = new Point(8, 57);
            domain_up_down.Name = "domain_up_down";
            domain_up_down.Size = new Size(91, 27);
            domain_up_down.TabIndex = 3;
            domain_up_down.Text = "0";
            domain_up_down.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.pizza;
            pictureBox1.Image = Properties.Resources.rolls;
            pictureBox1.Location = new Point(112, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 125);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.anime1;
            pictureBox2.Location = new Point(598, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 27);
            textBox1.TabIndex = 7;
            textBox1.MouseEnter += textBox1_MouseEnter;
            // 
            // button1
            // 
            button1.Location = new Point(131, 22);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 8;
            button1.Text = "+1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            // 
            // button2
            // 
            button2.Location = new Point(131, 90);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 9;
            button2.Text = "-1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(169, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 10;
            textBox2.Text = "Координаты мыши";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.anime;
            pictureBox3.Location = new Point(159, 375);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 99);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.ImageScalingSize = new Size(20, 20);
            ToolStripMenuItem.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            ToolStripMenuItem.Location = new Point(0, 0);
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(1902, 28);
            ToolStripMenuItem.TabIndex = 15;
            ToolStripMenuItem.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { изменениеРазмераОкнаToolStripMenuItem, выходИзПрограммыToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // изменениеРазмераОкнаToolStripMenuItem
            // 
            изменениеРазмераОкнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { х500ToolStripMenuItem, х900ToolStripMenuItem, х1080ToolStripMenuItem, вестиВручнуюToolStripMenuItem });
            изменениеРазмераОкнаToolStripMenuItem.Name = "изменениеРазмераОкнаToolStripMenuItem";
            изменениеРазмераОкнаToolStripMenuItem.Size = new Size(273, 26);
            изменениеРазмераОкнаToolStripMenuItem.Text = "Изменение размера окна";
            // 
            // х500ToolStripMenuItem
            // 
            х500ToolStripMenuItem.Name = "х500ToolStripMenuItem";
            х500ToolStripMenuItem.Size = new Size(195, 26);
            х500ToolStripMenuItem.Text = "1000х500";
            х500ToolStripMenuItem.Click += х500ToolStripMenuItem_Click;
            // 
            // х900ToolStripMenuItem
            // 
            х900ToolStripMenuItem.Name = "х900ToolStripMenuItem";
            х900ToolStripMenuItem.Size = new Size(195, 26);
            х900ToolStripMenuItem.Text = "1500х900";
            х900ToolStripMenuItem.Click += х900ToolStripMenuItem_Click;
            // 
            // х1080ToolStripMenuItem
            // 
            х1080ToolStripMenuItem.Name = "х1080ToolStripMenuItem";
            х1080ToolStripMenuItem.Size = new Size(195, 26);
            х1080ToolStripMenuItem.Text = "1920х1080";
            х1080ToolStripMenuItem.Click += х1080ToolStripMenuItem_Click;
            // 
            // вестиВручнуюToolStripMenuItem
            // 
            вестиВручнуюToolStripMenuItem.Name = "вестиВручнуюToolStripMenuItem";
            вестиВручнуюToolStripMenuItem.Size = new Size(195, 26);
            вестиВручнуюToolStripMenuItem.Text = "Вести вручную";
            вестиВручнуюToolStripMenuItem.Click += вестиВручнуюToolStripMenuItem_Click;
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            выходИзПрограммыToolStripMenuItem.Size = new Size(273, 26);
            выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            выходИзПрограммыToolStripMenuItem.Click += выходИзПрограммыToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1080, 38);
            button4.Name = "button4";
            button4.Size = new Size(126, 29);
            button4.TabIndex = 16;
            button4.Text = "Размножаюсь";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonAllDelete
            // 
            buttonAllDelete.Location = new Point(1212, 38);
            buttonAllDelete.Name = "buttonAllDelete";
            buttonAllDelete.Size = new Size(130, 29);
            buttonAllDelete.TabIndex = 17;
            buttonAllDelete.Text = "Удалить все";
            buttonAllDelete.UseVisualStyleBackColor = true;
            buttonAllDelete.Click += buttonAllDelete_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "ComboBox";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(160, 123);
            button3.Name = "button3";
            button3.Size = new Size(50, 29);
            button3.TabIndex = 20;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1348, 447);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(159, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1348, 228);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkedListBox1);
            flowLayoutPanel1.Controls.Add(listBox1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(1348, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(314, 178);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_low);
            groupBox1.Controls.Add(btn_up);
            groupBox1.Controls.Add(domain_up_down);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(112, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "///";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1187, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(155, 24);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "Изменить размер";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Enter += х900ToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1348, 480);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // MainTimer
            // 
            MainTimer.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1119, 194);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 28;
            label1.Text = "Текущее время";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1080, 218);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 29;
            button5.Text = "Старт";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1180, 217);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 30;
            button6.Text = "Стоп";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonAllDelete);
            Controls.Add(button4);
            Controls.Add(ToolStripMenuItem);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tbfirst);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = ToolStripMenuItem;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            Click += Form1_Click;
            MouseEnter += Form1_MouseEnter;
            MouseLeave += Form1_MouseLeave;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ToolStripMenuItem.ResumeLayout(false);
            ToolStripMenuItem.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbfirst;
        private Button btn_low;
        private Button btn_up;
        private DomainUpDown domain_up_down;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private MenuStrip ToolStripMenuItem;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem изменениеРазмераОкнаToolStripMenuItem;
        private ToolStripMenuItem х500ToolStripMenuItem;
        private ToolStripMenuItem х900ToolStripMenuItem;
        private ToolStripMenuItem х1080ToolStripMenuItem;
        private ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private ToolStripMenuItem вестиВручнуюToolStripMenuItem;
        private Button button4;
        private Button buttonAllDelete;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private MonthCalendar monthCalendar1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer MainTimer;
        private Label label1;
        private Button button5;
        private Button button6;
    }
}