using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour
{
   private bool isRed = true;
   public Material red;
   public Material blue;

   void OnMouseOver() {
    if (isRed == true)
    {
      GetComponent<Renderer>().material = blue;
      isRed = false;
    }
   }

   void OnMouseExit() {
    if (isRed == false)
    {
        GetComponent<Renderer>().material = red;
        isRed = true;
    }
   }
}


