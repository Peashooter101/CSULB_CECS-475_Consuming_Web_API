﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingWebAPI
{
    public class HolidayModel
    {
        public string Name { get; set; }
        public string LocalName { get; set; }
        public DateTime? Date { get; set; }
        public string CountryCode { get; set; }
        public bool Global { get; set; }

    }
}
