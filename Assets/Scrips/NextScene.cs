using UnityEngine;
using UnityEngine.SceneManagement; //pit‰‰ olla, jotta SceneManager lˆytyy


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
        if (Input.GetKeyDown(KeyCode.Space)) //kun spacea painetaan, aletaan lataamaan scene‰, mutta sit‰ ei viel‰ n‰ytet‰
        {
            waitForLoad = true;
            async = SceneManager.LoadSceneAsync(sceneName); //skene‰ aletaan lataamaan taustalla
                                                            
            async.allowSceneActivation = false; //ei n‰ytet‰ skene‰ viel‰
        }

        if (waitForLoad == true)   //tai if(waitForLoad) 
        {
            timer += Time.deltaTime;
            //simuloidaan raskaan scenen latausta (joka kest‰isi 5 sekuntia)
            if (timer>=timerWait) //timerWait = 5 secs
            
            // todellisuudessa n‰in:
            //if(async.progress >= 0.9f) //kun scene‰ on ladattu 90%
            {
                waitForLoad= false;
                async.allowSceneActivation= true; //skene n‰ytet‰‰n
            }
        }

    }
}
