using UnityEngine;
using PSP.Items;
using PSP.Actors;

namespace PSP.Vehicles
{
    public class WheelPoint : MonoBehaviour, IGarageObjectParent
    {
        private GarageObject garageObject;

        public void Interact(Player player) {
            if (HasGarageObject()) {
                GetGarageObject().SetGarageObjectParent(player);
            } else {
                GarageObject garageObject = player.GetGarageObject();
                garageObject.SetGarageObjectParent(this);
                garageObject.transform.localEulerAngles = Vector3.zero;
            }
        }

        public Transform GetGarageObjectFollowTransform() {
            return transform;
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
