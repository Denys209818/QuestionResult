using QuestionResult.DAL.ContextFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionsResults
{
    public partial class ResultForm : Form
    {
        private int StartPos { get; set; } = 45;
        private int Dy { get; set; } = 80; 
        private List<Result> _results { get; set; }
        public ResultForm(List<Result> results)
        {
            InitializeComponent();
            this._results = results;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            foreach (var item in this._results) 
            {
                CreateGroupBox(item);
            }
        }
        /// <summary>
        ///     Метод, який створює GroupBox і заповнює його данними
        /// </summary>
        /// <param name="result">Приймає результат, у якого вибирає дані</param>
        private void CreateGroupBox(Result result) 
        {
            Label lblAnswer = new Label();
            GroupBox gbQuestions = new GroupBox();
            // 
            // gbQuestions
            // 
            gbQuestions.Controls.Add(lblAnswer);
            gbQuestions.Location = new System.Drawing.Point(187, StartPos);
            gbQuestions.Name = "gbQuestions";
            gbQuestions.Size = new System.Drawing.Size(545, 74);
            gbQuestions.TabIndex = 0;
            gbQuestions.TabStop = false;
            gbQuestions.Text = result.Answer.Question.Text;
            gbQuestions.ForeColor = Color.Black;
            gbQuestions.Font = new Font("Comic Sans MS", 10);
            // 
            // lblAnswer
            // 
            lblAnswer.Location = new System.Drawing.Point(7, 27);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new System.Drawing.Size(532, 33);
            lblAnswer.TabIndex = 0;
            lblAnswer.Text = result.Answer.Text;
            lblAnswer.Font = new Font("Times New Roman", 12);
            lblAnswer.BackColor = result.Answer.IsTrue ?
                Color.FromArgb(100, Color.LimeGreen) :
                Color.FromArgb(100, Color.Red);
            lblAnswer.ForeColor = Color.Black;

            this.Controls.Add(gbQuestions);
            StartPos += Dy;
        }
        /// <summary>
        ///     Закриває вікно!
        /// </summary>
        /// <param name="sender">Кнопка яка генерує подію</param>
        /// <param name="e">Параметри кліка</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
