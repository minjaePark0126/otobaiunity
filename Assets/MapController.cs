using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour

{
    public float Speed = 3.0f;
    private void Update()
    {
      
        transform.Translate(-Speed * Time.deltaTime, 0, 0);//�� ���ǵ常ŭ -X������ �̵�
    }
}