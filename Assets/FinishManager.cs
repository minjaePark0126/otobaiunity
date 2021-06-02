using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour

{

    public TextMesh finishScoreObj;            //Text ���� ����

    public TextMesh bestScoreObj;               //Text ���� ����



    int finishScore;                           //int ���� ����

    int bestScore;                              //int ���� ����

    /*int text;
    public GameObject newImg;
    public Text scoreText;
    static public int score = 0;*/

    
    void Start()

    {

        Debug.Log("++++++++++++++++++++");


        
        //HasKey�� ��Ʈ���� Ű���� ���� �����Ͱ� ��, ���� �����ϴ��� �˷���.

        if (PlayerPrefs.HasKey("finishScore"))

        {

            //int ���� GetInt�Լ� ����Ͽ� ������ �ҷ�����.

            finishScore = PlayerPrefs.GetInt("finishScore");    //Ű�� beforeSocre�� PlayerPrefs�� int�� ���� ����

            finishScoreObj.text = finishScore.ToString();

            Debug.Log("finishScore :: " + finishScore);

        }
        /*if (score > PlayerPrefs.GetInt("bestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        }
        else if (score <= PlayerPrefs.GetInt("BestScore"))
        {
            newImg.SetActive(false);
        }

       
    }
}*/

    
    //���ο� ���� �ǿ� ���� �� �ֱ�

    bestScore = Random.Range(1, 10);

        bestScoreObj.text = bestScore.ToString();

        Debug.Log("bestScore :: " + bestScore);



        PlayerPrefs.SetInt("finishScore", bestScore);  //highScore��� Ű���� newScore �� �����ϱ�.

        PlayerPrefs.Save();                                   //������ ������ �����ϱ�.

    }

}
/*public class FinishManager : MonoBehaviour
{
    public TextMesh Score;

    //public TextMesh BestScore;
    public TextMesh finishScoreText;
    public TextMesh bestScroeText;
    //public Text scoreText;

    public GameObject newImg;
    private string text;

    static public int score = 0;
    static public int bestScore = 0;

    /*public void PlayBtn()
    {

        void OnMouseDown()
        {
            GameManager.score = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Game()
    {
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
    /* public void OnEnable()
    {
        Score.text = Score.ToString();//score�� �޾ƿ�
        
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
    }*/
//SampleScene�� �ҷ��ðŰ� ���� score�� 0���� ����Ŵ�
//ùȭ�� �ε�, ���� �ʱ�ȭ


