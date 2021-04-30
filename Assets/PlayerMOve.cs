using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOve : MonoBehaviour
{
    bool is_right = true;

    private void Start()
    {
        this.transform.position = new Vector2(-6, -3);
    }
    
   

    // Update is called once per frame
    private void Update()
    {
        if (is_right == true)
        {
            transform.Translate(new Vector2(3.0f * Time.deltaTime, 0));
                
        }
        else
        {
            transform.Translate(new Vector2(-3.0f * Time.deltaTime, 0));
        }
        if (transform.position.x < -4) is_right = false;
        if (transform.position.x < 4) is_right = true;
    }
}
