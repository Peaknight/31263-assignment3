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
    private Animator animator;

    [SerializeField]
    private AudioSource audiosource;

    private Tweener tweener;
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
            MoveRight();

            yield return new WaitForSeconds(1.5f);
            MoveDown();

            yield return new WaitForSeconds(1f);
            MoveLeft();

            yield return new WaitForSeconds(1.5f);
            MoveUp();
        }
    }
    
    public void MoveLeft()
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1.5f, -4.5f, 0), 1.5f);
        animator.SetFloat("DirX", -1.0f);
        animator.SetFloat("DirY", 0.0f);
    }
    public void MoveRight()
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(6.5f, -0.5f, 0), 1.5f);
        animator.SetFloat("DirX", 1.0f);
        animator.SetFloat("DirY", 0.0f);
    }
    public void MoveUp()
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(1.5f, -0.5f, 0), 1.0f);
        animator.SetFloat("DirY", 1.0f);
        animator.SetFloat("DirX", 0.0f);
    }
    public void MoveDown()
    {
        StartMove();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(6.5f, -4.5f, 0), 1.0f);
        animator.SetFloat("DirY", -1.0f);
        animator.SetFloat("DirX", 0.0f);
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
