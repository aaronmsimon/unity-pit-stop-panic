using UnityEngine;
using PSP.Items;

namespace PSP.Vehicles
{
    public class Vehicle : MonoBehaviour
    {
        [SerializeField] private Tire tire;
        [SerializeField] private TireInfo[] tireInfos;

        private void Awake() {
            SpawnTires();
        }

        public void SpawnTires() {
            foreach (TireInfo tireInfo in tireInfos) {
                Instantiate(tire, tireInfo.SpawnPoint.position, Quaternion.Euler(tireInfo.Rotation), tireInfo.SpawnPoint);
            }
        }

        [System.Serializable]
        public class TireInfo {
            [SerializeField] private Transform spawnPoint;
            [SerializeField] private Vector3 tireRotation;

            public Transform SpawnPoint => spawnPoint;
            public Vector3 Rotation => tireRotation;
        }
    }
}
