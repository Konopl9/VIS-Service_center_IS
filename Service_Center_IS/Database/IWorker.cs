using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Center_IS.Database
{
    interface IWorker : IEmployee<Worker>
    {
        Collection<Worker> GetWorkerOfTheMonth();

        Collection<Worker> SelectWorkerByLogin(string login);
    }
}
