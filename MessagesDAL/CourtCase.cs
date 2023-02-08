using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MessagesDAL
{
    [Table("courtcase")]

    public class CourtCase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int courtcaseid { get; set; }
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
        public int casestatusid { get; set; }
        public int responsetypeid { get; set; }
        public DateTime createddate { get; set; }
        public bool flag { get; set; }
        public int userid { get; set; }
        public int counterfiledid { get; set; }
        public int mainrespondentsid { get; set; }
        public int mainprayerid { get; set; }
    }
}
