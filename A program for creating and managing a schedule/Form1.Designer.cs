namespace A_program_for_creating_and_managing_a_schedule
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxHoursLeft;
        private System.Windows.Forms.TextBox textBoxAuditory;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelHoursLeft;
        private System.Windows.Forms.Label labelAuditory;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Button buttonGenerate;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxHoursLeft = new System.Windows.Forms.TextBox();
            this.textBoxAuditory = new System.Windows.Forms.TextBox();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelHoursLeft = new System.Windows.Forms.Label();
            this.labelAuditory = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.TabIndex = 0;

            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 30);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(200, 22);
            this.textBoxSubject.TabIndex = 1;

            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 10);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(100, 17);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Введите предмет";

            // 
            // textBoxHoursLeft
            // 
            this.textBoxHoursLeft.Location = new System.Drawing.Point(230, 30);
            this.textBoxHoursLeft.Name = "textBoxHoursLeft";
            this.textBoxHoursLeft.Size = new System.Drawing.Size(100, 22);
            this.textBoxHoursLeft.TabIndex = 3;

            // 
            // labelHoursLeft
            // 
            this.labelHoursLeft.AutoSize = true;
            this.labelHoursLeft.Location = new System.Drawing.Point(230, 10);
            this.labelHoursLeft.Name = "labelHoursLeft";
            this.labelHoursLeft.Size = new System.Drawing.Size(150, 17);
            this.labelHoursLeft.TabIndex = 4;
            this.labelHoursLeft.Text = "Часы по предмету (пары)";

            // 
            // textBoxAuditory
            // 
            this.textBoxAuditory.Location = new System.Drawing.Point(12, 80);
            this.textBoxAuditory.Name = "textBoxAuditory";
            this.textBoxAuditory.Size = new System.Drawing.Size(100, 22);
            this.textBoxAuditory.TabIndex = 5;

            // 
            // labelAuditory
            // 
            this.labelAuditory.AutoSize = true;
            this.labelAuditory.Location = new System.Drawing.Point(12, 60);
            this.labelAuditory.Name = "labelAuditory";
            this.labelAuditory.Size = new System.Drawing.Size(70, 17);
            this.labelAuditory.TabIndex = 6;
            this.labelAuditory.Text = "Аудитория";

            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(130, 80);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(200, 22);
            this.textBoxTeacher.TabIndex = 7;

            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(130, 60);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(84, 17);
            this.labelTeacher.TabIndex = 8;
            this.labelTeacher.Text = "Преподаватель";

            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 120);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxHoursLeft);
            this.Controls.Add(this.labelHoursLeft);
            this.Controls.Add(this.textBoxAuditory);
            this.Controls.Add(this.labelAuditory);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Генератор расписания";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        }
    }
}
