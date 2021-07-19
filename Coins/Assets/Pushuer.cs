using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushuer : MonoBehaviour
{
    Vector3 PushuerPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        PushuerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed);
        transform.position = PushuerPosition + new Vector3(0, 0, z);
    }
}
