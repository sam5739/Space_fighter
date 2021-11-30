using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Shoot : MonoBehaviour
{
    //public int waitTime;
    public GameObject prefab;
    float range = 100f;
    RaycastHit hit;
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shooting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private IEnumerator shooting()
    {
        while (true)
        {
            GameObject laser = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            ray.origin = transform.position;
            ray.direction = transform.forward;
            if (Physics.Raycast(ray, out hit, range))
            {
                print(hit.collider.name);
                //laser.GetComponent<UFO_ShotBehavior>().setTarget(hit.point);
                if (hit.collider.tag == "Player")
                {
                    Destroy(hit.collider.gameObject);
                }

            }
            GameObject.Destroy(laser, 2f);
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }
}
