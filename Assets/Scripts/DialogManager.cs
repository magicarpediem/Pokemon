﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;

    public Text nameText;

    public GameObject dialogBox;

    public GameObject nameBox;

    public string[] dialogLines;

    public int currentLine;

    public static DialogManager instance;

    private bool justStarted;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                if (!justStarted)
                {
                    currentLine++;
                    if (currentLine >= dialogLines.Length)
                    {
                        dialogBox.SetActive(false);
                        PlayerGridController.instance.canMove = true;
                    }
                    else
                    {
                        dialogText.text = dialogLines[currentLine];
                    }
                }
                else
                {
                    justStarted = false;
                }
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        dialogLines = newLines;

        currentLine = 0;

        dialogText.text = dialogLines[0];
        dialogBox.SetActive(true);

        justStarted = true;

        PlayerGridController.instance.canMove = false;
    }

    public void checkIfName()
    {
        if (dialogLines[currentLine].StartsWith("n-"))
        {
            nameText.text = dialogLines[currentLine];
            currentLine++;
        }
    }
}
