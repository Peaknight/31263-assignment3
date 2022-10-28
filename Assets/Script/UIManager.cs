using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text score;
    private Text time;
    // GameObject[] edgeMoving;
   // public List<GameObject> edgeMoving;
    private Tweener tweener;
    public GameObject item;
    /*public GameObject upItem;
    public GameObject leftItem;
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

       /* edgeMoving = new List<GameObject>();
        edgeMoving.Add(upItem);
        edgeMoving.Add(leftItem);
        edgeMoving.Add(downItem);
        edgeMoving.Add(rightItem);*/


        StartCoroutine(BoldMoving());
        /*StartCoroutine(UpMoving());
        StartCoroutine(DownMoving());
        StartCoroutine(LeftMoving());       
        StartCoroutine(RightMoving());*/


    }
    public void LevelBtn()
    {
        StopAllCoroutines();
        gameObject.GetComponent<Tweener>().enabled = false;
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
        DontDestroyOnLoad(this.gameObject);
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


   
    /*IEnumerator UpMoving()
    {
        GameObject g0 = edgeMoving[0];
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Moving(g0, new Vector3(1400f, 0), 1f);
            yield return new WaitForSeconds(1f);

            Moving(g0, new Vector3(-1400f, 0), 1f);
            yield return new WaitForSeconds(1f);
        }
    } 
    IEnumerator DownMoving()
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
    }
    IEnumerator LeftMoving()
    {
        GameObject g1 = edgeMoving[1];
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Moving(g1, new Vector3(0, 320), 1f);
            yield return new WaitForSeconds(1f);

            Moving(g1, new Vector3(0, -320), 1f);
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator RightMoving()
    {
        GameObject g3 = edgeMoving[3];
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Moving(g3, new Vector3(0, -320), 1f);
            yield return new WaitForSeconds(1f);

            Moving(g3, new Vector3(0, 320), 1f);
            yield return new WaitForSeconds(1f);
        }
    }


    void Moving(GameObject item, Vector3 vector, float duration = 0.25f)
    {
        AddTweenToPosition(item, item.transform.position + vector, duration);
    }

    void AddTweenToPosition(GameObject item, Vector3 position, float duration)
    {
        tweener.AddTween(item.transform, item.transform.position, position, duration);
    }*/

}
