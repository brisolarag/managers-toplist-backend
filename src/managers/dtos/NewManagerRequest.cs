using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace managers_back.src.managers.dtos
{
    public class NewManagerRequest
    {
        public required string ManagerName { get; set; }
        public required string RoleName { get; set; }
        public List<string> Stacks { get; set; } = [];
        public required string Description { get; set; }

        public ManagerModel Parse() {
            return new ManagerModel() {
                ManagerName = this.ManagerName,
                RoleName = this.RoleName,
                Stacks = this.Stacks,
                Description = this.Description
            };
        }
    }
}