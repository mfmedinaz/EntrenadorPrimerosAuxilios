using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeaObjectInteractable : MonoBehaviour
{
    public void HoverOver()
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");

    }

    public void HoverEnd()
    {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

}
