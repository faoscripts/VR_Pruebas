using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberGlow : MonoBehaviour
{
    LineRenderer lineRend;
    public Transform startPos;
    public Transform endPos;
    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //update line positions//
        lineRend.SetPosition(0, startPos.position);
        lineRend.SetPosition(1, endPos.position);
    }
}