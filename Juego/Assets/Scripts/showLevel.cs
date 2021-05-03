using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class showLevel : MonoBehaviour {
	public GameObject nivel1;
	public GameObject nivel2;
	public GameObject nivel3;
	public GameObject nivel4;
	public GameObject nivel5;
	public GameObject nivel6;
	public GameObject nivel7;
	public GameObject nivel8;
	public GameObject nivel9;
	public GameObject nivel10;
	void Start(){
		string sceneLevel = PlayerPrefs.GetString("nivel");
		switch (sceneLevel){
			case "Tutorial":
				break;
			case "Level1":
				nivel1.SetActive(true);
			break;
			case "Level2":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				break;
			case "Level3":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				break;
			case "Level4":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				break;
			case "Level5":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				break;
			case "Level6":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				nivel6.SetActive(true);
				break;
			case "Level7":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				nivel6.SetActive(true);
				nivel7.SetActive(true);
				break;
			case "Level8":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				nivel6.SetActive(true);
				nivel7.SetActive(true);
				nivel8.SetActive(true);
				break;
			case "Level9":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				nivel6.SetActive(true);
				nivel7.SetActive(true);
				nivel8.SetActive(true);
				nivel9.SetActive(true);
				break;
			case "Level10":
				nivel1.SetActive(true);
				nivel2.SetActive(true);
				nivel3.SetActive(true);
				nivel4.SetActive(true);
				nivel5.SetActive(true);
				nivel6.SetActive(true);
				nivel7.SetActive(true);
				nivel8.SetActive(true);
				nivel9.SetActive(true);
				nivel10.SetActive(true);
				break;
		}
	}
}
