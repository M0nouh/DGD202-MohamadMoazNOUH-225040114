using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static InventoryScript instance;
    public List<CollectibleScript> items = new List<CollectibleScript>();

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddItem(CollectibleScript item)
    {
        items.Add(item);
        Debug.Log(item.itemName + " added to inventory.");
      
    }
}
