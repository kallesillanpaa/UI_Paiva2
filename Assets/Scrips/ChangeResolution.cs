using UnityEngine;

public class ChangeResolution : MonoBehaviour
{
    public void SetResolution()
    {
        string goName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
    
        switch(goName)
        {
            case "1":
                Screen.SetResolution(1920, 1080, false); //viimeinen on fullscreen (true/false)
                break;
            case "2":
                Screen.SetResolution(1024, 768, false);
                break;
            case "3":
                Screen.SetResolution(2560, 1440, true);
                break;
            default: //t‰nne menn‰‰n jos goName ei ollut 1, 2 tai 3
                Debug.Log("Joku muu kuin 1 2 tai 3");
                break;
                


        }
    
    }


}
