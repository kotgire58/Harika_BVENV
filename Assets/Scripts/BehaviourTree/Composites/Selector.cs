using System.Collections.Generic;

namespace BehaviourTree
{
    public class Selector : Composite
    {
        public Selector(List<Node> children) : base(children) {}

        protected override State OnEvaluate()
        {
            foreach (Node node in children)
            {
                State result = node.Evaluate();
                if (result == State.Success || result == State.Running)
                    return result;
            }

            return State.Failure;
        }
    }
}
