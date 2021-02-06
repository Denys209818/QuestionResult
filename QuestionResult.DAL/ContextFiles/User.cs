using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionResult.DAL.ContextFiles
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string FirstName { get; set; }
        [Required, StringLength(255)]
        public string LastName { get; set; }
        [Required, StringLength(255)]
        public string Login { get; set; }
        [Required, StringLength(255)]
        public string Password { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
