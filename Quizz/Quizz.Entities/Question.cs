using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizz.Entities
{
    public class Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int exam_id { get; set; }

        [StringLength(50)]
        public string question_name { get; set; }


        public Exam Exam { get; set; }
    }
}
