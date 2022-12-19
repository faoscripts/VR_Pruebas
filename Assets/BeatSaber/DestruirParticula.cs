using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirParticula : MonoBehaviour
{
    private void Start() {
        Invoke("Destruir", 1f);
    }

    void Destruir(){
        Destroy(gameObject);
    }
}
