using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; set; }
    public Vector3 StartPos { get; set; }
    public Vector3 EndPos { get; set; }
    public float StartTime { get; set; }
    public float Duration { get; set; }



    public Tween(Transform Target1, Vector3 StartPos1, Vector3 EndPos1, float StartTime1, float Duration1)
    {
        this.Target = Target1;
        this.StartPos = StartPos1;
        this.EndPos = EndPos1;
        this.StartTime = StartTime1;
        this.Duration = Duration1;
    }
    public Transform Target1 { get => Target; private set => Target = value; }
    public Vector3 StartPos1 { get => StartPos; private set => StartPos = value; }
    public Vector3 EndPos1 { get => EndPos; private set => EndPos = value; }
    public float StartTime1 { get => StartTime; private set => StartTime = value; }
    public float Duration1 { get => Duration; private set => Duration = value; }
}
