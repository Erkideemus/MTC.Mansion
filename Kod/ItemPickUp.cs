using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item item;

    bool inRange = false;

    public void Pickup()
    {
        InventoryManager.instance.Add(item);
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            inRange = true;

            Debug.Log("In Range");
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col .gameObject.tag == "Player")
        {
            inRange = false;

            Debug.Log("Not In Range");
        }
    }

    private void OnMouseDown()
    {
        if (inRange == true)
        {
            Pickup();
        }
    }
}
