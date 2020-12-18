using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;

    // Start is called before the first frame update
    void Start()
    {
        if (transitionName == PlayerGridController.instance.areaTransitionName)
        {
            PlayerGridController.instance.ground = GameObject.Find("Ground").GetComponent<Tilemap>();
            PlayerGridController.instance.obstruction = GameObject.Find("Solid").GetComponent<Tilemap>();
            PlayerGridController.instance.transform.position =
                transform.position;
        }
        UIFade.instance.FadeFromBlack();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
