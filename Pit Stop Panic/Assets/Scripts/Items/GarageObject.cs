using UnityEngine;

namespace PSP.Items
{
    public class GarageObject : MonoBehaviour
    {
        private IGarageObjectParent garageObjectParent;

        public void SetGarageObjectParent(IGarageObjectParent garageObjectParent) {
            if (this.garageObjectParent != null) {
                this.garageObjectParent.ClearGarageObject();
            }

            this.garageObjectParent = garageObjectParent;

            if (garageObjectParent.HasGarageObject()) {
                Debug.LogError($"IGarageObjectParent {garageObjectParent} already has a GarageObject!");
            }

            garageObjectParent.SetGarageObject(this);

            transform.parent = garageObjectParent.GetGarageObjectFollowTransform();
            transform.localPosition = Vector3.zero;
        }

        public IGarageObjectParent GetGarageObjectParent() {
            return garageObjectParent;
        }
    }
}
