using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirector : MonoBehaviour
{   
     public GameObject cat;
     private GameObject Arrow;
     private GameObject cloudList;
     int fire = 0;
     float delta = 0;
     float span = 1.0f;
     Vector3 pos;
    // Start is called before the first frame update
    
    void Start()
    {
        this.cat = GameObject.Find("cat");
        this.cloudList = GameObject.Find("CloudManager");
        pos = cat.transform.position;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.1f,0);
        
       int flag = this.cloudList.GetComponent<CloudManager2>().Inactivate(transform.position.x, transform.position.y);
        
        if(flag == 1){
            Destroy(gameObject);
        }

        if(transform.position.y>60){
            Destroy(gameObject);
        }

    }

}
