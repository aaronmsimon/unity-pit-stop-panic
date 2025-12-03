using UnityEngine;
using PSP.Actors;
using PSP.Items;

namespace PSP.Interactables
{
    public class TireRack : MonoBehaviour, IInteractable
    {
        [SerializeField] private GarageObject tirePrefab;

        public void Interact(Player player)
        {
            GarageObject tire = Instantiate(tirePrefab);
            tire.transform.localPosition = Vector3.zero;
            tire.SetGarageObjectParent(player);
            tire.transform.localEulerAngles = Vector3.zero;
        }
    }
}
