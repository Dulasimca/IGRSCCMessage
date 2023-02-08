﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MessagesDAL
{
    [Table("casehearing")]
    public class Casehearing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int zoneid { get; set; }
        public int districtid { get; set; }
        public int sroid { get; set; }
        public int casetypeid { get; set; }
        public int courtcaseid { get; set; }
        public DateTime hearingdate { get; set; }
        public DateTime createddate { get; set; }
        public string remarks { get; set; }
        public bool flag { get; set; }
        public int userid { get; set; }


    }
}