using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _0414hw
{
    public partial class GameForm : Form
    {
        Random r = new Random();
        int CurrentQuestion = 1;
        int MaxQuestions = 15;
        public List<QuestionWithAnswers> Quiz = new List<QuestionWithAnswers>
        {
            new QuestionWithAnswers("Как называется место на берегу, где обитают тюлени?","Лежбище","Стойбище","Пастбище","Гульбище",3),
            new QuestionWithAnswers("Как мировая пресса называла премьер-министра Великобритании Маргарет Тэтчер?","Железная леди","Стальная леди","Оловянный солдатик","Крепкий орешек",3),
            new QuestionWithAnswers("Какой из этих городов южнее остальных?","Каир","Токио","Мадрид","Сан-Франциско",3),
            new QuestionWithAnswers("Через какой город мира проходит нулевой меридиан?","Гринвич","Гринсборо","Глазго","Гронинген",3),
            new QuestionWithAnswers("Какая птица является символом Новой Зеландии?","Киви","Жако","Эму","Казуар",3),
            new QuestionWithAnswers("Какого короля англичане прозвали Львиное сердце?","Ричард I","Вильгельм I","Георг I","Генрих I",3),
            new QuestionWithAnswers("Как в народе называются финансовые институты, обещающие вкладчикам золотые горы?","Пирамиды","Гробницы","Захоронения","Сфинксы",3),
            new QuestionWithAnswers("Какая награда вручается вместе с присвоением звания Героя России?","Медаль Золотая Звезда","Медаль За отвагу","Орден Суворова","Орден мужества",3),
            new QuestionWithAnswers("В каком городе родился Вольфганг Амадей Моцарт?","Зальцбург","Веймар","Прага","Вена",3),
            new QuestionWithAnswers("Какую реку Юлий Цезарь перешел со словами Жребий брошен?","Рубикон","Припять","Нил","Евфрат",3),
            new QuestionWithAnswers("Как называется искусство аранжировки цветов?","Икебана","Суши","Кэндо","Харакири",3),
            new QuestionWithAnswers("Какая страна является мировым лидером по производству кофе?","Бразилия","Венесуэла","Мексика","Аргентина",3),
            new QuestionWithAnswers("Что труднее всего дается не трезвому человеку?","Вязать лыко","Трепать нервы","Бить баклуши","Витать в облаках",3),
            new QuestionWithAnswers("Как называют японских мафиози?","Якудза","Джакузи","Камикадзе","Коза Ностра",3),
            new QuestionWithAnswers("Как называется место на берегу, где обитают тюлени?","Лежбище","Стойбище","Пастбище","Гульбище",3)
        };
        public GameForm()
        {
            InitializeComponent();
        }



        private void button5050_Click(object sender, EventArgs e)
        {
            textBox5050.Visible = true;
            int RandomAnswer;
            while(true)
            {
                RandomAnswer = r.Next(1, 4);
                if(RandomAnswer!= Quiz[CurrentQuestion].RightAnswer)
                {
                    break;
                }
            }
            textBox5050.Text = Convert.ToString(Quiz[CurrentQuestion].RightAnswer) + " или " + Convert.ToString(RandomAnswer);
        }

        private void buttonFriendCall_Click(object sender, EventArgs e)
        {
            textBoxFriendCall.Visible = true;
            textBoxFriendCall.Text = "Я думаю, что ответ " + r.Next(1, 4);
        }

        private void buttonAudienceHelp_Click(object sender, EventArgs e)
        {
            groupBoxAudienceHelp.Visible = true;
            progressBar1.Value = r.Next(1, 30);
            progressBar2.Value = r.Next(1, 30);
            progressBar3.Value = r.Next(1, 30);
            progressBar4.Value = 100-progressBar1.Value-progressBar2.Value-progressBar3.Value-progressBar4.Value;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentQuestion = 1;
            QuestionCall();
        }

        private void AdminModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminModeForm Admin=new AdminModeForm();
            Admin.Quiz = Quiz;
            DialogResult dr=Admin.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Quiz=Admin.Quiz;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кто хочет стать миллионером, 2023");
        }
        private void QuestionCall()
        {
            buttonAnswer1.Text = Quiz[CurrentQuestion].Answer1;
            buttonAnswer2.Text = Quiz[CurrentQuestion].Answer2;
            buttonAnswer3.Text = Quiz[CurrentQuestion].Answer3;
            buttonAnswer4.Text = Quiz[CurrentQuestion].Answer4;
            label1.Text = Quiz[CurrentQuestion].Question;
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            if (Quiz[CurrentQuestion].RightAnswer == 1)
            {
                if (CurrentQuestion + 1 == 16)
                {
                    MessageBox.Show("Вы выиграли");
                }
                else
                {
                    CurrentQuestion++;
                    QuestionCall();
                }

            }
            else
            {
                if (CurrentQuestion >5&&CurrentQuestion<10)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
                else if (CurrentQuestion > 10&&CurrentQuestion<15)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
            }
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            if (Quiz[CurrentQuestion].RightAnswer == 2)
            {
                if (CurrentQuestion + 1 == 16)
                {
                    MessageBox.Show("Вы выиграли");
                }
                else
                {
                    CurrentQuestion++;
                    QuestionCall();
                }

            }
            else
            {
                if (CurrentQuestion > 5 && CurrentQuestion < 10)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
                else if (CurrentQuestion > 10 && CurrentQuestion < 15)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
            }
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            if (Quiz[CurrentQuestion].RightAnswer == 4)
            {
                if (CurrentQuestion + 1 == 16)
                {
                    MessageBox.Show("Вы выиграли");
                }
                else
                {
                    CurrentQuestion++;
                    QuestionCall();
                }

            }
            else
            {
                if (CurrentQuestion > 5 && CurrentQuestion < 10)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
                else if (CurrentQuestion > 10 && CurrentQuestion < 15)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
            }
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            if (Quiz[CurrentQuestion].RightAnswer == 4)
            {
                if (CurrentQuestion + 1 == 16)
                {
                    MessageBox.Show("Вы выиграли");
                }
                else
                {
                    CurrentQuestion++;
                    QuestionCall();
                }

            }
            else
            {
                if (CurrentQuestion > 5 && CurrentQuestion < 10)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
                else if (CurrentQuestion > 10 && CurrentQuestion < 15)
                {
                    MessageBox.Show("Вы забираете 1 000");
                }
            }
        }


    }
}
