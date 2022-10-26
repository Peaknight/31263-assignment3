using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitsButton : MonoBehaviour
{
    private GameObject ghostScaredTime;
    // Start is called before the first frame update
    void Start()
    {
        ghostScaredTime = GameObject.FindGameObjectWithTag("GhostScaredTime");
        ghostScaredTime.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackToStart()
    {
        SceneManager.LoadSceneAsync(0);
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
