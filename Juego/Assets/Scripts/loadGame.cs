using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {

	public void LoadGame(){
		GameManager.noquearPuño = PlayerPrefs.GetInt("arma1");
		GameManager.noquearBat = PlayerPrefs.GetInt("arma2");
		GameManager.noquearBowie = PlayerPrefs.GetInt("arma3");
		GameManager.noquearColt = PlayerPrefs.GetInt("arma4");
		GameManager.noquearMac10 = PlayerPrefs.GetInt("arma5");
		GameManager.noquearMatute = PlayerPrefs.GetInt("arma6");
		GameManager.noquearSawnOff = PlayerPrefs.GetInt("arma7");
		GameManager.noquearThompson = PlayerPrefs.GetInt("arma8");
		GameManager.noquearWinchester = PlayerPrefs.GetInt("arma9");
		GameManager.logronivel0 = PlayerPrefs.GetInt("logro0");
		GameManager.logronivel1 = PlayerPrefs.GetInt("logro1");
		GameManager.logronivel2 = PlayerPrefs.GetInt("logro2");
		GameManager.logronivel3 = PlayerPrefs.GetInt("logro3");
		GameManager.logronivel4 = PlayerPrefs.GetInt("logro4");
		GameManager.logronivel5 = PlayerPrefs.GetInt("logro5");
		GameManager.logronivel6 = PlayerPrefs.GetInt("logro6");
		GameManager.logronivel7 = PlayerPrefs.GetInt("logro7");
		GameManager.logronivel8 = PlayerPrefs.GetInt("logro8");
		GameManager.logronivel9 = PlayerPrefs.GetInt("logro9");
		GameManager.logronivel10 = PlayerPrefs.GetInt("logro10");
		SceneManager.LoadScene(PlayerPrefs.GetString("nivel"));
	}
}