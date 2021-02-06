using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionResult.DAL.ContextFiles
{
    [Table("tblSessions")]
    public class Session
    {
        [Key]
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public int Marks { get; set; }
        [ForeignKey("User.Id")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
