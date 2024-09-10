﻿using Services.SkillType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IContactPostService
    {
        Task<string> Add(string fullName, string email, string subject, string content);
    }
}
