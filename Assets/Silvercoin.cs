using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silvercoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 3;//3���� ����
        Destroy(gameObject);//������ �������!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//���ε����� Co�±� ��ŵ��
        {
            collision.gameObject.SetActive(false);
        }
    }
}
