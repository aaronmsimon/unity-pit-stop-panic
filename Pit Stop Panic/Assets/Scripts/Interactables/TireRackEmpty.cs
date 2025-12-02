using UnityEngine;
using PSP.Items;
using PSP.Actors;

namespace PSP.Interactables
{
    public class TireRackEmpty : MonoBehaviour, IInteractable, IGarageObjectParent
    {
        [SerializeField] private Transform[] wheelHoldPositions;

        private int wheelIndex;
        private GarageObject garageObject;

        private void Awake() {
            wheelIndex = 0;
        }

        public void Interact(Player player) {
            if (player.TryGetComponent(out IGarageObjectParent garageObjectParent)) {
                GarageObject garageObject = garageObjectParent.GetGarageObject();
                garageObject.SetGarageObjectParent(this);
                garageObject.transform.localEulerAngles = Vector3.zero;
                wheelIndex++;
            }
        }

        public Transform GetGarageObjectFollowTransform() {
            return wheelHoldPositions[wheelIndex].transform;
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
            return false;
        }
    }
}
