// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Guantes : MonoBehaviour
// {
//     // Control de activación 
//     public bool activated = false;
//     public bool pTouched = false;
//     private Renderer rendererComp;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rendererComp = GetComponent<Renderer>();   
//     }


//     /** Este método sirve para detectar que se oprime el botón en VR
//     /*  Puede usarse con la mano virtual, en este caso se usa un collider en el dedo índice, 
//     /*  para detectar la colisión entre el botón y el dedo
//     **/
//     IEnumerator OnTriggerEnter(Collider other)
//     {
//         if (!pTouched && other.tag =="IndexFinger")
//         {
//             pTouched = true;
//             Touched();
//             yield return new WaitForSeconds(0.5f);    
//             pTouched = false;    
//         }
//     }

// }
