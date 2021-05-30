using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour {
   
    Rigidbody2D rb;
    public float speed;
    public float jumpPower;
    public int jumpCount = 3;
    //추가된 내용 점프 카운트

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        //시작 기준
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpCount < 3)
              //점프를 3번할지 말지 if 문으로 입력
            {
            /*rb.velocity = new Vector3(0, 7, 0);*/
            rb.AddForce(Vector2.up * jumpPower  , ForceMode2D.Impulse);
             jumpCount++;
            }
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        // 점프가 바닥?지형물에 부딪히면 카운트 초기화?
        jumpCount = 0;
    }
}
