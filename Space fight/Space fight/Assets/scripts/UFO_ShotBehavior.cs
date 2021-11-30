using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_ShotBehavior : MonoBehaviour
{
    public float speed;
    public Vector3 s_target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    public void setTarget(Vector3 target)
    {
        s_target = target;
    }
}
