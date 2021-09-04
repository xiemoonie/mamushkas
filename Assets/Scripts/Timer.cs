using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText;



    void Start()
    {
        StartCoroutine(reloadTimer(60));

    }


    IEnumerator reloadTimer(float reloadTimeInSeconds)
    {
        var counter = 0f;

        while (counter < reloadTimeInSeconds)
        {
            counter = counter + Time.deltaTime;
            timerText.text = counter.ToString();


            yield return null;
        }

        //Load new Scene
        SceneManager.LoadScene(0);
    }

}