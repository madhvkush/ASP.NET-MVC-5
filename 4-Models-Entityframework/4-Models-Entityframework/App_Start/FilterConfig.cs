﻿using System.Web;
using System.Web.Mvc;

namespace _4_Models_Entityframework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}