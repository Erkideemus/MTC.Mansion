using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderList : MonoBehaviour
{
    public static OrderList instance;
    [SerializeField]
    public List<IInteractable> order;

    private void Start()
    {
        instance = this;
    }

    public void Progress()
    {
        OrderList.instance.order.RemoveAt(OrderList.instance.order.Count - 1);
    }
}
