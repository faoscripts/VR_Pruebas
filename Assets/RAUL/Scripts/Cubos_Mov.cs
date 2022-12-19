using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos_Mov : MonoBehaviour
{
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Muro"))
        {
            Destroy(gameObject);
        }
    }
}
