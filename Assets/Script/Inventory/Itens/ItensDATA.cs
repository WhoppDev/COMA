using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Item", menuName ="Scriptable/New Item")]
public class ItensDATA : ScriptableObject
{
    public string itemID;
    public Sprite itemIcon;
    public Sprite itemImagem;
    public string itemName;
    public string itemDescription;

    public bool canUse;
    public bool canInspect;
    public bool canDestroy;

    public int quantity;
}
