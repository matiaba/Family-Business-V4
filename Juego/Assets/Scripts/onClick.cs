using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onClick : MonoBehaviour {

	public Button yourButton;
	public static bool onhover = false;
	public Text text;
	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		onhover = false;
        text.color = Color.white;
	}
}
