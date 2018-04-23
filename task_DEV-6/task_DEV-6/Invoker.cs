using System;
using System.Collections.Generic;


namespace task_DEV_6
{
    class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ExecuteCommand(List<Product> list)
        {
            command.Execute(list);
        }
    }
}
