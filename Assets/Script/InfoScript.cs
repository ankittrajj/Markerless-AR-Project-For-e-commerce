using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    public  GameObject gb;
    public bool activeme;
    // Start is called before the first frame update
    void Start()
    {
       // GameObject.FindWithTag("Image");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (activeme==true)
            {
                gb.SetActive(true);
            }
            else
           {
               gb.SetActive(false);
           }
        }
        
            



        
        
    }
}
