using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0414hw
{
    public partial class AdminModeForm : Form
    {
        public List<QuestionWithAnswers> Quiz = new List<QuestionWithAnswers>();
        public AdminModeForm()
        {
            InitializeComponent();
        }

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAnswer1.Text = Quiz[comboBoxQuestions.SelectedIndex].Answer1;
            textBoxAnswer2.Text = Quiz[comboBoxQuestions.SelectedIndex].Answer2;
            textBoxAnswer3.Text = Quiz[comboBoxQuestions.SelectedIndex].Answer3;
            textBoxAnswer4.Text = Quiz[comboBoxQuestions.SelectedIndex].Answer4;
            textBoxQuestion.Text = Quiz[comboBoxQuestions.SelectedIndex].Question;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Quiz[comboBoxQuestions.SelectedIndex].Answer1 = textBoxAnswer1.Text;
            Quiz[comboBoxQuestions.SelectedIndex].Answer2 = textBoxAnswer2.Text;
            Quiz[comboBoxQuestions.SelectedIndex].Answer3 = textBoxAnswer3.Text;
            Quiz[comboBoxQuestions.SelectedIndex].Answer4=textBoxAnswer4.Text;
            Quiz[comboBoxQuestions.SelectedIndex].Question=textBoxQuestion.Text;
        }
    }
}
