using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ContadorEnemigosNivel : MonoBehaviour {

	public GameObject[] enemies;
	public List<string> mylist;
	public static string curscene;
	public string text;
	void Start () {
		curscene = SceneManager.GetActiveScene().name;
		GameObject[] enemiesAll = GameObject.FindGameObjectsWithTag("Enemy");
		enemies = new GameObject[enemiesAll.Length];
		mylist = new List<string>();
		enemiesAll.CopyTo(enemies, 0);

	}

	private void Update() {
		switch (curscene){

			case "Tutorial":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel0 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel0 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level1":
			text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel1 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel1 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level2":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel2 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel2 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level3":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel3 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel3 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level4":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel4 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel4 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level5":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel5 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel5 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level6":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel6 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel6 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level7":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel7 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel7 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level8":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel8 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel8 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level9":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel9 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel9 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			case "Level10":
				text = "Logro: Noqueados " + mylist.Count + "/" + enemies.Length;
				if (GameManager.logronivel10 == 0){
					if(mylist.Count == enemies.Length){
						GameManager.logronivel10 = 1;
					}
				}
				else{
					mostrarOtrosLogro();
				}
				break;

			default:
				break;

		}
	}


void mostrarOtrosLogro(){
		if (GameManager.noquearPuño < 5)
		{
			if (GameManager.noquearPuño == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearPuño + "/1 con Puño";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearPuño + "/5 con Puño";
			}
		}
		else if (GameManager.noquearBat < 5)
		{
			if (GameManager.noquearBat == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearBat + "/1 con Bat";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearBat + "/5 con Bat";
			}
		}
		else if (GameManager.noquearBowie < 5)
		{
			if (GameManager.noquearBowie == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearBowie + "/1 con Bowie";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearBowie + "/5 con Bowie";
			}
		}
		else if (GameManager.noquearColt < 5)
		{
			if (GameManager.noquearColt == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearColt + "/1 con Colt";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearColt + "/5 con Colt";
			}
		}
		else if (GameManager.noquearMac10 < 5)
		{
			if (GameManager.noquearMac10 == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearMac10 + "/1 con Mac10";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearMac10 + "/5 con Mac10";
			}
		}
		else if (GameManager.noquearMatute < 5)
		{
			if (GameManager.noquearMatute == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearMatute + "/1 con Matute";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearMatute + "/5 con Matute";
			}
		}
		else if (GameManager.noquearSawnOff < 5)
		{
			if (GameManager.noquearSawnOff == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearSawnOff + "/1 con SawnOff";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearSawnOff + "/5 con SawnOff";
			}
		}
		else if (GameManager.noquearThompson < 5)
		{
			if (GameManager.noquearThompson == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearThompson + "/1 con Thompson";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearThompson + "/5 con Thompson";
			}
		}
		else if (GameManager.noquearWinchester < 5)
		{
			if (GameManager.noquearWinchester == 0)
			{
				text = "Logro: Noquear " + GameManager.noquearWinchester + "/1 con Winchester";
			}
			else{
				text = "Logro: Noquear " + GameManager.noquearWinchester + "/5 con Winchester";
			}
		}
		else{
			text = "";
		}
	}

}
