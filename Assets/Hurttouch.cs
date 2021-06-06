using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurttouch : MonoBehaviour
{
    public bool end = false;
    public int score;
    public TextMesh finishScoreText;
    public GameObject finishWindow;
    public GameObject bestScoreText;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (end) return;
        //게임종료 시 실행할 명령은 여기로!
        end = true;
        iTween.ShakePosition(Camera.main.gameObject,
        iTween.Hash("x", 0.2, "y", 0.2, "time", 0.5f));
        //iTween.FadeTo(gameoverImg, iTween.Hash("alpha", 255, "delay", 1f, "time", 0.5f));
        iTween.MoveTo(finishWindow, iTween.Hash("y", 0.2, "delay", 1.3f, "time", 0.5f));
        //PlaySound(deathSound);
        //베스트 스코어 vs 현재 스코어가 더 크면 최고 점수는 베스트 스코어라는 점수의 스코어라는 점수를 저장해주세요
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            //newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
        {
            //newImg.SetActive(false);
        }

        finishScoreText.text = score.ToString();
        //bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

   



}
