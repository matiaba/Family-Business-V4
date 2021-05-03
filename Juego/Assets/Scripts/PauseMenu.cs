using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour {

	float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
    bool paused = false;
	public GUIStyle text, menu;
    public static bool Button;
    SettingsWriter sw;
	public static float sfxVal = 0.5f,musicVal=0.5f;
	// Use this for initialization
	void awake()
	{
		Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");

	}

	void Start () {

        sw = new SettingsWriter ();
		Debug.LogError (File.Exists (Application.persistentDataPath + "/settings.dat") + " " + Application.persistentDataPath + "/settings.dat");
		if (File.Exists (Application.persistentDataPath + "/settings.dat") == true) {
			sw.loadSettings ();
			//will need to delete the settings.dat file if I add any more info to the settings class
		} else {
			sw.saveSettings ();
		}
		setVolumes ();
		// ls = GameObject.FindGameObjectWithTag("LoadScreen").GetComponent<LoadScreen>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (paused == false ) {
				paused = true;
				Time.timeScale = 0;
			} else if (paused == true ) {
				Time.timeScale = 1;
				paused = false;
				setVolumes ();
				sw.saveSettings ();


			}

		}
	}

	public void setVolumes()
	{
		AudioSource[] aus = FindObjectsOfType<AudioSource> ();

		foreach (AudioSource source in aus) {
			if (source.gameObject.GetComponent<MusicController>()==true) {
				source.volume = musicVal;
				Debug.LogError ("Setting Music Value");
			} else {
				source.volume = sfxVal;
				Debug.LogError ("Setting SFX Value");
			}
		}
	}



	void OnGUI()
	{
		GUI.depth = 2;
		scale.x = Screen.width / originalWidth;
		scale.y = Screen.height / originalHeight;
		scale.z = 1;
		var svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
		if (paused == true) {

			GUI.Box(new Rect ((originalWidth / 2)-500, (originalHeight / 2) - (500), 200 * 5, 200 * 5),"");
			GUI.Label (new Rect (originalWidth / 2-250, originalHeight / 2-150, 150, 50), "SFX Vol",text);
			sfxVal = GUI.HorizontalSlider (new Rect (originalWidth / 2 - 50, originalHeight / 2 - 150, 350, 50), sfxVal, 0.0f, 1.0f);
			GUI.Label (new Rect (originalWidth / 2-250, originalHeight / 2-100, 250, 50), "Music Vol",text);
			musicVal = GUI.HorizontalSlider (new Rect (originalWidth / 2 - 50, originalHeight / 2 - 100, 350, 50), musicVal, 0.0f, 1.0f);

            // Botones de menu

            if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 600, 500, 100), "Menu", menu))
            {
                SceneManager.LoadScene("Menu");
            }
						if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 750, 500, 100), "Guardar", menu))
            {
								Scene currentScene = SceneManager.GetActiveScene();
								string sceneName = currentScene.name;
                PlayerPrefs.SetString("nivel", sceneName);
								PlayerPrefs.SetInt("totalnoqueos", GameManager.totalNoqueosUnicos);
								PlayerPrefs.SetInt("arma1", GameManager.noquearPuño);
								PlayerPrefs.SetInt("arma2", GameManager.noquearBat);
								PlayerPrefs.SetInt("arma3", GameManager.noquearBowie);
								PlayerPrefs.SetInt("arma4", GameManager.noquearColt);
								PlayerPrefs.SetInt("arma5", GameManager.noquearMac10);
								PlayerPrefs.SetInt("arma6", GameManager.noquearMatute);
								PlayerPrefs.SetInt("arma7", GameManager.noquearSawnOff);
								PlayerPrefs.SetInt("arma8", GameManager.noquearThompson);
								PlayerPrefs.SetInt("arma9", GameManager.noquearWinchester);
								Debug.Log("The level is " + PlayerPrefs.GetString("nivel"));
								Debug.Log("El total de noqueos es " + PlayerPrefs.GetInt("totalnoqueos"));
								Debug.Log("noquear con puño: " + PlayerPrefs.GetInt("arma1"));
								Debug.Log("noquear con Bat: " + PlayerPrefs.GetInt("arma2"));
								Debug.Log("noquear con Bowie: " + PlayerPrefs.GetInt("arma3"));
								Debug.Log("noquear con Colt: " + PlayerPrefs.GetInt("arma4"));
								Debug.Log("noquear con Mac10: " + PlayerPrefs.GetInt("arma5"));
								Debug.Log("noquear con Matute: " + PlayerPrefs.GetInt("arma6"));
								Debug.Log("noquear con SawnOff: " + PlayerPrefs.GetInt("arma7"));
								Debug.Log("noquear con Thompson: " + PlayerPrefs.GetInt("arma8"));
								Debug.Log("noquear con Winchester: " + PlayerPrefs.GetInt("arma9"));
            }

            // Cierra botones de menu
        }

		GUI.matrix = svMat;
	}
}



class SettingsWriter
{
	string filePath = "/settings.dat";
	public void saveSettings()
	{

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath+ filePath);

		settingsData sd = new settingsData ();
		sd.musicVolume = PauseMenu.musicVal;
		sd.sfxVolume = PauseMenu.sfxVal;

		bf.Serialize (file, sd);
		Debug.Log ("Saving Settings Data");
		file.Close ();
	}

	public void loadSettings()
	{
		string filePath = "/settings.dat";
		if (File.Exists (Application.persistentDataPath + filePath)) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + filePath, FileMode.Open);
			settingsData sd = (settingsData)bf.Deserialize (file);
			Debug.Log ("Loading Settings Data");
			PauseMenu.sfxVal = sd.sfxVolume;
			PauseMenu.musicVal = sd.musicVolume;

			file.Close();
		} else {
			Debug.Log ("Settings Data Not Found, Creating New");
			saveSettings ();
			loadSettings ();
		}
	}
}


[Serializable]
class settingsData
{
	public float sfxVolume,musicVolume;
}

