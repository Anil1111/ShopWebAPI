﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopWebAPI.DAL.Domain
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
