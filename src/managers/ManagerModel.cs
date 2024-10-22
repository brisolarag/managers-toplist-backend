using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace managers_back.src.managers
{
    public class ManagerModel
    {
        [Key]
        public uint Id { get; set; }
        public required string ManagerName { get; set; }
        public required string RoleName { get; set; }
        public List<string> Stacks { get; set; } = [];
        public required string Description { get; set; }

        public uint? Rank {get; set;}

    }
}