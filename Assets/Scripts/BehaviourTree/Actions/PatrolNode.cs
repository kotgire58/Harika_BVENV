using UnityEngine;
using UnityEngine.AI;

namespace BehaviourTree
{
    public class PatrolNode : Node
    {
        private NavMeshAgent agent;
        private Transform[] waypoints;
        private int currentIndex = 0;

        public PatrolNode(NavMeshAgent agent, Transform[] waypoints)
        {
            this.agent = agent;
            this.waypoints = waypoints;
        }

        protected override State OnEvaluate()
        {
            if (waypoints.Length == 0)
                return State.Failure;

            if (agent.remainingDistance <= 0.2f)
            {
                currentIndex = (currentIndex + 1) % waypoints.Length;
                agent.SetDestination(waypoints[currentIndex].position);
            }

            return State.Running;
        }
    }
}
