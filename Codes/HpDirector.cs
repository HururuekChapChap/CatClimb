using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpDirector : MonoBehaviour
{
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHP(){
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;

        if(this.hpGauge.GetComponent<Image>().fillAmount == 0){
             SceneManager.LoadScene("ClearScene");
        }
        
    }
    
}
