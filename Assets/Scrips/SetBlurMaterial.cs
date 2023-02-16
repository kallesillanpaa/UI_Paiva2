using UnityEngine;
using UnityEngine.UI;

public class SetBlurMaterial : MonoBehaviour
{
    public Material blurMaterial; //raahaa t�h�n UI Blur -assetin materiaali
    
    void OnEnable()
    {
        GetComponent<Image>().material = blurMaterial;
    }

}
