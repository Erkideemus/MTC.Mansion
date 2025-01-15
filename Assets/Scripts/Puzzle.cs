using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puzzle : IInteractable
{
    public GameObject ItemSpawn;
    public string ItemNeeded;
    bool Iscompleted = false;

    public string CompleteInfo;
    public string ErrorInfo;
    public GameObject text;

    public Phantom phantom;
    public PhantomNode node;

    private void Start()
    {
        ItemSpawn.SetActive(false);
    }

    public override void Action()
    {
        if (Iscompleted == false)
        {
            if (InventoryManager.instance.FindItem(ItemNeeded) == true)
            {
                ItemSpawn.SetActive(true);
                Iscompleted = true;
                gameObject.SetActive(false); 
                text.GetComponent<TextMeshProUGUI>().text = CompleteInfo;
                TextPop pop = text.gameObject.GetComponent<TextPop>();
                pop.Display();
                if (OrderList.instance.order[OrderList.instance.order.Count - 1] == this)
                {
                    OrderList.instance.Progress();
                }
                if (phantom != null)
                {
                    CreatePhantom();
                }
            }
            else
            {
                text.GetComponent<TextMeshProUGUI>().text = ErrorInfo;
                TextPop pop = text.gameObject.GetComponent<TextPop>();
                pop.Display();
            }
        }
    }

    public void CreatePhantom()
    {
        phantom.gameObject.SetActive(true);
        phantom.ResetPhantom(node);
    }
}
