using System;
using System.Collections.Generic;
using crueger.Models;

namespace crueger.Data
{
    public class MockCruegerRepository : ICruegerRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil and egg", Line = "Boil Water", Platform = "Kettle and pan"},
                new Command{Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "knife and chopping board"},
                new Command{Id = 2, HowTo = "Make cup of tea", Line = "Place tea bag in cup", Platform = "Kettle and cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Boil and egg", Line = "Boil Water", Platform = "Kettle and pan"};
        }
    }
}