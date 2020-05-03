using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject obj;
    private int counter;

    public bool gameStop;
    public GameObject settingPanel;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        gameStop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStop == false)
        {
            int a;
            counter++;
            a = counter % 100;

            if (a == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    float randomX = Random.Range(-5f, 5f);
                    Instantiate(obj, new Vector3(randomX, 0.0f, 50.0f), Quaternion.identity);
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnSettingPanel();
        }
        
    }

    public void OnSettingPanel()
    {
        gameStop = true;
        settingPanel.SetActive(true);
   
    }
    public void OffSettingPanel()
    {
        gameStop = false;
        settingPanel.SetActive(false);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("Start");
    }
}
