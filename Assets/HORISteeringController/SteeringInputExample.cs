using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteeringInputExample : MonoBehaviour {
	
	[SerializeField]
	private Text infomationText;

	//対応しているボタン
	string[] buttons = { 
		"SQUARE", "CROSS", "CIRCLE", "TRIANGLE",  "L1", "R1", 
		"LLEVER", "RLEVER", "SHARE", "OPTIONS", "L3", "R3", "PS"
	};
		
	void Update () {

		string info = "";

		var handleValue = Input.GetAxis ("HANDLE");
		var pushButtons = " ";
		for (int i = 0; i < buttons.Length; i++) {
			if (Input.GetButton(buttons[i])) {
				pushButtons += (buttons [i] + " ");
			}
		}

		info += "handle value\n\n";
		info += handleValue.ToString();
		info += "\n\n";
		info += "push buttons";
		info += "\n\n";
		info += pushButtons;

			
		infomationText.text = info;
	}

}
