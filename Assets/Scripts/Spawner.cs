using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject spawn;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;

    public GameObject prefab1;
    public float nextSpawn = 0;
    public int spawnNum = 0;
    public float spawnRate = 0;



    int whatToSpawn = 0;
    private AudioSource m_MyAudioSource;
    void OnEnable()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
    }

    void Update()
    {

        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            CreatesCaracterRandomly(whatToSpawn);

        }
        nextSpawn = spawnRate + 4f;
        /*

          for(int i=0; i<32;i++){
             if(i % 8 == 0){
               whatToSpawn = Random.Range(1,6);
               CreatesCaracterRandomly(whatToSpawn);
             }
          }   */

    }

    public void CreatesCaracterRandomly(int n)
    {

        prefab1 = ObjectPooler.SharedInstance.GetPooledObject();
        if (prefab1 != null)
        {
            switch (n)
            {
                case 1:
                    prefab1.transform.position = spawn.transform.position;
                    break;
                case 2:
                    prefab1.transform.position = spawn1.transform.position;
                    break;
                case 3:
                    prefab1.transform.position = spawn2.transform.position;
                    break;
                case 4:
                    prefab1.transform.position = spawn3.transform.position;
                    break;
                case 5:
                    prefab1.transform.position = spawn4.transform.position;
                    break;

            }
        }

        prefab1?.SetActive(true);


    }

}