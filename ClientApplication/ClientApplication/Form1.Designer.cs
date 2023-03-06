namespace ClientApplication
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
            check_button = new Button();
            label1 = new Label();
            label2 = new Label();
            age_label = new Label();
            status_label = new Label();
            name_textBox = new TextBox();
            SuspendLayout();
            // 
            // check_button
            // 
            check_button.BackColor = SystemColors.ActiveCaptionText;
            check_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            check_button.ForeColor = SystemColors.ButtonHighlight;
            check_button.Location = new Point(293, 48);
            check_button.Name = "check_button";
            check_button.Size = new Size(141, 34);
            check_button.TabIndex = 0;
            check_button.Text = "CHECK";
            check_button.UseVisualStyleBackColor = false;
            check_button.Click += check_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 114);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 1;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(281, 114);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            age_label.Location = new Point(285, 162);
            age_label.Name = "age_label";
            age_label.Size = new Size(53, 17);
            age_label.TabIndex = 3;
            age_label.Text = "---------";
            // 
            // status_label
            // 
            status_label.AutoSize = true;
            status_label.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            status_label.Location = new Point(190, 162);
            status_label.Name = "status_label";
            status_label.Size = new Size(68, 17);
            status_label.TabIndex = 4;
            status_label.Text = "------------";
            // 
            // name_textBox
            // 
            name_textBox.BackColor = SystemColors.Window;
            name_textBox.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_textBox.ForeColor = Color.Silver;
            name_textBox.Location = new Point(70, 48);
            name_textBox.Multiline = true;
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(209, 34);
            name_textBox.TabIndex = 5;
            name_textBox.Text = "Enter your Name";
            name_textBox.Enter += name_textBox_Enter;
            name_textBox.Leave += name_textBox_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(540, 248);
            Controls.Add(name_textBox);
            Controls.Add(status_label);
            Controls.Add(age_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(check_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Client Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button check_button;
        private Label label1;
        private Label label2;
        private Label age_label;
        private Label status_label;
        private TextBox name_textBox;
    }
}