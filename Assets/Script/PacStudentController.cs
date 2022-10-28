using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    [SerializeField]private GameObject PacStudent;
    private NewTweener tweener;
    private bool MoveLeft = false;
    private bool MoveRight = false;
    private bool MoveDown = false;
    private bool MoveUp = false;
    public int speed = 10;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private AudioSource audiosource;
    private KeyCode? lastInput;
    private KeyCode? currentInput;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<NewTweener>();
    }

    // Update is called once per frame
    void Update()
    {
         GetKeyLeft();
         GetKeyRight();
         GetKeyUp();
         GetKeyDown();
         GetKey();

    }
    public void StartMove()
    {
        PacStudent.transform.rotation = Quaternion.identity;
        audiosource.Play();
    }
    private void GetKeyLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft = true;
            MoveRight = false;
            MoveDown = false;
            MoveUp = false;

        }
        if (MoveLeft)
        {
            Vector3 RightDirection = PacStudent.transform.position + new Vector3(-1, 0, 0);
            tweener.AddTween(PacStudent.transform, PacStudent.transform.position, RightDirection, 0.25f);
            animator.SetFloat("DirX", -1.0f);
            animator.SetFloat("DirY", 0.0f);
            StartMove();
        }
        lastInput = KeyCode.A;
    }
    private void GetKeyRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight = true;
            MoveLeft = false;
            MoveDown = false;
            MoveUp = false;
            

        }
        if (MoveRight)
        {
            Vector3 LeftDirection = PacStudent.transform.position + new Vector3(1, 0, 0);
            tweener.AddTween(PacStudent.transform, PacStudent.transform.position, LeftDirection, 0.25f);
            animator.SetFloat("DirX", 1.0f);
            animator.SetFloat("DirY", 0.0f);
            StartMove();
        }
        lastInput = KeyCode.D;
    }
    private void GetKeyUp()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveLeft = false;
            MoveRight = false;
            MoveDown = false;
            MoveUp = true;

        }
        if (MoveUp)
        {
            Vector3 UpDirection = PacStudent.transform.position + new Vector3(0, 1, 0);
            tweener.AddTween(PacStudent.transform, PacStudent.transform.position, UpDirection, 0.25f);
            animator.SetFloat("DirY", 1.0f);
            animator.SetFloat("DirX", 0.0f);
            StartMove();
        }
        lastInput = KeyCode.W;
    }
    private void GetKeyDown()
    {
        if (Input.GetKey(KeyCode.S))
        {
            MoveRight = false;
            MoveLeft = false;
            MoveDown = true;
            MoveUp = false;

        }
        if (MoveDown)
        {
            Vector3 DownDirection = PacStudent.transform.position + new Vector3(0, -1, 0);
            tweener.AddTween(PacStudent.transform, PacStudent.transform.position, DownDirection, 0.25f);
            animator.SetFloat("DirY", -1.0f);
            animator.SetFloat("DirX", 0.0f);
            StartMove();
        }
        lastInput = KeyCode.S;
    }
    private void GetKey()
    {
        if (!tweener.TweenExists(PacStudent.transform) && lastInput != null)
        {
            if (lastInput == KeyCode.A)
            {
                if (MoveLeft)
                {
                    currentInput = lastInput;
                }
                else
                {
                    CurrentInput();
                }

            }
            else if (lastInput == KeyCode.D)
            {
                if (MoveRight)
                {
                    currentInput = lastInput;
                }
                else
                {
                    CurrentInput();
                }

            }
            else if (lastInput == KeyCode.W)
            {
                if (MoveUp)
                {
                    currentInput = lastInput;
                }
                else
                {
                    CurrentInput();
                }

            }
            else if (lastInput == KeyCode.S)
            {
                if (MoveDown)
                {
                    currentInput = lastInput;
                }
                else
                {
                    CurrentInput();
                }

            }
        }
        
    }
    private void CurrentInput()
    {
        if(currentInput != null)
        {
            if(currentInput == KeyCode.A)
            {
                GetKeyLeft();
                
            }else if (currentInput == KeyCode.D)
            {
               GetKeyRight();
            }
            else if (currentInput == KeyCode.W)
            {
                GetKeyUp();
            }
            else if (currentInput == KeyCode.S)
            {
                GetKeyDown();
            }
        }

    }
    /*private bool MovingLeft()
    {
        Vector3 RightDirection = PacStudent.transform.position + new Vector3(1, 0, 0);
        MoveToEndPos(RightDirection, 0.25f);
        //Vector3 LeftMove = Vector3.Lerp(PacStudent.transform.position, LeftDirection, 0.25f);
        return true;
    }
    private bool MovingRight()
    {
        Vector3 LeftDirection = PacStudent.transform.position + direction;
        MoveToEndPos(LeftDirection, 0.25f);
        return true;
    }*/
   

}
