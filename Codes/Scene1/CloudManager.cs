using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  CloudManager: MonoBehaviour
{   
    public List<GameObject> cloudList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GetCloud(GameObject temp){

        cloudList.Add(temp);

    }

    public int Inactivate(float x, float y){

        for(int i = 0; i< cloudList.Count; i++){

            float cloud_x = cloudList[i].transform.position.x;
            float cloud_y = cloudList[i].transform.position.y;

            if(x>= cloud_x - 0.7 && x<= cloud_x +0.7 && y>=cloud_y-0.2 && y<= cloud_y && i != cloudList.Count-1){
                Debug.Log("fired");
                cloudList[i].SetActive(false);
                return 1;
            }


        }

        return 0;
    }

}
