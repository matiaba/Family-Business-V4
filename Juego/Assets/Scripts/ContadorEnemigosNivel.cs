using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorEnemigosNivel : MonoBehaviour {

	public GameObject[] enemies;
	public List<string> mylist;
	void Start () {
		GameObject[] enemiesAll = GameObject.FindGameObjectsWithTag("Enemy");
		enemies = new GameObject[enemiesAll.Length];
		// enemiesko = new List<string>(2);
		mylist = new List<string>();
		enemiesAll.CopyTo(enemies, 0);
	}

	private void Update() {
		if(mylist.Count == enemies.Length && GameManager.logronivel1 == 0){
			Debug.Log("entregar logro");
		}
	}

}
