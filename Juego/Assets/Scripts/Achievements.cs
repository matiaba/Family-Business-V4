using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {
	public GameObject puños1;
	public GameObject puños5;
	public GameObject Mac101;
	public GameObject Mac105;
	public GameObject Bowie1;
	public GameObject Bowie5;
	public GameObject Bat1;
	public GameObject Bat5;
	public GameObject Matute1;
	public GameObject Matute5;
	public GameObject Winchester1;
	public GameObject Winchester5;
	public GameObject SawnOff1;
	public GameObject SawnOff5;
	public GameObject Thompson1;
	public GameObject Thompson5;
	public GameObject Colt1;
	public GameObject Colt5;
	public GameObject nivel0;
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

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("arma1") > 0){
			puños1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma1") == 5){
			puños5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma2") > 0){
			Bat1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma2") == 5){
			Bat5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma3") > 0){
			Bowie1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma3") == 5){
			Bowie5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma4") > 0){
			Colt1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma4") == 5){
			Colt5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma5") > 0){
			Mac101.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma5") == 5){
			Mac105.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma6") > 0){
			Matute1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma6") == 5){
			Matute5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma7") > 0){
			SawnOff1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma7") == 5){
			SawnOff5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma8") > 0){
			Thompson1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma8") == 5){
			Thompson5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma9") > 0){
			Winchester1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("arma9") == 5){
			Winchester5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro0") == 1){
			nivel0.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro1") == 1){
			nivel1.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro2") == 1){
			nivel2.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro3") == 1){
			nivel3.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro4") == 1){
			nivel4.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro5") == 1){
			nivel5.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro6") == 1){
			nivel6.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro7") == 1){
			nivel7.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro8") == 1){
			nivel8.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro9") == 1){
			nivel9.GetComponent<Text>().color = new Color(0,219, 0);
		}
		if (PlayerPrefs.GetInt("logro10") == 1){
			nivel10.GetComponent<Text>().color = new Color(0,219, 0);
		}
	}
}
