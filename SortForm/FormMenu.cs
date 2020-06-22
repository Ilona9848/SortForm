using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortForm
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            MenuClose();
            SortOpen();
        }

        public void FileForTheChart()
        {
            Random rnd = new Random();
            StreamWriter sw = new StreamWriter("points.txt");
            for (int j = 5; j <= 2000;j+=25)
            {
                long t = 0;
                for (int k = 0; k < 10; k++)
                {
                    MyList points = new MyList();
                    for (int i = 0; i < j; i++)
                    {
                        points.PushBack(rnd.Next(-1000, 1000));
                    }
                    string s = points.Print();
                    Stopwatch st = new Stopwatch();
                    st.Start();
                    points.InsertionSort();
                    st.Stop();
                    t += st.Elapsed.Ticks;
                    sw.WriteLine("{" + s + "}");
                }
                sw.WriteLine(j + " " + t/10 );
            }
            sw.Close();
        }

        private void SortOpen()
        {
            toolStripSort.Show();//панелька
            labelSortInstruction.Show();//введите элемент
            richTextBoxItems.Show();//неотсортированный 
            buttonSortInSort.Show();//отсортировать
            richTextBoxSortedList.Hide();
            labelTime.Hide();
            richTextBoxItems.Clear();
            labelSortInstruction.Text = "Введите элементы";
            this.Text = "Отсортировать";
        }
        public void MenuClose()
        {
            labelHello.Hide();
            pictureBoxCards.Hide();
            buttonSort.Hide();
            buttonInstruction.Hide();
            buttonInfo.Hide();
            buttonChart.Hide();
        }
        public void MenuOpen()
        {
            buttonSort.Show();
            buttonInstruction.Show();
            buttonInfo.Show();
            buttonChart.Show();
            buttonShowMas.Hide();
            textBoxCount.Hide();
            label1.Hide();
            toolStripSort.Hide();
            toolStripchart.Hide();
            labelSortInstruction.Hide();
            labelHello.Show();
            pictureBoxCards.Show();
            richTextBoxItems.Hide();
            buttonSortInSort.Hide();
            richTextBoxSortedList.Hide();
            labelTime.Hide();
            this.Text = "Меню";
            chartSort.Hide();
            richTextBoxInfo.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MenuOpen();
        }

        private void buttonSortInSort_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxSortedList.Clear();
                MyList list = new MyList();
                string[] items = richTextBoxItems.Text.Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
                for (int i=0;i<items.Length;i++)
                {
                    list.PushBack(Convert.ToInt32(items[i]));
                }
                Stopwatch st = new Stopwatch();
                st.Start();
                list.InsertionSort();
                st.Stop();
                richTextBoxSortedList.Text = "Отсортированный массив:\n" + list.Print();
                labelTime.Text = "Затраченное время:\n"+st.Elapsed;
                richTextBoxSortedList.Show();
                labelTime.Show();
            }
            catch
            {
                MessageBox.Show("Проверьте ввод данных.\nПомните, вводите можно целые числа через пробел или запятую", "Что-то пошло не так...",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            MenuOpen();
        }

        private void ToolStripMenuItemRandomAnyCount_Click(object sender, EventArgs e)
        {
            SortOpen();
            buttonShowMas.Hide();
            label1.Hide();
            textBoxCount.Hide();
            richTextBoxItems.Clear();
            Random random = new Random();
            int count = random.Next(5, 200);
            for(int i=0;i<count;i++)
            {
                richTextBoxItems.Text += random.Next(-1000,1000) + " ";
            }
            labelSortInstruction.Text = "Количество элементов: " + count;
        }

        private void ToolStripMenuItemRandom_Click(object sender, EventArgs e)
        {
            label1.Show();
            textBoxCount.Show();
            textBoxCount.Clear();
            buttonShowMas.Show();
            labelSortInstruction.Hide();
            richTextBoxItems.Hide();
            buttonSortInSort.Hide();
            richTextBoxSortedList.Hide();
            labelTime.Hide();
        }

        private void buttonShowMas_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxItems.Clear();
                textBoxCount.Hide();
                buttonShowMas.Hide();
                label1.Hide();
                SortOpen();
                Random random = new Random();
                int count = Convert.ToInt32(textBoxCount.Text);
                for (int i = 0; i < count; i++)
                {
                    richTextBoxItems.Text += random.Next(-1000, 1000) + " ";
                }
                labelSortInstruction.Text = "Количество элементов: " + count;
            }
            catch
            {
                MessageBox.Show("Введите количество элементов", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if(op.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(op.FileName);
                string s = sr.ReadLine();
                SortOpen();
                richTextBoxItems.Text = s;
                sr.Close();
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            sv.FileName = "Сортировка вставками" + DateTime.Now.ToShortDateString();
            if(sv.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sv.FileName);
                sw.WriteLine("Изначальный массив элементов:");
                sw.WriteLine(richTextBoxItems.Text);
                sw.WriteLine(richTextBoxSortedList.Text);
                sw.WriteLine(labelTime.Text);
                sw.Close();
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            chartSort.Series[0].Points.Clear();
            chartSort.Series[1].Points.Clear();
            toolStripchart.Show();
            MenuClose();
            this.Text = "График";
            chartSort.Show();
            //FileForTheChart();
            for(int i=1;i<2001;i++)
            {
                chartSort.Series[0].Points.AddXY(i, (i * i)/140);
            }
            StreamReader sr = new StreamReader("points.txt");
            while(!sr.EndOfStream)
            {
                string ss = sr.ReadLine();
                if (ss != ""&&ss[0]!='{')
                {
                    string[] s = ss.Split();
                    chartSort.Series[1].Points.AddXY(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]));
                }
            }
            sr.Close();
        }

        private void toolStripButtonBackChart_Click(object sender, EventArgs e)
        {
            MenuOpen();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MenuClose();
            toolStripchart.Show();
            StreamReader sr = new StreamReader("info.txt");
            string s = sr.ReadToEnd();
            richTextBoxInfo.Text = s;
            richTextBoxInfo.Show();
            this.Text="Если честно, это все просто некрасиво написанная теория";
        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Так как данное приложение является лишь демо-версией, то сортировать вы можете лишь целые числа.\nДля того, чтобы отсортировать список элементов нажмите на кнопку\"Отсортировать\" на вкладке меню. В соответствующее поле введите элементы через пробел или через запятую и нажмите на кнопку\"Отсортировать\". \nТак же возможен набор случайных чисел. Для этого после переход на вкладку сортировки нажмите на кубик на верхней панеле и выберите нужную позицию. Далее следуйте указаниям на экране.\nЕсли вы хотите посмотреть график данной сортировки, то на вкладке меню, нажмите на \"Посмотреть график\". Красным цветом указана асимптотика.\nЕсли вы хотите прочитать больше о сортировке и просмотреть алгоритм действий, то нажмите на кнопку \"Получить информацию о сортировке\". \nУдачи! Надеемся, вы оцените наше приложение", "Краткое руководство пользователя");
        }

    }
    public class Node
    {
        public int Data;
        public string Data2;
        public Node Next;
        public Node Previous;
        public Node(int data)
        {
            this.Data = data;
        }
    }
    public class MyList
    {
        public Node Head;
        public Node Tail;

        public void PushBack(int item)
        {
            Node newNode = new Node(item);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
        } 

        public void PushFront(int item)
        {
            Node newNode = new Node(item);
            if (Head != null)
            {
                newNode.Next = Head;
                Head.Previous = newNode;
            }

            Head = newNode;
        }
        
        public void InsertionSort()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }
            Node current = Head.Next;
            Node sorted = Head;
            while (sorted.Next != null)
            {
                if (sorted.Data <= current.Data)
                {
                    sorted = sorted.Next;
                    current = current.Next;
                }
                else
                {
                    SortBack(sorted, current);
                    current = sorted.Next;
                }
            }
        }
        public void SortBack(Node sorted, Node current)
        {
            if (current.Next != null)
            {
                current.Next.Previous = sorted;
            }
            sorted.Next = current.Next;
            Node k = sorted.Previous;
            while (k != null)
            {
                if (k.Data < current.Data)
                {
                    k.Next.Previous = current;
                    current.Next = k.Next;
                    k.Next = current;
                    current.Previous = k;
                    return;
                }
                else
                {
                    k = k.Previous;
                }
            }
            PushFront(current.Data);
        }
        public string Print()
        {
            string result = "";
            Node current = Head;
            while (current != null)
            {
                result += current.Data + " ";
                current = current.Next;
            }

            return result;
        }
    }
}
