using UnityEngine;

namespace PSP.Items
{
    public class Tire : GarageObject
    {
        private BoxCollider boxCollider;

        private void Awake() {
            boxCollider = GetComponent<BoxCollider>();
        }

        public void EnableCollider(bool enable) {
            boxCollider.enabled = enable;
        }
    }
}
