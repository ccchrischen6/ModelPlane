using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMove : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * new Vector3(0, 0, 10000));
    }
}
