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

            //if (show) show = false;
            //else show = true;

            show = !show;
            GetComponent<Animator>().SetBool("Show", show);
        }
    }
}
