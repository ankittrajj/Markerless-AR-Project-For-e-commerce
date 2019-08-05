using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Material[] bodyColorMat;
    Material currentMat;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void blueColor()
    {
        renderer.material = bodyColorMat[0];
        currentMat = renderer.material;
    }

         public void blackColor()
        {
        renderer.material = bodyColorMat[1];
        currentMat = renderer.material;
        }
        public void redColor()
        {
        renderer.material = bodyColorMat[2];
        currentMat = renderer.material;
        }
        public void yellowColor()
        {
        renderer.material = bodyColorMat[3];
        currentMat = renderer.material;
    }
    

}
