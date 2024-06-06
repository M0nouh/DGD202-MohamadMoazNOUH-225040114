using TMPro;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public string itemName;
    public TextMeshProUGUI pressE;
    public bool inRange;
    public AudioSource collectionMusic;

    private void Start()
    {
        inRange = false;
        pressE.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            pressE.text = ("Press E to obtain");
            inRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pressE.text = "";
            inRange = false;
        }
    }
    void Update()
    {
        if (inRange && Input.GetKey(KeyCode.E))
        {
            InventoryScript.instance.AddItem(this);
            Destroy(gameObject);
            collectionMusic.Play();
        }
    }
}
