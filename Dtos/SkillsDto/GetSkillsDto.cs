using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.SkillsDto
{
    public class GetSkillsDto
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
    }
}