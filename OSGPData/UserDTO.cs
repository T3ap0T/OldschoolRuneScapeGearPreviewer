﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSGPData
{
    class UserDTO
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Admin { get; set; } = false;
    }
}
