using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizz.Entities
{
    public class Answer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int question_id { get; set; }

        [StringLength(50)]
        public string answer_name { get; set; }

        [StringLength(2)]
        public string answer_title { get; set; }

    }
}
