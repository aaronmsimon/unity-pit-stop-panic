using UnityEngine;

namespace PSP.Items
{
    public interface IGarageObjectParent
    {
        public Transform GetGarageObjectFollowTransform();

        public void SetGarageObject(GarageObject garageObject);

        public GarageObject GetGarageObject();

        public void ClearGarageObject();

        public bool HasGarageObject();
    }
}
