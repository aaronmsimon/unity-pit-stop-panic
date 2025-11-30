using UnityEngine;
using PSP.Items;

namespace PSP.Vehicles
{
    public class Vehicle : MonoBehaviour
    {
        [SerializeField] private Tire tirePrefab;
        [SerializeField] private WheelPoint[] wheelPoints;

        private void Awake() {
            SpawnTires();
        }

        public void SpawnTires() {
            foreach (WheelPoint wheelPoint in wheelPoints) {
                Tire tire = Instantiate(tirePrefab, wheelPoint.transform);
                tire.SetGarageObjectParent(wheelPoint);
            }
        }
    }
}
