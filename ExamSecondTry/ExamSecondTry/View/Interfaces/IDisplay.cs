using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.View.Interfaces
{
    public interface IDisplay<T> where T : class
    {
        public void DisplaySingle(T entity);
        public void DisplayList(List<T> entities);
    }
}
}
