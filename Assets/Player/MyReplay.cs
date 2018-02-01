using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class MyKeyFrame
{
    public MyKeyFrame(float t, Vector3 p, Quaternion r)
    {
        time = t;
        pos = p;
        rot = r;
    }

    public float time;
    public Vector3 pos;
    public Quaternion rot;

}
