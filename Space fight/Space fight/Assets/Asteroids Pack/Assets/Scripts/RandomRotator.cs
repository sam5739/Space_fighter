using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;

    void Start()
    {
        //GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    private void Update()
    {
        transform.Translate(Vector3.back * 40 * Time.deltaTime);
        if (transform.position.z < -15)
            Destroy(this.gameObject);    
    }
}