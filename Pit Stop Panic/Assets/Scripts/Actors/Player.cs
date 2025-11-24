using UnityEngine;

namespace PSP.Actors
{
    public class Player : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float moveSpeed = 7f;
        [SerializeField] private float rotateSpeed = 10f;

        [Header("Settings")]
        [SerializeField] private InputReader inputReader;

        [Header("Collisions")]
        [SerializeField] private float playerHeight = 1.8f;
        [SerializeField] private float playerRadius = 0.1f;
        [SerializeField] private float raycastHeight = 0.5f;
        [SerializeField] private bool showRaycast = false;
        [SerializeField] private Color raycastColor = Color.red;

        private Vector3 moveDirection;
        private bool isWalking;

        private void OnEnable() {
            inputReader.moveEvent += OnMove;
        }

        private void OnDisable() {
            inputReader.moveEvent -= OnMove;
        }

        private void Update() {
            Move();
        }

        private void Move() {
            Vector3 p1 = transform.position + Vector3.up * raycastHeight;
            Vector3 p2 = transform.position + Vector3.up * (playerHeight - raycastHeight);
            float moveDistance = moveSpeed * Time.deltaTime;
            bool canMove = !Physics.CapsuleCast(p1, p2, playerRadius, moveDirection, moveDistance);

            if (!canMove) {
                // Try X only
                Vector3 moveDirX = new Vector3(moveDirection.x, 0f, 0f).normalized;
                canMove = !Physics.CapsuleCast(p1, p2, playerRadius, moveDirX, moveDistance);

                if (canMove) {
                    moveDirection = moveDirX;
                } else {
                    // Try Z only
                    Vector3 moveDirZ = new Vector3(0f, 0f, moveDirection.z).normalized;
                    canMove = !Physics.CapsuleCast(p1, p2, playerRadius, moveDirZ, moveDistance);

                    if (canMove) {
                        moveDirection = moveDirZ;
                    }
                }
            }

            if (canMove) {
                transform.position += moveDirection * moveDistance;
            }
            
            isWalking = moveDirection != Vector3.zero;
            transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotateSpeed * Time.deltaTime);

        }

        // ----- EVENT LISTENERS -----
        private void OnMove(Vector2 movement) {
            Vector2 inputVector = movement.normalized;
            moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);
        }

        private void OnDrawGizmos()
        {
            if (showRaycast) {
                Debug.DrawRay(transform.position + Vector3.up * raycastHeight, moveDirection, raycastColor);
            }
        }

        // ----- PROPERTIES -----
        public bool IsWalking => isWalking;
    }
}
