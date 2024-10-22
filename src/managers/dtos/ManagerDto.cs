using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace managers_back.src.managers.dtos
{
    public class ManagerDto
    {
        public required string ManagerName { get; set; }
        public required string RoleName { get; set; }
        public required List<string> Stacks { get; set; }
        public required string Description { get; set; }


        public static ManagerDto ParseToDto(ManagerModel model) {
            return new ManagerDto() {
                ManagerName = model.ManagerName,
                RoleName = model.RoleName,
                Stacks = model.Stacks,
                Description = model.Description
            };
        }
    }
}