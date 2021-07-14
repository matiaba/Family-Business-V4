using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class WinLevel : MonoBehaviour
{
    public GameObject menuGanar;
    public Button menu;
    public Button sigNivel;
    private string sceneName;
    public GameObject cartelWin;
    public GameObject Score;
    public Text curScore;
    public Text Calificar;

    int lastLevel;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        menuGanar.SetActive(false);
        menu.onClick.AddListener(cargarMenu);
        sigNivel.onClick.AddListener(siguienteNivel);
        Score.SetActive(false);

        switch (sceneName)
        {
            case "Menu":
                break;
            case "Tutorial":
                break;
            case "Credits":
                break;
            case "Controls":
                break;
            case "Level1":
                break;
            case "Level2":
                break;
            case "Level3":
                break;
            case "Level4":
                break;
            case "Level5":
                break;
            case "Level6":
                break;
            case "Level7":
                break;
            case "Level8":
                break;
            case "Level9":
                break;
            case "Level10":
                Calificar.text = "Calificar Juego";
                break;
        }

    }

    private void Update()
    {

        if (sceneName == "Level1")
        {
            if (GameManager.curScore >= GameManager.maxScore1)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore1)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore1 && GameManager.curScore <= (GameManager.minScore1 + GameManager.maxScore1) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore1 && GameManager.curScore >= (GameManager.minScore1 + GameManager.maxScore1) / 2){
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }

        }
        else if (sceneName == "Level2")
        {

            if (GameManager.curScore >= GameManager.maxScore2)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore2)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore2 && GameManager.curScore <= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore2 && GameManager.curScore >= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level3")
        {

            if (GameManager.curScore >= GameManager.maxScore3)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore3)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore3 && GameManager.curScore <= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore3 && GameManager.curScore >= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level4")
        {

            if (GameManager.curScore >= GameManager.maxScore4)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore4)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore4 && GameManager.curScore <= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore4 && GameManager.curScore >= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level5")
        {

            if (GameManager.curScore >= GameManager.maxScore5)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore5)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore5 && GameManager.curScore <= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore5 && GameManager.curScore >= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level6")
        {

            if (GameManager.curScore >= GameManager.maxScore6)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore6)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore6 && GameManager.curScore <= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore6 && GameManager.curScore >= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level7")
        {

            if (GameManager.curScore >= GameManager.maxScore7)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore7)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore7 && GameManager.curScore <= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore7 && GameManager.curScore >= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level8")
        {

            if (GameManager.curScore >= GameManager.maxScore8)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore8)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore8 && GameManager.curScore <= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore8 && GameManager.curScore >= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level9")
        {

            if (GameManager.curScore >= GameManager.maxScore9)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore9)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore9 && GameManager.curScore <= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore9 && GameManager.curScore >= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level10")
        {

            if (GameManager.curScore >= GameManager.maxScore10)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore10)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore10 && GameManager.curScore <= (GameManager.minScore10 + GameManager.maxScore10) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore10 && GameManager.curScore >= (GameManager.minScore10 + GameManager.maxScore10) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
    }


    void cargarMenu()
    {
        SceneManager.LoadScene("Menu");

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            menuGanar.SetActive(true);
            cartelWin.SetActive(false);
            Score.SetActive(true);
            GameManager.tiempoTotalNivel += Time.timeSinceLevelLoad;


            int level;
            if (sceneName == "Tutorial")
            {
                level = 0;
                if (PlayerPrefs.GetString("nivel").Contains("Level")){
                    lastLevel = int.Parse(PlayerPrefs.GetString("nivel").Substring(5));
                    if (lastLevel < level+1){
                        PlayerPrefs.SetString("nivel", "Level" + (level+1));
                    }
                }
                else{
                    PlayerPrefs.SetString("nivel", "Level" + (level+1));
                }

                PlayerPrefs.SetInt("arma1", GameManager.noquearPuño);
                PlayerPrefs.SetInt("arma2", GameManager.noquearBat);
                PlayerPrefs.SetInt("arma3", GameManager.noquearBowie);
                PlayerPrefs.SetInt("arma4", GameManager.noquearColt);
                PlayerPrefs.SetInt("arma5", GameManager.noquearMac10);
                PlayerPrefs.SetInt("arma6", GameManager.noquearMatute);
                PlayerPrefs.SetInt("arma7", GameManager.noquearSawnOff);
                PlayerPrefs.SetInt("arma8", GameManager.noquearThompson);
                PlayerPrefs.SetInt("arma9", GameManager.noquearWinchester);
                PlayerPrefs.SetInt("logro0", GameManager.logronivel0);
                PlayerPrefs.SetInt("logro1", GameManager.logronivel1);
                PlayerPrefs.SetInt("logro2", GameManager.logronivel2);
                PlayerPrefs.SetInt("logro3", GameManager.logronivel3);
                PlayerPrefs.SetInt("logro4", GameManager.logronivel4);
                PlayerPrefs.SetInt("logro5", GameManager.logronivel5);
                PlayerPrefs.SetInt("logro6", GameManager.logronivel6);
                PlayerPrefs.SetInt("logro7", GameManager.logronivel7);
                PlayerPrefs.SetInt("logro8", GameManager.logronivel8);
                PlayerPrefs.SetInt("logro9", GameManager.logronivel9);
                PlayerPrefs.SetInt("logro10", GameManager.logronivel10);
            }
            else
            {
                level = Utils.LevelFromSceneName(sceneName);
                lastLevel = int.Parse(PlayerPrefs.GetString("nivel").Substring(5));
                if (lastLevel < level+1){
                    if (level < 10){
                        PlayerPrefs.SetString("nivel", "Level" + (level+1));
                    }
                    else{
                        PlayerPrefs.SetString("nivel", "Level10");
                    }
                }
                PlayerPrefs.SetInt("arma1", GameManager.noquearPuño);
                PlayerPrefs.SetInt("arma2", GameManager.noquearBat);
                PlayerPrefs.SetInt("arma3", GameManager.noquearBowie);
                PlayerPrefs.SetInt("arma4", GameManager.noquearColt);
                PlayerPrefs.SetInt("arma5", GameManager.noquearMac10);
                PlayerPrefs.SetInt("arma6", GameManager.noquearMatute);
                PlayerPrefs.SetInt("arma7", GameManager.noquearSawnOff);
                PlayerPrefs.SetInt("arma8", GameManager.noquearThompson);
                PlayerPrefs.SetInt("arma9", GameManager.noquearWinchester);
                PlayerPrefs.SetInt("logro0", GameManager.logronivel0);
                PlayerPrefs.SetInt("logro1", GameManager.logronivel1);
                PlayerPrefs.SetInt("logro2", GameManager.logronivel2);
                PlayerPrefs.SetInt("logro3", GameManager.logronivel3);
                PlayerPrefs.SetInt("logro4", GameManager.logronivel4);
                PlayerPrefs.SetInt("logro5", GameManager.logronivel5);
                PlayerPrefs.SetInt("logro6", GameManager.logronivel6);
                PlayerPrefs.SetInt("logro7", GameManager.logronivel7);
                PlayerPrefs.SetInt("logro8", GameManager.logronivel8);
                PlayerPrefs.SetInt("logro9", GameManager.logronivel9);
                PlayerPrefs.SetInt("logro10", GameManager.logronivel10);
            }
            Debug.Log("EL ULTIMO NIVEL GUARDADO:" + lastLevel);
            Debug.Log("nivel de TerminarNivel es: " + level);
            Debug.Log("tiempo de TerminarNivel es: " + GameManager.tiempoTotalNivel);
            Debug.Log("tiempoultimoreintento de TerminarNivel es: " + Time.timeSinceLevelLoad);
            Debug.Log("puntos de TerminarNivel es: " + GameManager.curScore);
            Debug.Log("muertes de TerminarNivel es: " + GameManager.muertes);
            Debug.Log("Insertar evento de TerminarNivel");
            Debug.Log("The level is " + PlayerPrefs.GetString("nivel"));
            Debug.Log("noquear con puño: " + PlayerPrefs.GetInt("arma1"));
            Debug.Log("noquear con Bat: " + PlayerPrefs.GetInt("arma2"));
            Debug.Log("noquear con Bowie: " + PlayerPrefs.GetInt("arma3"));
            Debug.Log("noquear con Colt: " + PlayerPrefs.GetInt("arma4"));
            Debug.Log("noquear con Mac10: " + PlayerPrefs.GetInt("arma5"));
            Debug.Log("noquear con Matute: " + PlayerPrefs.GetInt("arma6"));
            Debug.Log("noquear con SawnOff: " + PlayerPrefs.GetInt("arma7"));
            Debug.Log("noquear con Thompson: " + PlayerPrefs.GetInt("arma8"));
            Debug.Log("noquear con Winchester: " + PlayerPrefs.GetInt("arma9"));
            Debug.Log("Logro de nivel 0: " + PlayerPrefs.GetInt("logro0"));
            Debug.Log("Logro de nivel 1: " + PlayerPrefs.GetInt("logro1"));
            Debug.Log("Logro de nivel 2: " + PlayerPrefs.GetInt("logro2"));
            Debug.Log("Logro de nivel 3: " + PlayerPrefs.GetInt("logro3"));
            Debug.Log("Logro de nivel 4: " + PlayerPrefs.GetInt("logro4"));
            Debug.Log("Logro de nivel 5: " + PlayerPrefs.GetInt("logro5"));
            Debug.Log("Logro de nivel 6: " + PlayerPrefs.GetInt("logro6"));
            Debug.Log("Logro de nivel 7: " + PlayerPrefs.GetInt("logro7"));
            Debug.Log("Logro de nivel 8: " + PlayerPrefs.GetInt("logro8"));
            Debug.Log("Logro de nivel 9: " + PlayerPrefs.GetInt("logro9"));
            Debug.Log("Logro de nivel 10: " + PlayerPrefs.GetInt("logro10"));

            Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
            {   { "nivel", level },
                { "tiempo", GameManager.tiempoTotalNivel },
                { "tiempoultimoreintento", Time.timeSinceLevelLoad },
                { "puntos", GameManager.curScore },
                { "muertes", GameManager.muertes }
            }
            );



        }
    }

    void siguienteNivel()
    {
        int level;

       if(sceneName == "Tutorial")
       {
            level = 0;
       }
       else
       {
            level = Utils.LevelFromSceneName(sceneName);

        }


        level++;
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", level }   }
        );
        Debug.Log("EmpezarNivel: " + level);

        SceneManager.LoadScene("Level"  + level);

        GameManager.tiempoTotalNivel = 0; //Resetea la variable a cero para el proximo nivel
        GameManager.muertes = 0; //Resetea la variable a cero para el proximo nivel
        //GameManager.curScore = 0; //Resetea la variable a cero para el proximo nivel

    }
}
