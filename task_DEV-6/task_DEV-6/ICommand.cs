using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    interface ICommand
    {
        void Execute(List<Product> list);
    }
}
