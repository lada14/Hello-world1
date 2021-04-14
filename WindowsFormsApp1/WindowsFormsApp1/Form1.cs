using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 6);
            if (value == 0) MessageBox.Show("Не торопите события и не вмешивайтесь в чужие дела – это может выйти вам боком.");
            else if (value == 1) MessageBox.Show("Не бойтесь рисковать – рискованные поступки принесут больше пользы, чем вы планируете.");
            else if (value == 2) MessageBox.Show("Остерегайтесь скандалов – вероятно обострение отношений с неприятелями.");
            else if (value == 3) MessageBox.Show("Будьте внимательны – новости, которые вы узнаете, окажутся для вас полезными.");
            else if (value == 4) MessageBox.Show("Не беритесь за новое – на пути к осуществлению ваших планов могут встать непреодолимые трудности.");
            else if (value == 5) MessageBox.Show(" Не бойтесь менять направление – вы справитесь с любыми проблемами, если проявите характер и останетесь при своем мнении.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"S");
            key.SetValue("textBox2", textBox2.Text);
            MessageBox.Show("Сохранено в реестр");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"S");
            if (key != null)
            {
                textBox2.Text = key.GetValue("textBox2").ToString();               
            }
        }
    }
}
