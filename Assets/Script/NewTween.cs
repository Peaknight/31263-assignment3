using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTween {
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }


    public NewTween(Transform target, Vector3 origin, Vector3 destination, float startTime, float duration) {
        Target = target;
        StartPos = origin;
        EndPos = destination;
        StartTime = startTime;
        Duration = duration;
    }
}
