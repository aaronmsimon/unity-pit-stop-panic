using UnityEngine;

namespace PSP.Interactables
{
    public class Tire : MonoBehaviour, IInteractable
    {
        public void Interact(GameObject interacter) {
            transform.parent = interacter.transform;
        }
    }
}
