using UnityEngine;
using PSP.Actors;

namespace PSP.Interactables
{
    public class Tire : MonoBehaviour, IInteractable
    {
        private BoxCollider boxCollider;

        private void Awake() {
            boxCollider = GetComponent<BoxCollider>();
        }

        public void Interact(GameObject interactor) {
            transform.parent = interactor.transform;

            if (interactor.TryGetComponent(out Player player)) {
                boxCollider.enabled = false;
            } else {
                boxCollider.enabled = true;
            }
        }
    }
}
