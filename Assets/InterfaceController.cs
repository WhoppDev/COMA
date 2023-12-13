using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class InterfaceController : MonoBehaviour
{
    public GameObject inventoryPanel;
    public TMP_Text itemText;

    bool invActive = false;

    private void Start()
    {
        itemText.text = null;
    }

    public void InvActive(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            invActive = !invActive;
            inventoryPanel.SetActive(invActive);
        }
    }
}
