using UnityEngine;

public class Compass2D : MonoBehaviour
{
    public Transform player; // The player's Transform
    public Transform target; // The target's Transform
    public RectTransform Pointer;

    private string[] cardinalDirections = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };
    private float[] directionAngles = { 90, 45, 0, 315, 270, 225, 180, 135 }; // Angles for cardinal directions

    void Update()
    {
        // Calculate the direction to the target
        Vector2 directionToTarget = target.position - player.position;

        // Get the angle in degrees
        float angleToTarget = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

        // Normalize the angle to [0, 360)
        angleToTarget = (angleToTarget + 360) % 360;

        // Find the nearest cardinal direction
        int closestIndex = GetClosestDirection(angleToTarget);

        // Debug the direction
        Debug.Log("Target is to the " + cardinalDirections[closestIndex]);
        Pointer.rotation = Quaternion.Euler(0, 0, directionAngles[closestIndex]);
    }

    int GetClosestDirection(float angle)
    {
        // Find the closest direction
        int closestIndex = 0;
        float smallestDifference = Mathf.Infinity;

        for (int i = 0; i < directionAngles.Length; i++)
        {
            float difference = Mathf.Abs(angle - directionAngles[i]);
            if (difference < smallestDifference)
            {
                smallestDifference = difference;
                closestIndex = i;
            }
        }

        return closestIndex;
    }
}
