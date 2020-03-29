using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBodyToPlayer : MonoBehaviour
{

    public Transform lowerBody;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = lowerBody.position + new Vector3(0,35,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lowerBody.position + new Vector3(0, 35, 0);
    }
}
