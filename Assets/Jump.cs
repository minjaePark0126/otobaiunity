using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    public float jumpPower;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

   

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*rb.velocity = new Vector3(0, 7, 0);*/
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

    }
}
