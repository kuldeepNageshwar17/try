﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INCOMETAX.Models
{
    public class MessageModel
    {
        public string MessageText { get; set; }
        public List<UserModel> officers { get; set; }
    }
}