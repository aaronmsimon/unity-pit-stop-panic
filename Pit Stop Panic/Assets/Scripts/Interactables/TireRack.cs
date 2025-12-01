using UnityEngine;
using PSP.Actors;

namespace PSP.Interactables
{
    public class TireRack : MonoBehaviour, IInteractable
    {
        [SerializeField] private GameObject tirePrefab;

        public void Interact(Player player)
        {
            GameObject tire = Instantiate(tirePrefab, transform);
            tire.transform.localPosition = Vector3.zero;

            // Tire tire = Instantiate(tirePrefab, wheelPoint.transform);
            // tire.SetGarageObjectParent(wheelPoint);
        }
    }
}
