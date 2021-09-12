using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
   public GameObject[] spheres;

   public void reset()
   {
      for (int i = 0; i < spheres.Length; i++)
         switch (i)
         {
            case 0:
               spheres[i].GetComponent<MoveScript1>().reset();
               break;

            case 1:
               spheres[i].GetComponent<MoveScript2>().reset();
               break;
            case 2:
               spheres[i].GetComponent<MoveScript3>().reset();
               break;
            case 3:
               spheres[i].GetComponent<MoveScript4>().reset();
               break;
            case 4:
               spheres[i].GetComponent<MoveScript5>().reset();
               break;
            default: break;
         }

   }
}
