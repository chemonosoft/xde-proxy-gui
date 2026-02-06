using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FbxRotate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 90, 0) * (Time.deltaTime) * 0.5f, Space.World);
    }        

}

