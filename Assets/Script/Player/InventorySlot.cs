using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public GameObject actionMenuPrefab;
    private GameObject actionMenuInstance;

    public void OnItemSelect()
    {
        if (actionMenuInstance != null)
        {
            Destroy(actionMenuInstance);
        }

        actionMenuInstance = Instantiate(actionMenuPrefab, Vector3.zero, Quaternion.identity, this.transform);

        actionMenuInstance.transform.localPosition = Vector3.zero;

        actionMenuInstance.transform.localScale = Vector3.one;
    }

    public void HideActionMenu()
    {
        if (actionMenuInstance != null)
        {
            Destroy(actionMenuInstance);
        }
    }
}

