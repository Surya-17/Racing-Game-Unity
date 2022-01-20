using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject EndScrn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            EndScrn.gameObject.SetActive(true);
         }
    }

    private void Awake()
    {
        EndScrn.gameObject.SetActive(false);
    }   
}
