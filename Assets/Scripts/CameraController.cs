using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private float PosY;
    private float PosZ;

    void LateUpdate()
    {
        if (player == null) return;

        PosY = offset.y + player.transform.localScale.y;
        PosZ = offset.z - player.transform.localScale.z;
        //transform.position = new Vector3(player.transform.position.x, PosY, player.transform.position.z + PosZ);
        transform.position = player.transform.position + new Vector3(0, PosY, PosZ);
    }
}