﻿using System.Web;
using System.Web.Mvc;

namespace Lab3_Montenegro_1229918
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
