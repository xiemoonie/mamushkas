using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

  public void PlayGame(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       Debug.Log("PLAY");
        
  }

    public void SettingsGame(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
       Debug.Log("SETTING");
  }

  public void QuitGame(){
    Debug.Log("QUITTING");
    Application.Quit();
  }
  public void ExitBackToMainMenu(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    Debug.Log("BACKtoMENU");
    Application.Quit();
  }

}
