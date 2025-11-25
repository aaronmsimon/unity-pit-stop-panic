using UnityEngine;

namespace PSP.Items
{
    [CreateAssetMenu(menuName = "Game/SelectedObject")]
    public class SelectedObjectSO : ScriptableObject
    {
        public GameObject selectedObject;
    }
}
