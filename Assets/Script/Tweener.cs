using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            if (Vector3.Distance(activeTween.Target1.transform.position, activeTween.EndPos1) > 0.1f)
            {
                float t = (Time.time - activeTween.StartTime1) / (activeTween.Duration1);
                activeTween.Target1.transform.position = Vector3.Lerp(activeTween.StartPos1, activeTween.EndPos1, t * t * t);
                Debug.Log((Time.time - activeTween.StartTime1) / (Time.time + activeTween.Duration1));
            }
            else if (Vector3.Distance(activeTween.Target1.transform.position, activeTween.EndPos1) <= 0.1f)
            {
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }


    }
    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
    }
}
