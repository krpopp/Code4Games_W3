using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            currentPos.z++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPos.z--;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x++;
        }
        transform.position = currentPos; ;
    }
}
