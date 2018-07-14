using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PFinal.Models
{
    public class Musical
    {
        public Musical()
        {
            List_Cast = new HashSet<CastMusical>();
            List_Soundtrack = new HashSet<Soundtrack>();
            ListReviews = new HashSet<Reviews>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Musical { get; set; }

        [Required(ErrorMessage = " {0} required field!")]
        public string Title { get; set; }

        [Required(ErrorMessage = " {0} required field!")]
        public string Synopsis { get; set; }

        [Required(ErrorMessage = " {0} required field!")]
        public string Director { get; set; }

        [Required(ErrorMessage = " {0} required field!")]
        public string Duration { get; set; }

        [Required, Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime OpeningNight { get; set; }

        public string Ticket { get; set; }

        [Required(ErrorMessage = " {0} required field!")]
        public string Poster { get; set; }

        // referência aos atores que um musical apresenta
        public virtual ICollection<CastMusical> List_Cast { get; set; }
        // referência à banda sonora que um musical apresenta
        public virtual ICollection<Soundtrack> List_Soundtrack { get; set; }
        // referência às reviews que um musical apresenta
        public virtual ICollection<Reviews> ListReviews { get; set; }

    }
}