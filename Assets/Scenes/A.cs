using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public static int flag = 0;
// Update is called once per frame
void Update()
    {
    Vector3 slimer = this.GetComponent<Transform>().position;
    if (slimer.x < 6f && flag == 0) { transform.Translate(-0.05f, 0, 0); }
    if (slimer.x <= -6f) { 
            flag =1;
            transform.Translate(0.05f, 0, 0);
        }
    if (slimer.x >= -6f && flag ==1) { transform.Translate(0.05f, 0, 0); }
    if (slimer.x > 6f ) { 
            flag = 0;
            transform.Translate(-0.05f, 0, 0);
        }
    }
}
