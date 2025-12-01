using UnityEngine;
using PSP.Items;
using PSP.Actors;

namespace PSP.Interactables
{
    public class TireRackEmpty : MonoBehaviour, IInteractable, IGarageObjectParent
    {
        [SerializeField] private Transform wheelHoldPos;

        private GarageObject garageObject;

        public void Interact(Player player) {
            Debug.Log("interacted!");
            if (player.TryGetComponent(out IGarageObjectParent garageObjectParent)) {
                GarageObject garageObject = garageObjectParent.GetGarageObject();
                garageObject.SetGarageObjectParent(this);
                garageObject.transform.localEulerAngles = Vector3.zero;
            }
        }

        public Transform GetGarageObjectFollowTransform() {
            return wheelHoldPos.transform;
        }
        
        public void SetGarageObject(GarageObject garageObject) {
            this.garageObject = garageObject;
        }

        public GarageObject GetGarageObject() {
            return garageObject;
        }

        public void ClearGarageObject() {
            garageObject = null;
        }

        public bool HasGarageObject() {
            return garageObject != null;
        }
    }
}
