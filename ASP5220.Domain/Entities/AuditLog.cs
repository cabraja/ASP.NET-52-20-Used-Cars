﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP5220.Domain.Entities
{
    public class AuditLog:Entity
    {
        public string UseCaseName { get; set; }
        public string Username { get; set; }
        public DateTime ExecutionTime { get; set; }
        public string Data { get; set; }
        public bool IsAuthorized { get; set; }

    }
}
