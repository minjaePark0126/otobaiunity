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
        Score.text = GameManager.score.ToString();//GameManager�� score�� �޾ƿ�
        
        if(GameManager.bestScore<GameManager.score)//���� GameManager�� bestScore�� ���� ���ھ�� ���ٸ�
        {
            GameManager.bestScore = GameManager.score;//���� ����
            newImage.SetActive(true);//new�̹��� ���
        }
        else
        {
            newImage.SetActive(false);//���� ���� �ȵ����� new�̹��� �� ���
        }
        BestScore.text = GameManager.bestScore.ToString();//BestScore�� GameManager�� ���ھ �޾ƿ�
    }
    //SampleScene�� �ҷ��ðŰ� ���� score�� 0���� ����Ŵ�
    //ùȭ�� �ε�, ���� �ʱ�ȭ
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
