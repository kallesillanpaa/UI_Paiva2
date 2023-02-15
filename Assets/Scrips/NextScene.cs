using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    public string sceneName;

    AsyncOperation async;

    bool waitForLoad;
    float timer;
    float timerWait;

    void Start()
    {
        waitForLoad = false; //kun false, niin aloitetaan asynkroninen scenen lataus
        timerWait = 5.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            waitForLoad = true;
            async = SceneManager.LoadSceneAsync(sceneName); //starts loading the scene
                                                            //as background task
            async.allowSceneActivation = false;
        }

        if (waitForLoad == true)   //tai if(waitForLoad) 
        {
            timer += Time.deltaTime;
            //simuloidaan raskaan scenen latausta (joka kestäisi 5 sekuntia)
            //if (timer>=timerWait) //timerWait = 5 secs
            
            // tosielämässä näin:
            if(async.progress >= 0.9f) //kun sceneä on ladattu 90%
            {
                waitForLoad= false;
                async.allowSceneActivation= true;
            }
        }

    }
}
