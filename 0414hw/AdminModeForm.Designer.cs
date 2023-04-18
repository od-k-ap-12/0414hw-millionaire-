namespace _0414hw
{
    partial class AdminModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxRightAnswer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Items.AddRange(new object[] {
            "Вопрос 1",
            "Вопрос 2",
            "Вопрос 3",
            "Вопрос 4",
            "Вопрос 5",
            "Вопрос 6",
            "Вопрос 7",
            "Вопрос 8",
            "Вопрос 9",
            "Вопрос 10",
            "Вопрос 11",
            "Вопрос 12",
            "Вопрос 13",
            "Вопрос 14",
            "Вопрос 15"});
            this.comboBoxQuestions.Location = new System.Drawing.Point(12, 26);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuestions.TabIndex = 0;
            this.comboBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestions_SelectedIndexChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(182, 26);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(563, 47);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Location = new System.Drawing.Point(182, 101);
            this.textBoxAnswer1.Multiline = true;
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(264, 35);
            this.textBoxAnswer1.TabIndex = 2;
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Location = new System.Drawing.Point(182, 157);
            this.textBoxAnswer3.Multiline = true;
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(264, 35);
            this.textBoxAnswer3.TabIndex = 3;
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Location = new System.Drawing.Point(489, 157);
            this.textBoxAnswer4.Multiline = true;
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(256, 35);
            this.textBoxAnswer4.TabIndex = 5;
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Location = new System.Drawing.Point(489, 101);
            this.textBoxAnswer2.Multiline = true;
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(256, 35);
            this.textBoxAnswer2.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(12, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 34);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxRightAnswer
            // 
            this.comboBoxRightAnswer.FormattingEnabled = true;
            this.comboBoxRightAnswer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxRightAnswer.Location = new System.Drawing.Point(182, 213);
            this.comboBoxRightAnswer.Name = "comboBoxRightAnswer";
            this.comboBoxRightAnswer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRightAnswer.TabIndex = 7;
            // 
            // AdminModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 279);
            this.Controls.Add(this.comboBoxRightAnswer);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAnswer4);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.comboBoxQuestions);
            this.Name = "AdminModeForm";
            this.Text = "AdminModeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.TextBox textBoxAnswer4;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxRightAnswer;
    }
}