using UnityEngine;

public class ChangeResolution : MonoBehaviour
{
    public void SetResolution()
    {
        //klikatun gameobjectin nimen selvittäminen:
        string goName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        // https://www.c-sharpcorner.com/article/c-sharp-switch-statement/ //switchin käytöstä
        switch (goName)
        {
            case "1":
                Screen.SetResolution(1920, 1080, false); //viimeinen on fullscreen (true/false),
                                                         //tutustu myös muihin vaihtoehtoihin
                break; //tärkeä lisätä, jotta toiminnallisuus säilyy
            case "2":
                Screen.SetResolution(1024, 768, false);
                break;
            case "3":
                Screen.SetResolution(2560, 1440, true);
                break;
            default: //defaultiin mennään jos mikään case ei toteudu
                Debug.Log("Joku muu kuin 1 2 tai 3");
                break;
                
        }
    
    }


}
