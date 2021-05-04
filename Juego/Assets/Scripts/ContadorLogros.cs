using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContadorLogros : MonoBehaviour {
	public static string textlogro;
	public GameObject enemiescount;
	void Update () {
		this.gameObject.GetComponent<Text>().text = enemiescount.GetComponent<ContadorEnemigosNivel>().text;

	}
}
