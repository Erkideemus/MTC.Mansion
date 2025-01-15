using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhantomNode : MonoBehaviour
{
    public bool IsDoor;
    public PhantomNode nextNode;

    public void NextNode(Phantom phantom)
    {
        if (nextNode == null)
        {
            phantom.gameObject.SetActive(false);
        }
        else
        {
            phantom.target = nextNode;
            if (IsDoor == true && nextNode.IsDoor == true)
            {
                phantom.transform.position = nextNode.transform.position;
            }
        }
    }
}
