using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
     public float cameraDistOffset = 10;
     public GameObject player;
     private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
         mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 playerInfo = player.transform.transform.position;
         mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - cameraDistOffset);
    }
}


