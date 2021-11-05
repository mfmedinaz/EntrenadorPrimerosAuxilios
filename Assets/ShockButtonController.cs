using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockButtonController : MonoBehaviour
{

    [SerializeField] public bool padsConnected = false;

    private void OnCollisionEnter(Collision collision)
    {
        SoundManagerScript.playSound();
    }


}
