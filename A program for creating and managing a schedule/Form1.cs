using System;
using System.Windows.Forms;

namespace A_program_for_creating_and_managing_a_schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Настройка DataGridView для отображения расписания
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Дисциплина";
            dataGridView1.Columns[1].Name = "Аудитория";
            dataGridView1.Columns[2].Name = "Преподаватель";
            dataGridView1.Columns[3].Name = "День недели";
            dataGridView1.Columns[4].Name = "Время";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        // Метод для генерации расписания
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject.Text;
            string auditory = textBoxAuditory.Text;
            string teacher = textBoxTeacher.Text;
            int pairsLeft;

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(auditory) || string.IsNullOrEmpty(teacher) || !int.TryParse(textBoxHoursLeft.Text, out pairsLeft))
            {
                MessageBox.Show("Пожалуйста, заполните все поля и введите корректное количество пар.");
                return;
            }

            // Генерация расписания
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };
            int currentDay = 0;
            int currentPairTime = 9; // Начало занятий в 9:00

            while (pairsLeft > 0)
            {
                // Добавляем запись в таблицу
                string[] row = { subject, auditory, teacher, daysOfWeek[currentDay], $"{currentPairTime}:00 - {currentPairTime + 2}:00" };
                dataGridView1.Rows.Add(row);

                // Уменьшаем количество оставшихся пар
                pairsLeft--;

                // Переходим к следующему времени (например, с 9 до 11, с 11 до 13)
                currentPairTime += 2;

                // Если все пары на текущий день заполнены (например, до 17:00), переходим на следующий день
                if (currentPairTime >= 17)
                {
                    currentDay++;
                    currentPairTime = 9; // Возвращаемся к 9:00 для нового дня

                    // Если дошли до конца недели, возвращаемся к началу
                    if (currentDay >= daysOfWeek.Length)
                    {
                        currentDay = 0;
                    }
                }
            }

            // Очищаем поля ввода после генерации
            textBoxSubject.Clear();
            textBoxAuditory.Clear();
            textBoxTeacher.Clear();
            textBoxHoursLeft.Clear();
        }
    }
}
