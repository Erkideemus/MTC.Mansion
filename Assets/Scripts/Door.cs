using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : IInteractable
{
    public Door OtherEnd;
    public Room room;

    private void Start()
    {
        if (OtherEnd.OtherEnd == null && OtherEnd != null)
        {
            OtherEnd.OtherEnd = this;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interactor interactor = collision.gameObject.GetComponent<Interactor>();
        if (interactor != null)
        {
            interactor.currentDoor = this;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Interactor interactor = collision.gameObject.GetComponent<Interactor>();
        if (interactor != null)
        {
            interactor.currentDoor = null;
        }
    }

    public override void Action()
    {
        Debug.Log("Door");
        base.Action();
    }

    public void Transport(GameObject Player)
    {
        Camerafollow cam = Camera.main.GetComponent<Camerafollow>();
        cam.SetRoom(OtherEnd.room);
        Player.transform.position = OtherEnd.transform.position;
    }
}
