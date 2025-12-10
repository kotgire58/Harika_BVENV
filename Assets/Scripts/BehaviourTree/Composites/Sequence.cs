using System.Collections.Generic;

namespace BehaviourTree
{
    public class Sequence : Composite
    {
        public Sequence(List<Node> children) : base(children) {}

        protected override State OnEvaluate()
        {
            bool anyRunning = false;

            foreach (Node node in children)
            {
                State result = node.Evaluate();

                if (result == State.Failure)
                    return State.Failure;

                if (result == State.Running)
                    anyRunning = true;
            }

            return anyRunning ? State.Running : State.Success;
        }
    }
}
