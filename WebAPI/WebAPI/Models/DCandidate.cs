﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nnvarchar (100)")]
        public string fullname { get; set; }
        
        [Column(TypeName = "nnvarchar (16)")]
        public string mobile { get; set; }

        [Column(TypeName = "nnvarchar (100)")]
        public string email { get; set; }
        public int age { get; set; }

        [Column(TypeName = "nnvarchar (3)")]
        public string bloodGroup { get; set; }

        [Column(TypeName = "nnvarchar (100)")]
        public string address { get; set; }
    }
}
