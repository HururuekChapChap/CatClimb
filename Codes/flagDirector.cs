using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagDirector : MonoBehaviour
{   
    int Ismove = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(transform.position.x >2){
                Ismove = -1;
            }
        else if(transform.position.x<-2){
                Ismove= 1;
            }

            if(Ismove== 1){
            transform.Translate(0.01f,0,0);
            }
            else{
                transform.Translate(-0.01f,0,0);
            }

    }
}
