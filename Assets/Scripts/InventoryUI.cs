using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;
    

    void Update()
    {
        string items = "Inventory:\n";
        foreach (CollectibleScript item in InventoryScript.instance.items)
        {
            items += item.itemName + "\n";
        }
        inventoryText.text = items;
    }
}
