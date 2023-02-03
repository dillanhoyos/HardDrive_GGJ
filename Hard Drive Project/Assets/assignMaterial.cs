using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignMaterial : MonoBehaviour
{
   public Material SelectedMaterial;

   private Renderer [] children;



    void start()
    {
        children = this.GetComponentsInChildren<Renderer>();
        foreach(Renderer c in children)
        {
            c.material = SelectedMaterial;
        }
    }
}
  
