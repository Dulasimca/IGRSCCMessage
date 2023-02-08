using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MessagesDAL
{
    [Table("legalopinion")]
    public class LegalOpinion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int opinionid { get; set; }
        public int zoneid { get; set; }
        public int districtid { get; set; }
        public int sroid { get; set; }
        public int casetypeid { get; set; }
        public string casenumber { get; set; }
        public int caseyear { get; set; }
        public int courtid { get; set; }
        public string petitionername { get; set; }
        public string mainrespondents { get; set; }
        public string mainprayer { get; set; }
        public string opinionsoughtgist { get; set; }
        public string opinionreceivedgist { get; set; }
        public int lawyerid { get; set; }
        public string reason { get; set; }
        public string remarks { get; set; }
        public DateTime createddate { get; set; }
        public int userid { get; set; }
        public int courtcaseid { get; set; }
        public bool opinionstatus { get; set; }
        public bool flag { get; set; }
    }
}
