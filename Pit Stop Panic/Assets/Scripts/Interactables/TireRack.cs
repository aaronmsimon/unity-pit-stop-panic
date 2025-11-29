using UnityEngine;

namespace PSP.Interactables
{
    public class TireRack : MonoBehaviour, IInteractable
    {
        [SerializeField] private GameObject tirePrefab;

        public void Interact(GameObject interactor)
        {
            GameObject tire = Instantiate(tirePrefab, transform);
            tire.transform.localPosition = Vector3.zero;
        }
    }
}
