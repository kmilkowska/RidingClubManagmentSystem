﻿using System.Collections.Generic;

namespace RidingClubMS.ViewModels
{
    public class BaseUserVm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

    }
}
