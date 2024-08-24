using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class AbrirArmário : MonoBehaviour, IInteractable
{
    [SerializeField] private string armarioID;
    [SerializeField] private Keys chaveNecessaria; //Colocar uma chave se for necessário para abrir

    [SerializeField] private GameObject objetoParaAtivar; //Objeto que será ativado ao abrir o armário

    [SerializeField] List<GameObject> slots;
    [SerializeField] List<ItensDATA> itens;

    public bool inventarioAtivo = false;

    private void Start()
    {

    }

    void OrganizarSlot()
    {
        inventarioAtivo = !inventarioAtivo;
        objetoParaAtivar.SetActive(inventarioAtivo);


            foreach (ItensDATA item in itens)
            {
                foreach (GameObject slot in slots)
                {
                    ArmarioSlot slotComponent = slot.GetComponent<ArmarioSlot>();
                    if (slotComponent.itemData == null)
                    {
                    Debug.Log("Item encontrado");
                    slotComponent.AssignItem(item, armarioID);
                        break;
                    }
                }


            }

    }

        public void Interact()
        {
            if (chaveNecessaria != null)
            {
                //ainda vou fazer a programaçãod a chave
            }
            else
            {
                OrganizarSlot();
            }

        }

}
