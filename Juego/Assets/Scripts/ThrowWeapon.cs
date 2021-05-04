using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class ThrowWeapon : MonoBehaviour {
	EnemyAttacked attacked;
	float timer = 2.0f;
	Vector3 direction;
	Rigidbody2D rid;
    string sceneName;
    //GameObject player;
    // Use this for initialization

    void Start () {

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
		//player = GameObject.FindGameObjectWithTag ("Player");
		rid = this.GetComponent<Rigidbody2D> ();
		rid.AddForce (direction*40);
	}

	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Slerp(this.transform.rotation,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-1,this.transform.rotation.w), Time.deltaTime * 10);
		timer -= Time.deltaTime;
		if(timer<=0)
		{
			rid.isKinematic = true;
			Destroy (this);
		}

	}


    public void setDirection(Vector3 dir)
	{
		direction = dir;
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			attacked = col.gameObject.GetComponent<EnemyAttacked> ();
			attacked.knockDownEnemy();
			int level;
			if (sceneName == "Tutorial")
			{
					level = 0;
			}
			else
			{
					level = Utils.LevelFromSceneName(sceneName);

			}

			if (GameManager.ultimoEnemigoNoqueadoConArma != attacked.nombreEnemigo){
				Debug.Log("nivel de Noquear: " + level);
				Debug.Log("Nombre de enemigo noqueado: " + attacked.nombreEnemigo);
				Debug.Log("tiempo de Noquear: " + Time.timeSinceLevelLoad);
				WeaponPickup weapon = this.GetComponent<WeaponPickup>();
				Debug.Log("arma de Noquear: " + weapon.name);
				Debug.Log("Insertar evento de noquear arrojando arma");


				switch(weapon.name){
					case "Bowie":
						GameManager.noquearBowie += 1;
						break;
					case "Colt":
						GameManager.noquearColt += 1;
						break;
					case "Mac10":
						GameManager.noquearMac10 += 1;
						break;
					case "Bat":
						GameManager.noquearBat += 1;
						break;
					case "Thompson":
						GameManager.noquearThompson += 1;
						break;
					case "SawnOff":
						GameManager.noquearSawnOff += 1;
						break;
					case "Winchester":
						GameManager.noquearWinchester += 1;
						break;
					case "Matute":
						GameManager.noquearMatute += 1;
						break;
					default:
						break;
				}

				Analytics.CustomEvent("Noquear", new Dictionary<string, object>
				{   { "nivel", level },
						{ "enemigo", attacked.nombreEnemigo },
						{ "tiempo", Time.timeSinceLevelLoad }
				}
				);
				GameManager.ultimoEnemigoNoqueadoConArma = attacked.nombreEnemigo;
			}
			rid.isKinematic = true;
			Destroy (this);

		}
		else if(col.gameObject.tag=="Player")
		{

        }
		else if (col.gameObject.tag == "Dog") {
			col.gameObject.GetComponent<DogHealth> ().killDog ();
		}
		else if (col.gameObject.tag == "Wall") {
            rid.velocity = new Vector3(0, 0, 0);
		}
		else {
			rid.isKinematic = true;
			Destroy (this);

		}
	}
}
