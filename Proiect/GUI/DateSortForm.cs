using System;
using System.Windows.Forms;

namespace Proiect1
{
    class DateSortForm : Form
    {
        private Button SubmitBtn;
        private DateTimePicker dateTimePicker1;

        public DateSortForm()
        {
            InitializeComponent();
        }

        public DateTime GetDateTime()
        {
            return dateTimePicker1.Value;
        }

        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(107, 222);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(70, 43);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DateSortForm
            // 
            this.ClientSize = new System.Drawing.Size(297, 277);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateSortForm";
            this.ResumeLayout(false);


        }

        private void SubmitBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
