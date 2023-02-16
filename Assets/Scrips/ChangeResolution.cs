using UnityEngine;

public class ChangeResolution : MonoBehaviour
{
    public void SetResolution()
    {
        //klikatun gameobjectin nimen selvitt�minen:
        string goName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        // https://www.c-sharpcorner.com/article/c-sharp-switch-statement/ //switchin k�yt�st�
        switch (goName)
        {
            case "1":
                Screen.SetResolution(1920, 1080, false); //viimeinen on fullscreen (true/false),
                                                         //tutustu my�s muihin vaihtoehtoihin
                break; //t�rke� lis�t�, jotta toiminnallisuus s�ilyy
            case "2":
                Screen.SetResolution(1024, 768, false);
                break;
            case "3":
                Screen.SetResolution(2560, 1440, true);
                break;
            default: //defaultiin menn��n jos mik��n case ei toteudu
                Debug.Log("Joku muu kuin 1 2 tai 3");
                break;
                
        }
    
    }


}
