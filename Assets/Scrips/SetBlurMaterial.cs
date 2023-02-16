using UnityEngine;
using UnityEngine.UI;

public class SetBlurMaterial : MonoBehaviour
{
    public Material blurMaterial; //raahaa tähän UI Blur -assetin materiaali
    
    void OnEnable()
    {
        GetComponent<Image>().material = blurMaterial;
    }

}
