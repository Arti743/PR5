using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guide_to_Teyvat
{
    public partial class Char : Form
    {
        public Char()
        {
            InitializeComponent();
        }

        private void Char_Load(object sender, EventArgs e)
        {
            ToolTip q = new ToolTip();
            q.SetToolTip(buttonNahida, "Нахида");
            ToolTip w = new ToolTip();
            w.SetToolTip(buttonNilu, "Нилу");
            ToolTip r = new ToolTip();
            r.SetToolTip(buttonCyno, "Сайно");
            ToolTip t = new ToolTip();
            t.SetToolTip(buttonCandace, "Кандакия");
            ToolTip y = new ToolTip();
            y.SetToolTip(buttonDori, "Дори");
            ToolTip u = new ToolTip();
            u.SetToolTip(buttonTighnari, "Тигнари");
            ToolTip i = new ToolTip();
            i.SetToolTip(buttonCollei, "Коллеи");
            ToolTip o = new ToolTip();
            o.SetToolTip(buttonHeizou, "Хэйдзо");
            ToolTip p = new ToolTip();
            p.SetToolTip(buttonKuki, "Куки Синобу");
            ToolTip a = new ToolTip();
            a.SetToolTip(buttonYelan, "Е Лань");
            ToolTip s = new ToolTip();
            s.SetToolTip(buttonAyato, "Аято");
            ToolTip d = new ToolTip();
            d.SetToolTip(buttonYaeMiko, "Яэ Мико");
            ToolTip f = new ToolTip();
            f.SetToolTip(buttonShenKhe, "Шень Хэ");
            ToolTip g = new ToolTip();
            g.SetToolTip(buttonYunTszin, "Юнь Цзинь");
            ToolTip h = new ToolTip();
            h.SetToolTip(buttonItto, "Итто");
            ToolTip j = new ToolTip();
            j.SetToolTip(buttonGorou, "Горо");
            ToolTip k = new ToolTip();
            k.SetToolTip(buttonThoma, "Тома");
            ToolTip l = new ToolTip();
            l.SetToolTip(buttonKokomi, "Сангономия Кокоми");
            ToolTip z = new ToolTip();
            z.SetToolTip(buttonShougun, "Сёгун Райдэн");
            ToolTip x = new ToolTip();
            x.SetToolTip(buttonAloy, "Элой");
            ToolTip с = new ToolTip();
            с.SetToolTip(buttonSara, "Сара");
            ToolTip v = new ToolTip();
            v.SetToolTip(buttonYoimiya, "Ёимия");
            ToolTip b = new ToolTip();
            b.SetToolTip(buttonSayu, "Саю");
            ToolTip n = new ToolTip();
            n.SetToolTip(buttonAyaka, "Аяка");
        }
        private void buttonNahida_Click(object sender, EventArgs e)
        {
            Nahida Win = new Nahida();
            Win.Show();
        }
        private void buttonNilu_Click(object sender, EventArgs e)
        {
            Nilu Win = new Nilu();
            Win.Show();
        }
        private void buttonCyno_Click(object sender, EventArgs e)
        {
            Cyno Win = new Cyno();
            Win.Show();
        }
        private void buttonCandace_Click(object sender, EventArgs e)
        {
            Candace Win = new Candace();
            Win.Show();
        }

        private void Char_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        private void label_table_Click(object sender, EventArgs e)
        {
            label_table.Visible = false;
            label_Back.Visible = true;
            openchild(panel4, new Table_Char());
        }

        private void label_Back_Click(object sender, EventArgs e)
        {
            label_table.Visible = true;
            label_Back.Visible = false;
            openchild(panel1, new Char());
        }
    }
}
