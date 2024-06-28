using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int nivelHambre; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario; 
        if (nivelHambre <= 0)
        {
            nivelHambre = 0; 
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            TomarAlimento(alimento.valorAlimentario);
            Destroy(other.gameObject); 
        }
    }
}
