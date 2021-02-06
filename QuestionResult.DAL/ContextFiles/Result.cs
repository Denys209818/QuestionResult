using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionResult.DAL.ContextFiles
{
    [Table("tblResults")]
    public class Result
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Answer.Id")]
        public int AnswerId { get; set; }
        [ForeignKey("Session.Id")]
        public int SessionId { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual Session Session { get; set; }
    }
}
