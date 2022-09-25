using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoving : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Animator animatorController;

    [SerializeField]
    private AudioSource audiosource;

    private Tweener tweener;
    private List<GameObject> itemList;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        StartCoroutine(AutoMoving85());
    }
    public void StartMove()
    {
        item.transform.rotation = Quaternion.identity;
        audiosource.Play();
    }
    IEnumerator AutoMoving85()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            MoveRight(new Vector3(6.5f, -0.5f, 0), 1.5f);
            yield return new WaitForSeconds(1.5f);

            MoveDown(new Vector3(6.5f, -4.5f, 0), 1.0f);
            yield return new WaitForSeconds(1f);

            MoveLeft(new Vector3(1.5f, -4.5f, 0), 1.5f);
            yield return new WaitForSeconds(1.5f);

            MoveUp(new Vector3(1.5f, -0.5f, 0), 1.0f);
        }
    }
    
    public void MoveLeft(Vector3 postion, float Duration)
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1.5f, -4.5f, 0), 1.5f);
        animatorController.SetFloat("DirX", -1.0f);
        animatorController.SetFloat("DirY", 0.0f);
    }
    public void MoveRight(Vector3 postion, float Duration)
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(6.5f, -0.5f, 0), 1.5f);
        animatorController.SetFloat("DirX", 1.0f);
        animatorController.SetFloat("DirY", 0.0f);
    }
    public void MoveUp(Vector3 postion, float Duration)
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1.5f, -0.5f, 0), 1.0f);
        animatorController.SetFloat("DirY", 1.0f);
        animatorController.SetFloat("DirX", 0.0f);
    }
    public void MoveDown(Vector3 postion, float Duration)
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(6.5f, -4.5f, 0), 1.0f);
        animatorController.SetFloat("DirY", -1.0f);
        animatorController.SetFloat("DirX", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(item.transform.position == new Vector3(1.5f, -0.5f, 0))
        {
            MoveRight();
        }
        else if (item.transform.position == new Vector3(12.5f, -0.5f, 0))
        {
            MoveDown();
        }
        else if (item.transform.position == new Vector3(12.5f, -4.5f, 0))
        {
            MoveLeft();
        }
        else if (item.transform.position == new Vector3(1.5f, -4.5f, 0))
        {
            MoveUp();
        }*/

    }
}
