using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCubo : MonoBehaviour
{
    [SerializeField]
    bool cuboRojo;
    [SerializeField]
    float speed;
    [SerializeField]
    public GameObject particulaDestruir;
    GameObject particulaCreada;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Muro")){
            Destruir();
        }

        if(other.gameObject.CompareTag("SableRojo") && cuboRojo){
            Destruir();
        }

        if(other.gameObject.CompareTag("SableAzul") && !cuboRojo){
            Destruir();
        }
    }
    
    void Destruir(){
            particulaCreada = Instantiate(particulaDestruir, transform.position, Quaternion.identity);
            Destroy(gameObject);
    }
}
