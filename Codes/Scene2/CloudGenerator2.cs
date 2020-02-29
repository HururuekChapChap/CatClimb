using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator2 : MonoBehaviour
{   

    public GameObject CloudPrefeb;
    public GameObject flagPrefeb;
    private GameObject cloud;
    private GameObject item;
 
    double span = 1.0f;
    double delta = 0;
    float increase = 1.5f;
    float total = -3f;
    float temp_px=-3f;
    float temp_py=-3f;
    int cnt = 0;
    float lifeTime = 3.0f;
    
    void Start(){

        this.item = GameObject.Find("CloudManager");

    }


    // Update is called once per frame
    void Update()
    {    
        this.delta += Time.deltaTime;
      

        if(this.delta > this.span && cnt < 40){
       
        delta = 0;
        int px = Random.Range(-2,2);
        float py = Random.Range(total,total + increase);

        if(temp_px != px && temp_py != py){
        
        cloud = Instantiate(CloudPrefeb) as GameObject;
        cloud.transform.position = new Vector3(px,py,0);
        this.item.GetComponent<CloudManager2>().GetCloud(cloud);
        temp_px = px;
        temp_py = py;
        total += increase;
        cnt++;

        }

       // Destroy(cloud,lifeTime);

        if(cnt == 40){
            GameObject flag = Instantiate(flagPrefeb) as GameObject;
            flag.transform.position = new Vector3(px,py+0.8f,0);
        }

        }
    }
}
