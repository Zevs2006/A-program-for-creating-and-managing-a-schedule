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

        // ����� ��� �������� �����
        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� DataGridView ��� ����������� ����������
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "����������";
            dataGridView1.Columns[1].Name = "���������";
            dataGridView1.Columns[2].Name = "�������������";
            dataGridView1.Columns[3].Name = "���� ������";
            dataGridView1.Columns[4].Name = "�����";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        // ����� ��� ��������� ����������
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject.Text;
            string auditory = textBoxAuditory.Text;
            string teacher = textBoxTeacher.Text;
            int pairsLeft;

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(auditory) || string.IsNullOrEmpty(teacher) || !int.TryParse(textBoxHoursLeft.Text, out pairsLeft))
            {
                MessageBox.Show("����������, ��������� ��� ���� � ������� ���������� ���������� ���.");
                return;
            }

            // ��������� ����������
            string[] daysOfWeek = { "�����������", "�������", "�����", "�������", "�������" };
            int currentDay = 0;
            int currentPairTime = 9; // ������ ������� � 9:00

            while (pairsLeft > 0)
            {
                // ��������� ������ � �������
                string[] row = { subject, auditory, teacher, daysOfWeek[currentDay], $"{currentPairTime}:00 - {currentPairTime + 2}:00" };
                dataGridView1.Rows.Add(row);

                // ��������� ���������� ���������� ���
                pairsLeft--;

                // ��������� � ���������� ������� (��������, � 9 �� 11, � 11 �� 13)
                currentPairTime += 2;

                // ���� ��� ���� �� ������� ���� ��������� (��������, �� 17:00), ��������� �� ��������� ����
                if (currentPairTime >= 17)
                {
                    currentDay++;
                    currentPairTime = 9; // ������������ � 9:00 ��� ������ ���

                    // ���� ����� �� ����� ������, ������������ � ������
                    if (currentDay >= daysOfWeek.Length)
                    {
                        currentDay = 0;
                    }
                }
            }

            // ������� ���� ����� ����� ���������
            textBoxSubject.Clear();
            textBoxAuditory.Clear();
            textBoxTeacher.Clear();
            textBoxHoursLeft.Clear();
        }
    }
}
