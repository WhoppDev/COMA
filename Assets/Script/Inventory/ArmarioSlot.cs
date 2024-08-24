using UnityEngine;
using UnityEngine.UI;

public class ArmarioSlot : MonoBehaviour
{
    public ItensDATA itemData;
    public string itemID;
    public string armarioID;
    public Image iconImage;
    public Button btn;
    [SerializeField] public GameObject subMenuInstancePosition;

    public GameObject subMenuInstance;

    public void pegarItem()
    {
        CORE.instance.inventarioController.inventario.itemID.Add(itemID);
        CORE.instance.inventarioController.inventario.armarioID.Add(armarioID);
        CORE.instance.inventarioController.inventario.Save();
        Destroy(gameObject);
    }

    public void selectItem() //Instaciar o SubMenu para poder usar o Inspecionar/Pegar
    {
        GameObject subMenu = Instantiate(subMenuInstance, subMenuInstancePosition.transform.position, transform.rotation);
        subMenu.transform.SetParent(this.transform);
    }

    public void AssignItem(ItensDATA newItemData, string _ArmarioID)
    {
        itemData = newItemData;
        armarioID = _ArmarioID;
        UpdateSlotUI();
    }

    public void UpdateSlotUI()
    {
        if (itemData != null)
        {
            iconImage.sprite = itemData.itemIcon;
            itemID = itemData.itemID;
            iconImage.gameObject.SetActive(true);
            ConfigurarBtn();
        }
        else
        {
            iconImage.gameObject.SetActive(false);
        }
    }

    private void ConfigurarBtn()
    {
        Debug.Log("Configurando botão");
        btn.onClick.AddListener(selectItem);

    }

}
