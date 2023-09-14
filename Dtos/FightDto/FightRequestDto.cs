using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.FightDto
{
    public class FightRequestDto
    {
        public List<int> CharactersIds { get; set; } = new List<int>();
    }
}