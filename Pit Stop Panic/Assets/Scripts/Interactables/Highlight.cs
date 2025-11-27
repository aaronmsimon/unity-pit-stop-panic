using UnityEngine;

namespace PSP.Interactables
{
    public class Highlight : MonoBehaviour
    {
        [SerializeField] private Material regular;
        [SerializeField] private Material highlighted;
        [SerializeField] private SelectedObjectSO selectedObject;

        private MeshRenderer mr;

        private void Awake() {
            mr = GetComponent<MeshRenderer>();
        }

        public void SelectItem() {
            if (gameObject == selectedObject.selectedObject) {
                mr.material = highlighted;
            } else {
                mr.material = regular;
            }
        }
    }
}
