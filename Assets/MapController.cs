using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{ // ��ֹ� ������
    public SpriteRenderer[] ground; // ��ֹ��� ���� �迭 ����
    //public Sprite[] groundImg;
    public float speed = 3.0f;
    SpriteRenderer temp;
    void Start()
    {
        temp = ground[0];
    }

    void Update()
    {
        // ��ֹ� �ݺ� ����
        for(int i=0; i < ground.Length; i++)
        {
            if(ground[i].transform.position.x < -5)
            {
                for(int q=0;q < ground.Length; q++)
                {
                    if (temp.transform.position.x < ground[q].transform.position.x)
                        temp = ground[q];
                }
                // x��ǥ�� -5�� ���� ��ֹ��� ���� �ڷ� ������, ���� �ڷ� ���� Ÿ���� Sprite�� Sprite�� �迭�� �ϳ��� �ٲ���
                //ground[i].transform.position = new Vector2(temp.transform.position.x + 1, -0.3f);
                //ground[i].sprite = groundImg[Random.Range(0, groundImg.Length)];
            }
        }
        for(int i=0; i<ground.Length; i++)
        {
            ground[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed); //�������� �̵�
        }
    }
}
