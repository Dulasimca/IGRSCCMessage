using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MessagesDAL
{
    [Table("legalpanel_master")]
    public class LegalPanelMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int lawyerid { get; set; }
        public string lawyername { get; set; }
        public string phonenumber { get; set; }
        public string mailid { get; set; }
        public int courtid { get; set; }
        public DateTime createddate { get; set; }
        public bool flag { get; set; }
    }
}
