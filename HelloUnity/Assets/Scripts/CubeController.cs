using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
            
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.position);

        //this.transform.position = this.transform.position + new Vector3(1, 0, 0);

        this.transform.position += new Vector3(0, 0, 0.01f);

    }
}
