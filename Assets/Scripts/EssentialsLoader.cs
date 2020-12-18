﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (UIFade.instance == null)
        {
            UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
        }
        if (PlayerGridController.instance == null)
        {
            PlayerGridController clone =
                Instantiate(player).GetComponent<PlayerGridController>();
            PlayerGridController.instance = clone;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
