using System.Drawing;
using System.Windows.Forms;

namespace AdoNet_HW_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DarkBlue;
            this.Text = "Ввод";

            numeric_calory = new NumericUpDown();
            combo_color = new ComboBox();
            radio_f = new RadioButton();
            radio_v = new RadioButton();
            button_push = new Button();
            label_name = new Label();
            label_type = new Label();
            label_color = new Label();
            veg_count = new Label();
        }

        NumericUpDown numeric_calory;
        ComboBox combo_color;
        RadioButton radio_v;
        RadioButton radio_f;
        Button button_push;
        Label label_name;
        Label label_type;
        Label label_color;
        Label veg_count;

        #endregion
    }
}

