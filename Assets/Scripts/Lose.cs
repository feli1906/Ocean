using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] GameObject target;

  private void OnTriggerEnter(Collider other)
   {
       if (other.transform.tag == "Player")
       {
           other.transform.position = target.transform.position;
       }
   }
}
