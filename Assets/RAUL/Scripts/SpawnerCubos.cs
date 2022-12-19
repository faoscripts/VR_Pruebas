using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCubos : MonoBehaviour
{
    [SerializeField]
    GameObject[] cubos;
    [SerializeField]
    Transform[] puntos;

    public float beat = (60/105)*2;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            GameObject cubo = Instantiate(cubos[Random.Range(0,2)], puntos [Random.Range(0,4)]);
            cubo.transform.localPosition = Vector3.zero;
            cubo.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}
