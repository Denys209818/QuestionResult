using Microsoft.EntityFrameworkCore;
using QuestionResult.DAL.ContextFiles;
using QuestionsResults.Models;
using QuestionsResults.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestionsResults
{
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Властивість для роботи з БД
        /// </summary>
        public static MyContext _context { get; set; } = new MyContext();
        /// <summary>
        ///     Стартова позиція елемента
        /// </summary>
        private int StartPos = 50;
        /// <summary>
        ///     Властивість, що вказує на скільки потрібно зміщувати елемент по осі y
        /// </summary>
        private int Dy = 230;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        ///     Метод, який вимикає програму
        /// </summary>
        /// <param name="sender">Об'єкт, який згенерував подію</param>
        /// <param name="e">Параметри події</param>
        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
           
        }
        /// <summary>
        ///     Метод, який викликається коли програма закривається
        /// </summary>
        /// <param name="sender">Об'єкт, який згенерував подію</param>
        /// <param name="e">Параметри події</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти?", "Програма",
                buttons: MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var item in DataService.GetSessions(_context)) 
            {
                GenerateGroupBox(item);
            }
        }
        /// <summary>
        ///     Очищає із елементів Controls усі GroupBox
        /// </summary>
        private void ClearGroupBox() 
        {
            this.StartPos = 50;
            this.Dy = 230;
            var coll = this.Controls.OfType<GroupBox>();
            foreach (var item in coll.Reverse()) 
            {
                this.Controls.Remove(item);
            }
        } 
        /// <summary>
        ///     Формує елемент GroupBox, заповнюючи його даними з класа моделі сесії
        /// </summary>
        /// <param name="session">Приймає модель SessionElement</param>
        private void GenerateGroupBox(SessionElement session) 
        {
            GroupBox groupBoxInfo = new GroupBox();
            Label lblMark = new Label();
            Label lblEnd = new Label();
            Label lblBegin = new Label();
            Label lblUser = new Label();
            Label lblDate = new Label();
            Button btnInfo = new Button();

            //
            // btnInfo  
            //
            btnInfo.Name = $"btnInfo{session.Id}";
            btnInfo.Text = $"Показати деталі";
            btnInfo.Size = new Size(150, 50);
            btnInfo.Location = new Point(5, 155);
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Click += new EventHandler(btnInfo_Click);
            btnInfo.Tag = session.Id;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblMark);
            groupBoxInfo.Controls.Add(lblEnd);
            groupBoxInfo.Controls.Add(lblBegin);
            groupBoxInfo.Controls.Add(lblUser);
            groupBoxInfo.Controls.Add(lblDate);
            groupBoxInfo.Controls.Add(btnInfo);
            groupBoxInfo.Location = new System.Drawing.Point(201, StartPos);
            groupBoxInfo.Name = $"groupBoxInfo{session.Id}";
            groupBoxInfo.Size = new System.Drawing.Size(498, 212);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.BackColor = Color.LightSlateGray;
            // 
            // lblUser
            // 
            lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUser.Location = new System.Drawing.Point(160, 27);
            lblUser.Name = $"lblUser{session.Id}";
            lblUser.Size = new System.Drawing.Size(205, 25);
            lblUser.TabIndex = 0;
            lblUser.ForeColor = Color.Red;
            lblUser.Text = session.FullName;
            // 
            // lblBegin
            // 
            lblBegin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBegin.Location = new System.Drawing.Point(6, 77);
            lblBegin.Name = $"lblBegin{session.Id}";
            lblBegin.Size = new System.Drawing.Size(205, 25);
            lblBegin.TabIndex = 0;
            lblBegin.ForeColor = Color.LightBlue;
            lblBegin.Text = $"Початок: " + session.Begin;
            // 
            // lblEnd
            // 
            lblEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEnd.Location = new System.Drawing.Point(287, 77);
            lblEnd.Name = $"lblEnd{session.Id}";
            lblEnd.Size = new System.Drawing.Size(205, 25);
            lblEnd.TabIndex = 0;
            lblEnd.ForeColor = Color.LightBlue;
            lblEnd.Text = $"Кінець:" + session.End;
            // 
            // lblMark
            // 
            lblMark.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMark.Location = new System.Drawing.Point(6, 120);
            lblMark.Name = $"lblMark{session.Id}";
            lblMark.Size = new System.Drawing.Size(205, 25);
            lblMark.TabIndex = 0;
            lblMark.ForeColor = Color.LightBlue;
            lblMark.Text = "Оцінка: " + session.Mark.ToString();
            // 
            // lblDate
            // 
            lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDate.Location = new System.Drawing.Point(287, 120);
            lblDate.Name = $"lblDate{session.Id}";
            lblDate.Size = new System.Drawing.Size(205, 25);
            lblDate.TabIndex = 0;
            lblDate.ForeColor = Color.LightBlue;
            lblDate.Text = "Дата: " + session.Date;

            this.Controls.Add(groupBoxInfo);
            StartPos += Dy;
        }
        /// <summary>
        ///     Метод, що сортує дані по даті
        /// </summary>
        /// <param name="sender">Об'єкт, який згенерував подію</param>
        /// <param name="e">Параметри події</param>
        private void dateStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGroupBox();

            foreach (var item in DataService.GetSessions(_context, SortByDate: true))
            {
                GenerateGroupBox(item);
            }
        }
        /// <summary>
        ///     Метод, що сортує дані за результатами
        /// </summary>
        /// <param name="sender">Об'єкт, який згенерував подію</param>
        /// <param name="e">Параметри події</param>
        private void succStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGroupBox();

            foreach (var item in DataService.GetSessions(_context, SortByMark: true))
            {
                GenerateGroupBox(item);
            }
        }
        /// <summary>
        ///     Метод, що викликає вікно на якому можна побачити детальну інформацію
        ///     В методі реалізовано формування колекції результатів певної сесії
        /// </summary>
        /// <param name="sender">Кнопка, яка згенерувала подію</param>
        /// <param name="e">Параметри кліка</param>
        private void btnInfo_Click(object sender, EventArgs e) 
        {
            int Id = (int)(sender as Button).Tag;
            var list = _context.Sessions
                .Where(x => x.Id == Id)
                .SelectMany(x => x.Results
                .Select(y => new Result { 
                Id = y.Id,
                Answer = new Answer 
                    {
                        Id = y.Answer.Id,
                        Text = y.Answer.Text,
                        IsTrue = y.Answer.IsTrue,
                        Question = y.Answer.Question,
                        QuestionId = y.Answer.QuestionId
                    },
                AnswerId = y.AnswerId,
                Session = new Session 
                    {
                        Id = y.Session.Id,
                        Begin = y.Session.Begin,
                        End = y.Session.End,
                        Marks = y.Session.Marks,
                        UserId = y.Session.UserId
                    }, 
                SessionId = y.SessionId
                })).ToList();

            ResultForm form = new ResultForm(list);
            this.Visible = false;  
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
