﻿using LuzzedroCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuzzedroCMS.Models
{
    public class ArticlesCategoryViewModel : ArticlesViewModel
    {
        public string CategoryName { get; set; }
        public string CategoryNameEscaped
        {
            get
            {
                return CategoryName.Replace(" ", "-");
            }
        }
    }
}