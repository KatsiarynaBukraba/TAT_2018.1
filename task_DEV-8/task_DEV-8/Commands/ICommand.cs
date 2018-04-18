using System;
using System.Collections.Generic;

namespace task_DEV_8.Commands
{
    interface ICommand
    {
        void Execute(List<User> list);
    }
}
