using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hole;
    public Camera cam;
    public float baseSize = 5f;
    public float scaleMultiplier = 2f;
    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (hole == null) return;

        Vector3 targetPosition = hole.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.2f);

        float holeScale = hole.localScale.x; 
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, baseSize + holeScale * scaleMultiplier, Time.deltaTime * 2f);
    }
}