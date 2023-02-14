using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace kursach
{
    public partial class MainForm : MaterialForm
    {
        List<CardIndex> phones = new List<CardIndex>(); //список всех номеров
        List<CodePhone> codes = new List<CodePhone>(); //список кодов номеров
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple300, Primary.DeepPurple500, Primary.Brown600, Accent.Green400, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string[]> rows = File.ReadAllLines("DataBase.txt", Encoding.GetEncoding(1251)).Select(x => x.Split(',')).ToList();
            for (int i = 0; i < rows.Count; i++)
            {
                CardIndex card = new CardIndex();
                card.Name = rows[i][0];
                card.Phone = rows[i][1];
                phones.Add(card);
                dataGridView1.Rows.Add(rows[i]);
            }
            List<string[]> rows1 = File.ReadAllLines("Code.txt", Encoding.GetEncoding(1251)).Select(x => x.Split(',')).ToList();
            for (int i = 0; i < rows1.Count; i++)
            {
                CodePhone code = new CodePhone();
                code.Code = int.Parse(rows1[i][0]);
                code.Price = Convert.ToDouble(rows1[i][1]);
                codes.Add(code);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string phone = textBoxAddPhone.Text;
            if (CheckName(name) && CheckPhone(phone, true))
            {
                dataGridView1.Rows.Add(name, phone);
                using (StreamWriter sw = new StreamWriter("DataBase.txt", false, Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < Convert.ToInt32(dataGridView1.Rows.Count); i++)
                    {
                        sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                }
                List<string[]> cards = File.ReadAllLines("DataBase.txt", Encoding.GetEncoding(1251)).Select(x => x.Split(',')).ToList();
                CardIndex card = new CardIndex();
                int index = cards.Count - 1;
                card.Name = cards[index][0];
                card.Phone = cards[index][1];
                phones.Add(card);
                MessageBox.Show("Данные добавлены!");
                textBoxAddName.Clear();
                textBoxAddPhone.Clear();
            }
            else
            {
                if (!CheckName(name))
                {
                    MessageBox.Show("Имя задано некорректно!");
                }
                if (!CheckPhone(phone, true))
                {
                    MessageBox.Show("Тедефон задан некорректно!");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данные?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridView1.CurrentRow.Index;
                    int index1 = 0;
                    CardIndex cardIndex = GetIndex(ref index);
                    foreach (var item in phones)
                    {
                        if (item.Name == cardIndex.Name && item.Phone == cardIndex.Phone)
                        {
                            dataGridView1.Rows.RemoveAt(index1);
                            break;
                        }
                        index1++;
                    }
                    phones.RemoveAt(index);
                    using (StreamWriter sw = new StreamWriter("DataBase.txt", false, Encoding.GetEncoding(1251)))
                    {
                        for (int i = 0; i < Convert.ToInt32(dataGridView1.Rows.Count); i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + ',' + dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                }
                catch { }
            }
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text;
            int codePhone = int.Parse(phone.ElementAt(1).ToString() + phone.ElementAt(2).ToString() + phone.ElementAt(3).ToString());
            int time;
            bool flag = false;
            if (int.TryParse(textBoxTime.Text, out time))
            {
                if (CheckPhone(phone, false) && CheckTime(time))
                {
                    foreach (var item in codes)
                    {
                        if (item.Code == codePhone)
                        {
                            double price = time * item.Price;
                            MessageBox.Show("К оплате " + price + " руб.");
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        double price = time * 2;
                        MessageBox.Show("К оплате " + price + " руб.");
                    }
                    textBoxPhone.Clear();
                    textBoxTime.Clear();
                }
                else
                {
                    if (!CheckPhone(phone, false))
                    {
                        MessageBox.Show("Некорректный номер телефона!");
                    }
                    if (!CheckTime(time))
                    {
                        MessageBox.Show("Некорректно введено время!");
                    }
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool CheckName(string name)
        {
            if (name.Length < 4 || name.Length > 40)
            {
                return false;
            }
            foreach (var item in name)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckPhone(string phone, bool flag)
        {
            if (phone.Length != 11)
            {
                return false;
            }
            foreach (var item in phone)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
            }
            if (phone.ElementAt(0).ToString() != "7" && phone.ElementAt(0).ToString() != "8")
            {
                return false;
            }
            foreach (var item in phones)
            {
                if (item.Phone == phone)
                {
                    if (flag)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            if (!flag)
            {
                return false;
            }
            return true;
        }

        private bool CheckTime(int time)
        {
            if (time <= 0 || time > 100000)
            {
                return false;
            }
            return true;
        }

        private CardIndex GetIndex(ref int index)
        {
            CardIndex cardIndex = new CardIndex();
            for (int i = 0; i < phones.Count; i++)
            {
                if (i == index)
                {
                    cardIndex = phones.ElementAt(i);
                }
            }
            return cardIndex;
        }
    }
}
