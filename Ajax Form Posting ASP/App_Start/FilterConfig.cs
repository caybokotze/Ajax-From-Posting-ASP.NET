﻿using System.Web;
using System.Web.Mvc;

namespace Ajax_Form_Posting_ASP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
