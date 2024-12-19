using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public Door currentDoor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Key");
            if (currentDoor != null)
            {
                currentDoor.Transport(this.gameObject);
            }
        }
    }
}
