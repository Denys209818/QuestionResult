using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionResult.DAL.ContextFiles
{
    [Table("tblQuestions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Text { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
