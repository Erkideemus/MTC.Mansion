using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
    public Room currentRoom;
    private void Start()
    {
        SetRoom(currentRoom);
    }

    void Update()
    {
        Vector2 position = player.position;
        if (position.x <= MinX)
        {
            position.x = MinX;
        }
        if (position.x >= MaxX)
        {
            position.x = MaxX;
        }
        if (position.y <= MinY)
        {
            position.y = MinY;
        }
        if (position.y >= MaxY)
        {
            position.y = MaxY;
        }
        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }

    public void SetRoom(Room newRoom)
    {
        MaxX = newRoom.getMaxX();
        MinX = newRoom.getMinX();
        MaxY = newRoom.getMaxY();
        MinY = newRoom.getMinY();
        currentRoom = newRoom;
    }
}
