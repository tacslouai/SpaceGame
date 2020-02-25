using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Vector3[] rocketPos;
    public int currPosIndex = 1;
    public float t = 0;
    public float moveSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * moveSpeed;
        transform.position = Vector3.Lerp(transform.position, rocketPos[currPosIndex], t);
    }
}
