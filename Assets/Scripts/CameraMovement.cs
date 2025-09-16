using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Target")]
    public Transform target; // Assign your player ship in Inspector
    public Vector3 offset = new Vector3(0, 0, -10); // Z should be negative for 2D

    [Header("Smoothing")]
    public float smoothSpeed = 5f;
    public bool enableSmoothing = true;

    [Header("Advanced")]
    public float lookAheadFactor = 0.5f; // Predicts player movement
    public Vector2 deadzoneSize = new Vector2(2f, 1f); // Center area where camera won't move

    private Vector3 _velocity;
    private Vector3 _lastTargetPosition;

    void Start()
    {
        EventManager.AddListener(EventName.CameraTargetEvent, FindPlayer);

/*        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
        if (target == null)
            return;

        _lastTargetPosition = target.position;
        transform.position = target.position + offset; // Snap to target initially*/
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = CalculateTargetPosition();
        transform.position = enableSmoothing ?
            Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, 1f / smoothSpeed) :
            targetPosition;

        _lastTargetPosition = target.position;
    }

    Vector3 CalculateTargetPosition()
    {
        // Base position with offset
        Vector3 basePosition = target.position + offset;

        // Apply deadzone
        Vector2 deltaFromCenter = (Vector2)transform.position - (Vector2)target.position;
        if (Mathf.Abs(deltaFromCenter.x) < deadzoneSize.x / 2 &&
            Mathf.Abs(deltaFromCenter.y) < deadzoneSize.y / 2)
        {
            return transform.position; // Don't move if within deadzone
        }

        // Add look-ahead prediction
        Vector3 direction = (target.position - _lastTargetPosition).normalized;
        return basePosition + (direction * lookAheadFactor);
    }
    public void FindPlayer(int value)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Visualize deadzone in editor
    void OnDrawGizmosSelected()
    {
        if (target != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(target.position, deadzoneSize);
        }
    }
}
