﻿using System.Web;
using System.Web.Mvc;

namespace Assign2_n01472554
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
