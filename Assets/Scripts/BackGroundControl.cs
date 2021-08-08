using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float Speed = 30f;
    // Update is called once per frame
    void Update()
    {
        foreach (Transform tran in transform)
        {
            Vector3 pos = tran.position;
            pos.x -= Speed * Time.deltaTime;
            if (pos.x < -37.8f)
            {
                pos.x += 37.8f * 2;
            }
            tran.position = pos;
        }
    }
}
