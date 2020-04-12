using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect1
{
    class NewImgPrompt : Form
    {
        private Button dateSubmit;
        private PictureBox pictureBox1;
        private Label PhotoName;
        private DateTimePicker dateTimePicker1;
        public NewImgPrompt(string path)
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(path);
            PhotoName.Text = path;
        }

        public DateTime GetDate()
        {
            return dateTimePicker1.Value;
        }

        private void InitializeComponent()
        {
            this.dateSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhotoName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateSubmit
            // 
            this.dateSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSubmit.Location = new System.Drawing.Point(769, 347);
            this.dateSubmit.Name = "dateSubmit";
            this.dateSubmit.Size = new System.Drawing.Size(106, 75);
            this.dateSubmit.TabIndex = 0;
            this.dateSubmit.Text = "Submit";
            this.dateSubmit.UseVisualStyleBackColor = true;
            this.dateSubmit.Click += new System.EventHandler(this.dateSubmit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(576, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 355);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PhotoName
            // 
            this.PhotoName.AutoSize = true;
            this.PhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhotoName.Location = new System.Drawing.Point(66, 23);
            this.PhotoName.Name = "PhotoName";
            this.PhotoName.Size = new System.Drawing.Size(83, 18);
            this.PhotoName.TabIndex = 3;
            this.PhotoName.Text = "PhotoLabel";
            // 
            // NewImgPrompt
            // 
            this.ClientSize = new System.Drawing.Size(905, 481);
            this.Controls.Add(this.PhotoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateSubmit);
            this.Name = "NewImgPrompt";
            this.Text = "Date select";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dateSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
