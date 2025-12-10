using System.Collections.Generic;

namespace BehaviourTree
{
    public abstract class Composite : Node
    {
        protected List<Node> children;

        public Composite(List<Node> children)
        {
            this.children = children;
        }
    }
}
