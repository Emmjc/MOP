namespace PaymentMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            rdButtonMasterCard = new RadioButton();
            rdButtonVisa = new RadioButton();
            pictureBox2 = new PictureBox();
            rdButtonCash = new RadioButton();
            pictureBox3 = new PictureBox();
            txtBoxCName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxMonth = new TextBox();
            txtBoxYr = new TextBox();
            label4 = new Label();
            txtBoxCode1 = new TextBox();
            label5 = new Label();
            txtBoxCNum = new TextBox();
            txtBoxCode2 = new TextBox();
            txtBoxCode3 = new TextBox();
            btnCompleteOrder = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 22);
            label1.TabIndex = 0;
            label1.Text = "Choose a payment method";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // rdButtonMasterCard
            // 
            rdButtonMasterCard.AutoSize = true;
            rdButtonMasterCard.BackColor = Color.AliceBlue;
            rdButtonMasterCard.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonMasterCard.Location = new Point(34, 56);
            rdButtonMasterCard.Name = "rdButtonMasterCard";
            rdButtonMasterCard.Size = new Size(86, 18);
            rdButtonMasterCard.TabIndex = 3;
            rdButtonMasterCard.TabStop = true;
            rdButtonMasterCard.Text = "MasterCard";
            rdButtonMasterCard.UseVisualStyleBackColor = false;
            // 
            // rdButtonVisa
            // 
            rdButtonVisa.AutoSize = true;
            rdButtonVisa.BackColor = Color.AliceBlue;
            rdButtonVisa.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonVisa.Location = new Point(187, 56);
            rdButtonVisa.Name = "rdButtonVisa";
            rdButtonVisa.Size = new Size(47, 18);
            rdButtonVisa.TabIndex = 5;
            rdButtonVisa.TabStop = true;
            rdButtonVisa.Text = "Visa";
            rdButtonVisa.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(187, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // rdButtonCash
            // 
            rdButtonCash.AutoSize = true;
            rdButtonCash.BackColor = Color.AliceBlue;
            rdButtonCash.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonCash.Location = new Point(346, 56);
            rdButtonCash.Name = "rdButtonCash";
            rdButtonCash.Size = new Size(123, 18);
            rdButtonCash.TabIndex = 7;
            rdButtonCash.TabStop = true;
            rdButtonCash.Text = "Over The Counter";
            rdButtonCash.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(347, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // txtBoxCName
            // 
            txtBoxCName.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCName.Location = new Point(34, 175);
            txtBoxCName.Name = "txtBoxCName";
            txtBoxCName.Size = new Size(253, 23);
            txtBoxCName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(34, 157);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 9;
            label2.Text = "Cardholder name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(313, 157);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 11;
            label3.Text = "Expiration date";
            // 
            // txtBoxMonth
            // 
            txtBoxMonth.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMonth.ForeColor = SystemColors.ControlDarkDark;
            txtBoxMonth.Location = new Point(313, 175);
            txtBoxMonth.Name = "txtBoxMonth";
            txtBoxMonth.Size = new Size(40, 23);
            txtBoxMonth.TabIndex = 10;
            txtBoxMonth.Text = "MM";
            txtBoxMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxYr
            // 
            txtBoxYr.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxYr.ForeColor = SystemColors.ControlDarkDark;
            txtBoxYr.Location = new Point(359, 175);
            txtBoxYr.Name = "txtBoxYr";
            txtBoxYr.Size = new Size(47, 23);
            txtBoxYr.TabIndex = 12;
            txtBoxYr.Text = "YYYY";
            txtBoxYr.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(313, 210);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 16;
            label4.Text = "CVC code";
            // 
            // txtBoxCode1
            // 
            txtBoxCode1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCode1.ForeColor = SystemColors.ControlDarkDark;
            txtBoxCode1.Location = new Point(313, 228);
            txtBoxCode1.Name = "txtBoxCode1";
            txtBoxCode1.Size = new Size(27, 23);
            txtBoxCode1.TabIndex = 15;
            txtBoxCode1.Text = "0";
            txtBoxCode1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(34, 210);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 14;
            label5.Text = "Card number";
            // 
            // txtBoxCNum
            // 
            txtBoxCNum.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCNum.Location = new Point(34, 228);
            txtBoxCNum.Name = "txtBoxCNum";
            txtBoxCNum.Size = new Size(253, 23);
            txtBoxCNum.TabIndex = 13;
            // 
            // txtBoxCode2
            // 
            txtBoxCode2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCode2.ForeColor = SystemColors.ControlDarkDark;
            txtBoxCode2.Location = new Point(346, 228);
            txtBoxCode2.Name = "txtBoxCode2";
            txtBoxCode2.Size = new Size(27, 23);
            txtBoxCode2.TabIndex = 17;
            txtBoxCode2.Text = "0";
            txtBoxCode2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxCode3
            // 
            txtBoxCode3.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCode3.ForeColor = SystemColors.ControlDarkDark;
            txtBoxCode3.Location = new Point(379, 228);
            txtBoxCode3.Name = "txtBoxCode3";
            txtBoxCode3.Size = new Size(27, 23);
            txtBoxCode3.TabIndex = 18;
            txtBoxCode3.Text = "0";
            txtBoxCode3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.DarkGreen;
            btnCompleteOrder.FlatStyle = FlatStyle.Flat;
            btnCompleteOrder.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleteOrder.ForeColor = Color.White;
            btnCompleteOrder.Location = new Point(359, 300);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(125, 26);
            btnCompleteOrder.TabIndex = 19;
            btnCompleteOrder.Text = "Complete Order";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 300);
            button2.Name = "button2";
            button2.Size = new Size(125, 26);
            button2.TabIndex = 20;
            button2.Text = "Return to Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 338);
            Controls.Add(button2);
            Controls.Add(btnCompleteOrder);
            Controls.Add(txtBoxCode3);
            Controls.Add(txtBoxCode2);
            Controls.Add(label4);
            Controls.Add(txtBoxCode1);
            Controls.Add(label5);
            Controls.Add(txtBoxCNum);
            Controls.Add(txtBoxYr);
            Controls.Add(label3);
            Controls.Add(txtBoxMonth);
            Controls.Add(label2);
            Controls.Add(txtBoxCName);
            Controls.Add(rdButtonCash);
            Controls.Add(pictureBox3);
            Controls.Add(rdButtonVisa);
            Controls.Add(pictureBox2);
            Controls.Add(rdButtonMasterCard);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private RadioButton rdButtonMasterCard;
        private RadioButton rdButtonVisa;
        private PictureBox pictureBox2;
        private RadioButton rdButtonCash;
        private PictureBox pictureBox3;
        private TextBox txtBoxCName;
        private Label label2;
        private Label label3;
        private TextBox txtBoxMonth;
        private TextBox txtBoxYr;
        private Label label4;
        private TextBox txtBoxCode1;
        private Label label5;
        private TextBox txtBoxCNum;
        private TextBox txtBoxCode2;
        private TextBox txtBoxCode3;
        private Button btnCompleteOrder;
        private Button button2;
    }
}