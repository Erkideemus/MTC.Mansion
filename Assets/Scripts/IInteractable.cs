using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IInteractable : MonoBehaviour
{
    private void OnMouseDown()
    {
        Action();
    }

    public virtual void Action() { }
}
