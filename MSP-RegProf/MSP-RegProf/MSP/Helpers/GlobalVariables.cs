﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSP_RegProf.Helpers
{
    public class GlobalVariables
    {
        // readonly variable
        public static string BASE_URL
        {
            get
            {
                return "http://localhost:1338/api/";
            }
        }
        
    }
}