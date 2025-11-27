using UnityEngine;

namespace PSP.Interactables
{
    [CreateAssetMenu(menuName = "Game/SelectedObject")]
    public class SelectedObjectSO : ScriptableObject
    {
        public GameObject selectedObject;
    }
}
