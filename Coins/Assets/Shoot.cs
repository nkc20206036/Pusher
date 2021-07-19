using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject medalPrefab;
    private float span = 1.0f;
    private float lefttime, righttime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lefttime += Time.deltaTime;
        righttime += Time.deltaTime;
    }

    public void LeftClick()
    {
        if (span < lefttime)
        {
            GameObject medal = Instantiate(medalPrefab, new Vector3(2.9f, 9.9f, 2.1f), Quaternion.Euler(90f, 110f, 0f));
            lefttime = 0;
        }
    }

    public void RightClick()
    {
        if (span < righttime)
        {
            GameObject medal = Instantiate(medalPrefab, new Vector3(-2.9f, 9.9f, 2.1f), Quaternion.Euler(90f, -110f, 0f));
            righttime = 0;
        }
    }

}
