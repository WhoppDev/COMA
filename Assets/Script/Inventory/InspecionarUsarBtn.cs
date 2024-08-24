using UnityEngine;

public class InspecionarUsarBtn : MonoBehaviour
{
    private ArmarioSlot armarioSlot;

    private void Start()
    {
        armarioSlot = GetComponentInParent<ArmarioSlot>();
    }

    public void Inspecionar()
    {
        Debug.Log("Inspecionar");
    }

    public void Usar()
    {
        armarioSlot.pegarItem();
    }
}
