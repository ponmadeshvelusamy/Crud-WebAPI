﻿using System;

namespace CrudWebApiClassLibrary
{
    public class SchoolEntity
    {
        public long SchoolID { get; set; }
        public string SchoolName { get; set; }
        public long ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long Pincode { get; set; }
    }
}
