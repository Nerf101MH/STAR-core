using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuGroup : MonoBehaviour
{
    public SaveObject so;


    public void PlayGame(string scene)
   {
        scene = "Assets/Scenes/GameBase.unity";
        SceneManager.LoadScene("GameBase");//sample scene is 2 on the index
   }
    public void ReportBug()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSdYi0FtZtnpq76GEI5_deuLjHJ9PPHNVg-168bor4B2zt0SMQ/viewform?usp=sf_link");
    }
    public void LoadGame(string scene)
    {
        scene = "Assets/Scenes/GameBase.unity";
        so = SaveManager.Load();
        UniverseGeneration.seed = so.worldSeed;
        UniverseGeneration.universeLength = so.limitX;
        UniverseGeneration.universeWidth = so.limitY;
        SceneManager.LoadScene("GameBase");
    }

   public void QuitGame()
   {
        if (Random.value <= 0.15)
        {
            Application.OpenURL("https://youtu.be/dQw4w9WgXcQ");
        }
        Application.Quit();
      Debug.Log("Game is exiting");
   }

    public void Settings(string scene)
    {
        scene = "Assets/Scenes/SettingScene.unity";
        SceneManager.LoadScene(scene);
    }

}