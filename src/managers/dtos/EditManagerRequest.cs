using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace managers_back.src.managers.dtos
{
    public class EditManagerRequest
    {
        public string? ManagerName { get; set; }
        public string? TeamName { get; set; }
        public string? Description { get; set; }
    }
}