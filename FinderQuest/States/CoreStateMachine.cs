using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.States
{
    public interface CoreStateMachine<T>
    {
        void Enter(T entity);
        void Update(T entity);
        void Exit(T entity);
    }
}
