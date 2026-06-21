using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.States
{
    public class StateMachine<T>
    {
        private readonly T _owner;
        private CoreStateMachine<T> currentState;

        public CoreStateMachine<T> CurrentState { get => currentState; private set => currentState = value; }

        public StateMachine(T owner)
        {
            _owner = owner;
        }

        public void Initialize(CoreStateMachine<T> initialState)
        {
            this.CurrentState = initialState;
            this.CurrentState.Enter(_owner);
        }

        public void TransitionTo(CoreStateMachine<T> newState)
        {
            this.CurrentState?.Exit(_owner);
            this.CurrentState = newState;
            this.CurrentState.Enter(_owner);
        }

        public void Update()
        {
            this.CurrentState?.Update(_owner);
        }
    }
}
