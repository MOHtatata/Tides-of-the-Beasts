using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBorders : MonoBehaviour
{
    [Header("Boundary Settings")]
    public Vector2 minBounds = new Vector2(-10, -5);
    public Vector2 maxBounds = new Vector2(10, 5);
    public float edgeBuffer = 0.5f; // Distance before bounce occurs

    void FixedUpdate()
    {
        CheckBoundaries();
    }
    void CheckBoundaries()
    {
        Vector2 currentPos = transform.position;
        bool hitBorder = false;

        // Check X axis boundaries
        if (currentPos.x < minBounds.x + edgeBuffer)
        {
            currentPos.x = minBounds.x + edgeBuffer;
            hitBorder = true;
        }
        else if (currentPos.x > maxBounds.x - edgeBuffer)
        {
            currentPos.x = maxBounds.x - edgeBuffer;
            hitBorder = true;
        }

        // Check Y axis boundaries
        if (currentPos.y < minBounds.y + edgeBuffer)
        {
            currentPos.y = minBounds.y + edgeBuffer;
            hitBorder = true;
        }
        else if (currentPos.y > maxBounds.y - edgeBuffer)
        {
            currentPos.y = maxBounds.y - edgeBuffer;
            hitBorder = true;
        }

        // Apply position and effects
        if (hitBorder)
        {
            transform.position = currentPos;
        }
    }
    // Visualize boundaries in editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Vector3 center = (minBounds + maxBounds) / 2;
        Vector3 size = maxBounds - minBounds;
        Gizmos.DrawWireCube(center, size);
    }
}
