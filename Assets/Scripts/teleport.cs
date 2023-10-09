using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("1"))
        {
            transform.position = new Vector3(-38, 2, -128);
            AkSoundEngine.PostEvent("teleportsound", gameObject);
        }

    }
}
