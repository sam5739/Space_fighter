using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShoot : MonoBehaviour
{
    public float shootrate;
    private float shootrateTimestamp;
    //public 
    Ray ray;
    public GameObject shoot_prefab;
    public enemy_Generate eg;
    float range = 1000f;

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKey(KeyCode.S))
            shoot();
    }

    void shoot()
    {
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        GameObject laser = GameObject.Instantiate(shoot_prefab, transform.position, transform.rotation) as GameObject;
        ray.origin = transform.position;
        ray.direction = transform.forward;
        if (Physics.Raycast(ray, out hit, range))
        {
            if (hit.collider.tag == "UFO_Enemy")
            {
                laser.GetComponent<ShotBehavior>().setTarget(hit.point);
                Destroy(hit.collider.gameObject);
                eg.generateUfo();
            }

        }

        GameObject.Destroy(laser, 2f);
    }
}
