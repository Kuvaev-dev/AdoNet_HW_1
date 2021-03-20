using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdoNet_HW_1
{
    public partial class Form1 : Form
    {
        DB_Logic db_Logic = new DB_Logic();
        public Form1()
        {
            InitializeComponent();
            numeric_calory.Location = new Point(20, 40);
            numeric_calory.Maximum = 30000;
            numeric_calory.Minimum = 100;
            numeric_calory.Value = 0;
            label_name.Location = new Point(20, 20);
            label_name.Text = "Калорийность";

            combo_color.Location = new Point(20, 100);
            combo_color.Items.AddRange(new string[] { "Красный", "Оранжевый", "Жёлтый", "Зелёный", "Голубой", "Синий", "Фиолетовый" });
            combo_color.SelectedIndex = 0;
            label_type.Location = new Point(20, 80);
            label_type.Text = "Цвет продукта";

            radio_f.Location = new Point(20, 160);
            radio_f.Text = "Фрукт";
            radio_f.Size = new Size(60, radio_f.Size.Height);
            radio_f.Checked = true;
            radio_v.Location = new Point(80, 160);
            radio_v.Text = "Овощ";
            radio_v.Size = new Size(60, radio_v.Size.Height);
            label_type.Location = new Point(50, 140);
            label_type.Text = "Тип продукта";

            button_push.Location = new Point(this.ClientSize.Width - button_push.Size.Width, this.ClientSize.Height - button_push.Size.Height);
            button_push.Text = "Внести";

            button_push.Click += Button_push_Click;

            this.Controls.AddRange(new Control[] { numeric_calory, combo_color, radio_f, radio_v, button_push, label_name, label_type, label_color});
        }

        public void Button_push_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.calory = (int)numeric_calory.Value;
            food.color = combo_color.SelectedItem.ToString();
            if (radio_f.Checked == true)
                food.type = true;
            else
                food.type = false;

            if (db_Logic.Button_Save(food))
                MessageBox.Show("Запись выполнена успешно!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Ошибка записи!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
