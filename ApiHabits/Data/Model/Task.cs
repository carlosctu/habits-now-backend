﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Task : BaseModel
    {
        public string calendar { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
