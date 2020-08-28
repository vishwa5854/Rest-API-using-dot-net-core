using System.Collections.Generic;
using crueger.Models;

namespace crueger.Data
{
    public interface ICruegerRepository
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}