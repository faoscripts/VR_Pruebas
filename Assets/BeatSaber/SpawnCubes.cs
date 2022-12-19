using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public float limiteVertical;
    public float limiteHorizontal;
    public GameObject[] cubos;
    public float cooldown;
    public float contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if(contador > cooldown){
            Instantiate(cubos[Random.Range(0,2)], new Vector3(transform.position.x + Random.Range(-limiteHorizontal, limiteHorizontal), 
                transform.position.y + Random.Range(-limiteVertical, limiteVertical), transform.position.z),Quaternion.identity);
            contador = 0;
        }
    }
}
