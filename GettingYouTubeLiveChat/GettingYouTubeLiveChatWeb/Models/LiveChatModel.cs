﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#region MITLicense
/*
Copyright 2020 naonao0001777

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITH
*/
#endregion
namespace WebApplication1.Models
{
    public class LiveChatModel
    {
        public string DspMessage { get; set; }

        public string DspName{get;set;}

        public string User { get; set; }

    }
}