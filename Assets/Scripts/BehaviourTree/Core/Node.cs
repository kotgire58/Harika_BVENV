using System.Collections.Generic;

namespace BehaviourTree
{
    public enum State
    {
        Running,
        Success,
        Failure
    }

    public abstract class Node
    {
        protected State _state;

        public State Evaluate()
        {
            return OnEvaluate();
        }

        protected abstract State OnEvaluate();
    }
}
