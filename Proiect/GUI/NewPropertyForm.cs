using System;
using System.Windows.Forms;

namespace Proiect1
{
    class NewPropertyForm: Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Label PropertyName;
        private Label PropertyDesc;
        private Button SubmitBtn;

        public NewPropertyForm()
        {
            InitializeComponent();

        }

        public Tuple<string, string> GetTxtValues()
        {
            return new Tuple<string, string>(textBox1.Text,textBox2.Text);
        }


        private void InitializeComponent()
        {
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PropertyName = new System.Windows.Forms.Label();
            this.PropertyDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(211, 269);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(138, 57);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(53, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 27);
            this.textBox2.TabIndex = 2;
            // 
            // PropertyName
            // 
            this.PropertyName.AutoSize = true;
            this.PropertyName.Location = new System.Drawing.Point(50, 39);
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.Size = new System.Drawing.Size(105, 17);
            this.PropertyName.TabIndex = 3;
            this.PropertyName.Text = "Property name:";
            // 
            // PropertyDesc
            // 
            this.PropertyDesc.AutoSize = true;
            this.PropertyDesc.Location = new System.Drawing.Point(50, 141);
            this.PropertyDesc.Name = "PropertyDesc";
            this.PropertyDesc.Size = new System.Drawing.Size(139, 17);
            this.PropertyDesc.TabIndex = 4;
            this.PropertyDesc.Text = "Property description:";
            // 
            // NewPropertyForm
            // 
            this.ClientSize = new System.Drawing.Size(432, 375);
            this.Controls.Add(this.PropertyDesc);
            this.Controls.Add(this.PropertyName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "NewPropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SubmitBtn_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Warning!\n No empty fields!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
