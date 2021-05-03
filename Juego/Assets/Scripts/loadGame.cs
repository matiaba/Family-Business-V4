using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {

	public void LoadGame(){
		GameManager.totalNoqueosUnicos = PlayerPrefs.GetInt("totalnoqueos");
		GameManager.noquearPuño = PlayerPrefs.GetInt("arma1");
		GameManager.noquearBat = PlayerPrefs.GetInt("arma2");
		GameManager.noquearBowie = PlayerPrefs.GetInt("arma3");
		GameManager.noquearColt = PlayerPrefs.GetInt("arma4");
		GameManager.noquearMac10 = PlayerPrefs.GetInt("arma5");
		GameManager.noquearMatute = PlayerPrefs.GetInt("arma6");
		GameManager.noquearSawnOff = PlayerPrefs.GetInt("arma7");
		GameManager.noquearThompson = PlayerPrefs.GetInt("arma8");
		GameManager.noquearWinchester = PlayerPrefs.GetInt("arma9");
		SceneManager.LoadScene(PlayerPrefs.GetString("nivel"));
	}
}