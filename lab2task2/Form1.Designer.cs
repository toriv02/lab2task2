namespace lab2task2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.anslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(12, 113);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(288, 23);
            this.inputtextBox.TabIndex = 0;
            this.inputtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputtextBox_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkButton.Location = new System.Drawing.Point(12, 142);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(288, 41);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "проверить";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ответ на задачу: ";
            // 
            // anslabel
            // 
            this.anslabel.Location = new System.Drawing.Point(15, 215);
            this.anslabel.Name = "anslabel";
            this.anslabel.Size = new System.Drawing.Size(285, 23);
            this.anslabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.anslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputtextBox);
            this.Name = "MainForm";
            this.Text = "Задача for";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputtextBox;
        private Label label1;
        private Button checkButton;
        public Label label2;
        private Label label3;
        private Label anslabel;
    }
}