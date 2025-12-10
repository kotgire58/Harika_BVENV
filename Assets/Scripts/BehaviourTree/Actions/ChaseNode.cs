using UnityEngine;
using UnityEngine.AI;

namespace BehaviourTree
{
    public class ChaseNode : Node
    {
        private NavMeshAgent agent;
        private Transform target;
        private float chaseRange;

        public ChaseNode(NavMeshAgent agent, Transform target, float chaseRange)
        {
            this.agent = agent;
            this.target = target;
            this.chaseRange = chaseRange;
        }

        protected override State OnEvaluate()
        {
            float dist = Vector3.Distance(agent.transform.position, target.position);

            if (dist > chaseRange)
                return State.Failure;

            agent.SetDestination(target.position);
            return State.Running;
        }
    }
}
