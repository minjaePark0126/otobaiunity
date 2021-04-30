using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{ // 장애물 움직임
    public SpriteRenderer[] ground; // 장애물을 넣을 배열 선언
    //public Sprite[] groundImg;
    public float speed = 3.0f;
    SpriteRenderer temp;
    void Start()
    {
        temp = ground[0];
    }

    void Update()
    {
        // 장애물 반복 생성
        for(int i=0; i < ground.Length; i++)
        {
            if(ground[i].transform.position.x < -5)
            {
                for(int q=0;q < ground.Length; q++)
                {
                    if (temp.transform.position.x < ground[q].transform.position.x)
                        temp = ground[q];
                }
                // x좌표가 -5가 넘은 장애물을 제일 뒤로 보내줌, 제일 뒤로 보낸 타일의 Sprite를 Sprite의 배열중 하나로 바꿔줌
                //ground[i].transform.position = new Vector2(temp.transform.position.x + 1, -0.3f);
                //ground[i].sprite = groundImg[Random.Range(0, groundImg.Length)];
            }
        }
        for(int i=0; i<ground.Length; i++)
        {
            ground[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed); //왼쪽으로 이동
        }
    }
}
