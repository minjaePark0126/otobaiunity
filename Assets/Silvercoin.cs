using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silvercoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Score.coinAmount += 3;//3점씩 증가
        Destroy(gameObject);//동전아 사라져랏!
        Sound.SoundPlay();

        if (collision.gameObject.tag == "Co")//코인들한테 Co태그 줬거든요
        {
            collision.gameObject.SetActive(false);
        }
    }
}
