
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// ProjectSetting/Inputを自動設定して
/// SteeringControllerからの入力を有効化します。
/// </summary>
public class EnableSteeringController {

	static Dictionary<string, string> buttons = new Dictionary<string, string> () {
		{"SQUARE", "joystick button 0"},
		{"CROSS", "joystick button 1"},
		{"CIRCLE", "joystick button 2"},
		{"TRIANGLE", "joystick button 3"},
		{"L1", "joystick button 4"},
		{"R1", "joystick button 5"},
		{"LLEVER", "joystick button 6"},
		{"RLEVER", "joystick button 7"},
		{"SHARE", "joystick button 8"},
		{"OPTIONS", "joystick button 9"},
		{"L3", "joystick button 10"},
		{"R3", "joystick button 11"},
		{"PS", "joystick button 12"}
	};

	/// <summary>
	/// ProjectSetting/Inputの再設定
	/// </summary>
	[MenuItem("SteeringController/Enable Input")]
	public static void EnableSteeringContoller()
	{
		InputManagerGenerator inputManagerGenerator = new InputManagerGenerator();

		// 現在の設定をクリア
		inputManagerGenerator.Clear();

		// ハンドル入力を登録
		{
			var name = "HANDLE";
			inputManagerGenerator.AddAxis(InputAxis.CreatePadAxis(name, 0, 1));
			inputManagerGenerator.AddAxis(InputAxis.CreateKeyAxis(name, "a", "d", "left", "right"));
		}
		// ボタン入力を登録
		foreach (var button in buttons) {
			var buttonName = button.Key;
			var inputName = button.Value;
			inputManagerGenerator.AddAxis(InputAxis.CreateButton(buttonName, inputName, inputName));
		}

		// デフォルト
		{
			inputManagerGenerator.AddAxis(InputAxis.CreatePadAxis("Horizontal", 0, 1));
			inputManagerGenerator.AddAxis(InputAxis.CreateKeyAxis("Horizontal", "a", "d", "left", "right"));
			inputManagerGenerator.AddAxis(InputAxis.CreatePadAxis("Vertical", 0, 2));
			inputManagerGenerator.AddAxis(InputAxis.CreateKeyAxis("Vertical", "s", "w", "down", "up"));
			inputManagerGenerator.AddAxis(InputAxis.CreateButton("Submit", "enter", "joystick button 0"));
			inputManagerGenerator.AddAxis(InputAxis.CreateButton("Cancel", "escape", "joystick button 1"));
		}
			
		// 完了
		Debug.Log("ProjectSetting/InputにSteeringControllerを設定しました。");
	}

}

#endif