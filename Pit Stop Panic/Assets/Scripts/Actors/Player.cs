using System.ComponentModel;
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

        private Vector3 moveDirection;

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
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotateSpeed * Time.deltaTime);
        }

        // ----- EVENT LISTENERS -----
        private void OnMove(Vector2 movement) {
            Debug.Log(movement);
            Vector2 inputVector = movement.normalized;
            moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);
        }
    }
}
