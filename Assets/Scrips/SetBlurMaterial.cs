using UnityEngine;
using UnityEngine.UI;

public class SetBlurMaterial : MonoBehaviour
{
    public Material blurMaterial;
    
    void OnEnable()
    {
        GetComponent<Image>().material = blurMaterial;
    }

}
