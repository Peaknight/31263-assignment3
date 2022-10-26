using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text score;
    private Text time;
    private GameObject[] edgeMoving;
    private Tweener tweener;
    public GameObject item;
    /*public GameObject leftItem;
    public GameObject downItem;
    public GameObject rightItem;*/
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        time = GameObject.FindGameObjectWithTag("Time").GetComponent<Text>();
        string higherScore = PlayerPrefs.GetString("highScore", "0");
        string higherTime = PlayerPrefs.GetString("highTime", "00:00:00");

        if (higherScore != "0")
        {
            score.text = higherScore;
        }

        if (higherTime != "00:00:00")
        {
            time.text = higherTime;
        }

        /*edgeMoving = new GameObject[4];
        edgeMoving[0] = upItem;
        edgeMoving[1] = leftItem;
        edgeMoving[2] = downItem;
        edgeMoving[3] = rightItem;*/
 

        StartCoroutine(BoldMoving());
        //StartCoroutine(DownMoving());

       
    }
    public void LevelBtn()
    {
        StopAllCoroutines();
        SceneManager.LoadSceneAsync(1);
    }

    public void Level2Btn()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
       /* StartCoroutine(LeftMoving());
        
        StartCoroutine(RightMoving());*/
        
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    IEnumerator BoldMoving()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);

            MoveRight();
            yield return new WaitForSeconds(1.5f);

            MoveDown();
            yield return new WaitForSeconds(1.5f);

            MoveLeft();
            yield return new WaitForSeconds(1.5f);

            MoveUp();
        }
    }
    /*IEnumerator DownMoving()
    {
        GameObject g2 = edgeMoving[2];
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Moving(g2, new Vector3(-1400f, 0), 1f);
            yield return new WaitForSeconds(1f);

            Moving(g2, new Vector3(1400f, 0), 1f);
            yield return new WaitForSeconds(1f);
        }
    }*/
    public void MoveLeft()
    {
  
        tweener.AddTween(item.transform, item.transform.position, new Vector3(270f, 220f, 0), 1.5f);
    }
    public void MoveRight()
    {
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1650f, 860f, 0), 1.5f);

    }
    public void MoveUp()
    {
        tweener.AddTween(item.transform, item.transform.position, new Vector3(270f, 860f, 0), 1.0f);

    }
    public void MoveDown()
    {
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1650f, 220f, 0), 1.0f);

    }

}
