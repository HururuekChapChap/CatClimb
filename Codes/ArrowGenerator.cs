using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{   

    public GameObject ArrowPrefab;
    float span = 0.5f;
    float delta = 0;
    int fire = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if(fire == 1 && delta > span){
            fire = 0;
            this.delta = 0;
            GameObject go = Instantiate(ArrowPrefab) as GameObject;

        }
        else if(fire == 0 && delta > span){
            delta = 0;
        }
    }

    public void Fire(){
        fire = 1;
    }
}
