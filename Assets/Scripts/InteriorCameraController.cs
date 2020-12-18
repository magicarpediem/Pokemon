using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InteriorCameraController : MonoBehaviour
{
    public Transform target;

    public Tilemap map;

    private Vector3 bottomLeftLimit;

    private Vector3 topRightLimit;

    private float halfHeight;

    private float halfWidth;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerGridController>().transform;

        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        // bottomLeftLimit =
        //     map.localBounds.min + new Vector3(halfWidth, halfHeight, 0);
        // topRightLimit =
        //     map.localBounds.max + new Vector3(-halfWidth, -halfHeight, 0);

        // PlayerGridController
        //     .instance
        //     .SetBounds(map.localBounds.min, map.localBounds.max);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position =
            new Vector3(target.position.x,
                target.position.y,
                transform.position.z);

        //keep the camera inside the bounds
        // transform.position =
        //     new Vector3(Mathf
        //             .Clamp(transform.position.x,
        //             bottomLeftLimit.x,
        //             topRightLimit.x),
        //         Mathf
        //             .Clamp(transform.position.y,
        //             bottomLeftLimit.y,
        //             topRightLimit.y),
        //         transform.position.z);
    }
}
