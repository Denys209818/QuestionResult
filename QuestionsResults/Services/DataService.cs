using Microsoft.EntityFrameworkCore;
using QuestionResult.DAL.ContextFiles;
using QuestionsResults.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionsResults.Services
{
    public static class DataService
    {
        /// <summary>
        ///     Метод, який повертає усі сесії
        /// </summary>
        /// <param name="context">Властивість для зв'язку з БД</param>
        /// <param name="SortByDate">Вказує чи потрібно робити сортування за датою</param>
        /// <param name="SortByMark">Вказує чи порібно робити сортування за оцінкою</param>
        /// <returns>Повертає List<SessionElement>, який дозволяє потім заповнювати MainForm</returns>
        public static List<SessionElement> GetSessions(MyContext context, 
            bool SortByDate = false, 
            bool SortByMark = false) 
        {
            var elmts = context.Sessions
            .Select(x => new Session
            {
                Id = x.Id,
                User = x.User,
                Begin = x.Begin,
                End = x.End,
                Marks = x.Marks
            }).AsQueryable();

            if (SortByDate) 
            {
                elmts = elmts.OrderBy(x => x.Begin).AsQueryable();
            }

            if (SortByMark) 
            {
                elmts = elmts.OrderBy(x => x.Marks).Reverse();
            }

            List<SessionElement> elements  = elmts
            .Select(x => new SessionElement {
            Id = x.Id,
            FullName = x.User.LastName + " " + x.User.FirstName,
            Begin = x.Begin.TimeOfDay.Hours + " : " + x.Begin.TimeOfDay.Minutes + " : "
                + x.Begin.TimeOfDay.Seconds,
            End = x.End.TimeOfDay.Hours + " : " + x.End.TimeOfDay.Minutes + " : "
                + x.End.TimeOfDay.Seconds,
            Mark = x.Marks,
            Date = x.Begin.Date.ToString()
            }).ToList();


            return elements;
        }
    }
}
