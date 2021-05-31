using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{
    public TextMesh Score;
    public TextMesh BestScore;

    public GameObject newImage;
    private string text;

    public void OnEnable()
    {
        Score.text = GameManager.score.ToString();//GameManager의 score을 받아옴
        
        if(GameManager.bestScore<GameManager.score)//만약 GameManager의 bestScore가 현재 스코어보다 낮다면
        {
            GameManager.bestScore = GameManager.score;//점수 갱신
            newImage.SetActive(true);//new이미지 띄움
        }
        else
        {
            newImage.SetActive(false);//점수 갱신 안됐으면 new이미지 안 띄움
        }
        BestScore.text = GameManager.bestScore.ToString();//BestScore도 GameManager의 스코어를 받아옴
    }
    //SampleScene을 불러올거고 현재 score은 0으로 만들거다
    //첫화면 로드, 점수 초기화
    public void PlayBtn()
    {
        
        void OnMouseDown()
        {
            GameManager.score = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
