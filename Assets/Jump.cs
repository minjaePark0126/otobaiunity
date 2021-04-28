using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    public float jumpPower;
    public int jumpCount = 2;
    //�߰��� ���� ���� ī��Ʈ
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        //���� ����
    }

   

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpCount < 2)
              //������ 2������ ���� if ������ �Է�
            {

         
            /*rb.velocity = new Vector3(0, 7, 0);*/
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
             jumpCount++;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ������ �ٴ�?�������� �ε����� ī��Ʈ �ʱ�ȭ?
        jumpCount = 0;
    }
}
