using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   

    Rigidbody2D  rigid2D;
    Animator animator;
    public GameObject arrow;
    float jumpForce = 600.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    int cnt=2;
    int fire_cnt = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){

            if(this.rigid2D.velocity.y==0){
                cnt = 2;
            }

            if(cnt >0){
                this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up *  jumpForce);
            cnt--;
            }

        }

        int key = 0;

        if(Input.GetKey(KeyCode.RightArrow)) {
            key = 1;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            key = -1;
        }
        if(Input.GetKey(KeyCode.F) && fire_cnt == 1){
            fire_cnt--;
            this.arrow = GameObject.Find("ArrowGenerator");
            arrow.GetComponent<ArrowGenerator>().Fire();
        }

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed){
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(key != 0){
            transform.localScale = new Vector3(key,1,1);
        }

        if(this.rigid2D.velocity.y == 0){
            this.animator.speed = speedx/2.0f;
        }
        else{
            this.animator.speed = 1.0f;
        }

        if(transform.position.y <-10){
            GameObject hp = GameObject.Find("HpDirector");
            hp.GetComponent<HpDirector>().DecreaseHP();
             transform.position = new Vector3(0,-3,0);
        }

    }

    //골 
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("골");
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene("NextScene");
    }

}
