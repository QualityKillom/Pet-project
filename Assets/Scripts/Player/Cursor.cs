using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
  
    void Start()
    {
        UnityEngine.Cursor.visible = false;
    }

  
    void Update()
    {
        
       transform.position = (UnityEngine.Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
}
