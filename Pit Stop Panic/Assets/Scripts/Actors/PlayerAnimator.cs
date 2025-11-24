using UnityEngine;

namespace PSP.Actors
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Player player;

        public const string IS_WALKING = "isWalking";

        private Animator animator;

        private void Awake() {
            animator = GetComponent<Animator>();
        }

        private void Update() {
            animator.SetBool(IS_WALKING, player.IsWalking);
        }
    }
}
