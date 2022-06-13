using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Controller.Factories.Interfaces
{
    public interface IBaseFactory<T>
    {
        public T Create();
    }
}
