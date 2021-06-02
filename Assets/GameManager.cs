using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float waitingTime = 1.5f;
    public bool ready = true;
    public bool end = false;
    public GameObject Motorcycle;
    public AudioClip coinSound;
    private AudioSource audioSource;
    public TextMesh finishScoreText;
    public TextMesh bestScroeText;
    public Text scoreText;
    public GameObject finishWindow;
    public GameObject newImg;
    

    static public int score = 0;
    static public int bestScore = 0;

 
 
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip ac)
    {
        audioSource.clip = ac;
        audioSource.Play();
    }
    //���� ����ϴ¹�
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        if (end) return;
        //�������� �� ������ ����� �����!
        end = true;
        //CancelInvoke("MakeCactus");
        //iTween.ShakePosition(Camera.main.gameObject,
        //iTween.Hash("x", 0.2, "y", 0.2, "time", 0.5f));
        iTween.MoveTo(finishWindow, iTween.Hash("y", 1, "delay", 1.3f, "time", 0.5f));
        //����Ʈ ���ھ� vs ���� ���ھ �� ũ�� �ְ� ������ ����Ʈ ���ھ��� ������ ���ھ��� ������ �������ּ���
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
        {
            newImg.SetActive(false);
        }

        finishScoreText.text = score.ToString();
        bestScroeText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void GetScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
   
}
