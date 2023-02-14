using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 5f;

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
            //currentPos.z++;
            currentPos.z = currentPos.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPos.z = currentPos.z - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x = currentPos.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x = currentPos.x + speed * Time.deltaTime;
        }
        transform.position = currentPos;
    }

    //int AddSomeNumbers(int a, int b)
    //{
    //    int sum = a + b;
    //    return sum;
    //}
}
