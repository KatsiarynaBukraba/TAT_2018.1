using System;
using System.Collections.Generic;

namespace task_DEV_8.Commands
{
    class InvokerCommand
    {
        ICommand command;

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ExecuteCommand(List<User> list)
        {
            command.Execute(list);
        }
    }
}
