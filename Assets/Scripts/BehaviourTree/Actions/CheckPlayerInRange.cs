using UnityEngine;

namespace BehaviourTree
{
    public class CheckPlayerInRange : Node
    {
        private Transform enemy;
        private Transform player;
        private float range;

        public CheckPlayerInRange(Transform enemy, Transform player, float range)
        {
            this.enemy = enemy;
            this.player = player;
            this.range = range;
        }

        protected override State OnEvaluate()
        {
            float distance = Vector3.Distance(enemy.position, player.position);

            if (distance <= range)
                return State.Success;

            return State.Failure;
        }
    }
}
