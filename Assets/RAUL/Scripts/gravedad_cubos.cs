using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad_cubos : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider targetObj) 
    {
        if(targetObj.gameObject.tag == "sable_rojo")
        {
            Destroy(gameObject);
        }
        if(targetObj.gameObject.tag == "sable_azul")
        {
            Destroy(gameObject);
        }
    }
}
