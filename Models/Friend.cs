﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvmEshkere.Models
{
    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }
    }
}
