using UnityEngine;

namespace _Course.AttackSystem
{
    public abstract class AEnemy : MonoBehaviour
    {
        [HideInInspector] public bool IsControlledByPlayer;
        public abstract void Attack();
    }
}