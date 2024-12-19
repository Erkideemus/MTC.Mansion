using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
    public List<Door> doors;

    public float getMaxX()
    {
        return MaxX + transform.position.x;
    }
    public float getMinX()
    {
        return MinX + transform.position.x;
    }
    public float getMaxY()
    {
        return MaxY + transform.position.y;
    }
    public float getMinY()
    {
        return MinY + transform.position.y;
    }
}
