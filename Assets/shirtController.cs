using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shirtController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Si sirve este log?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Entró colisión y el nombre es " + col.gameObject.name);

        if (col.gameObject.name == "Clamp_2")
        {
           Destroy(this.gameObject);
        }
    }
}
