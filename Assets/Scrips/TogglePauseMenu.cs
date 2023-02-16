using UnityEngine;

public class TogglePauseMenu : MonoBehaviour
{

    public bool show;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //if (show) //sama kuin (show == true)       
            //{
            //    show = false;
            //}
            //else
            //{
            //    show = true;
            //}

            //sama hieman lyhyemmin
            //if (show) show = false;
            //else show = true;

            //vielä lyhyemmin:
            show = !show; //muutetaan (tässä boolean) vastakohtaiseksi arvoksi
            GetComponent<Animator>().SetBool("Show", show);
        }
    }
}
