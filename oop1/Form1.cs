
namespace oop1
{
    public partial class Form1 : Form
    {
        Button btn1 = new Button();
        PictureBox pb1 = new PictureBox();
        TextBox tb1 = new TextBox();
        int[] child = new int[8];
        List<Button> buttons = new List<Button>();
        bool checkDelete = false;
        int loc = 0;
        int num = 0;
        int num1 = 0;
        int CursorX = Cursor.Position.X;
        int CursorY = Cursor.Position.Y;
        bool checknum = false;
        int cnumber = 0;


        Random rndx = new Random();
        Random rndy = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void tbfirst_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.PlaceholderText = "�� ������";
        }
        private void tbfirst_MouseLeave(object sender, EventArgs e)
        {
            tbfirst.Text = "�����-�� � ������� ��� ��� ���������� :)";
        }
        private void btn_low_Click(object sender, EventArgs e)
        {
            if (checknum == true)
            {
                num += 1;
                domain_up_down.Text = num.ToString();
            }
        }
        private void btn_up_Click(object sender, EventArgs e)
        {
            if (checknum == true)
            {
                num -= 1;
                domain_up_down.Text = num.ToString();
            }
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            domain_up_down.Text = num.ToString();
        }
        private void btn_low_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "������� ����� ��������� �� �������";
        }
        private void btn_low_MouseLeave(object sender, EventArgs e)
        {
            tbfirst.Text = "����������...";
        }
        private void btn_up_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "������� ����� ������ �������";
        }
        private void btn_up_MouseLeave(object sender, EventArgs e)
        {
            tbfirst.Text = "����������...";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.ErrorImage;
            tbfirst.Text = "������� �����... ���� ������ ���� �����!";
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "��� ������� ����� ��������. �������?";
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            int rany = rndy.Next(100, 500);
            int ranx = rndx.Next(200, 1000);
            pictureBox2.Location = new Point(ranx, rany);
            tbfirst.Text = "�� ������... ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                checknum = false;
            }
            else
            {
                checknum = true;
            }
            num1 += 1;
            textBox1.Text = num1.ToString();
            tbfirst.Text = "��� ���������� �������� 3 �������� ������ - ������������� �����";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                checknum = false;
            }
            else
            {
                checknum = true;
            }
            num1 -= 1;
            textBox1.Text = num1.ToString();
            tbfirst.Text = "��� ���������� �������� 3 �������� ������ - ������������� �����";
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "��� ���������� �������� 3 �������� ������ - ������������� �����";
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "��� ���������� �������� 3 �������� ������  ����������� �����";
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            tbfirst.Text = "��� ������ �������, �� ����� ������������� ����� �������";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox3.Text = e.X.ToString() + "   " + e.Y.ToString();
            richTextBox1.Text = e.X.ToString() + "   " + e.Y.ToString();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Text = "�������";
            newButton.Location = new Point(Control.MousePosition.X - 50, Control.MousePosition.Y - 50);
            this.Controls.Add(newButton);
            newButton.Click += new EventHandler(newButton_Click);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("������ ���� �������!");
            pictureBox3.Visible = false;
        }
        private void �1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(1920, 1080);
        }

        private void �500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 500);
        }
        private void �900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(1500, 900);
        }
        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbfirst.Text = "������� ������ ����� ������";
            tb1.Size = new Size(400, 30);
            tb1.Location = new Point(500, 500);
            tb1.Visible = true;
            this.Controls.Add(tb1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                loc += 29;
                Button btn1 = new Button();
                btn1.Size = new Size(126, 29);
                btn1.Location = new Point(1080, 38 + loc);
                btn1.Text = "������� " + i;
                this.Controls.Add(btn1);
                btn1.Click += btn1OnClick;
                buttons.Add(btn1);

            }
        }
        private void btn1OnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                MessageBox.Show("������ " + button.Name);
                button.Dispose();

            }
        }

        private void buttonAllDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                Controls.Remove(buttons[i]);

                loc = 0;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("�����" + cnumber);
            checkedListBox1.Items.Add("�����" + cnumber);
            listBox1.Items.Add("�����" + cnumber);
            cnumber++;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("������� ����: " + monthCalendar1.TodayDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ���� � �����: " + dateTimePicker1.Value);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("������� �����: {0}", DateTime.Now.ToString("HH:mm:ss"));

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {



        }
        private void newButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Dispose();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;
            MainTimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainTimer.Stop();
            
            MainTimer.Enabled = false;
        }
    }
}
