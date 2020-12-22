using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
	public Text dialogText;

	public Text nameText;

	public GameObject dialogBox;

	// public GameObject nameBox;

	public string[] dialogLines;

	public int currentLine;

	public static DialogManager instance;

	// Start is called before the first frame update
	void Start()
	{
		instance = this;
	}

	public void Dialog(DialogLines dialog)
	{
		if (!dialogBox.activeInHierarchy)
		{
			Initiate(dialog.lines);
		}
		else
		{
			NextLine();
		}
	}

	private void Initiate(String[] newLines)
	{
		dialogLines = newLines;

		currentLine = 0;

		dialogText.text = parse(dialogLines[0]);
		dialogBox.SetActive(true);
		currentLine++;

		PlayerGridController.instance.canMove = false;
	}

	public void NextLine()
	{
		if (currentLine >= dialogLines.Length)
		{
			dialogBox.SetActive(false);
			PlayerGridController.instance.canMove = true;
			dialogLines = new string[0];
			currentLine = 0;
			return;
		}
		dialogText.text = parse(dialogLines[currentLine]);
		currentLine++;
	}

	public String parse(String str)
	{
		if (str.Contains("\\n"))
		{
			str = str.Replace("\\n", "\n");
		}
		return str;
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
