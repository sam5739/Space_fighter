using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {
	public Vector3 s_target;
	public float speed;
	public GameObject collisionExplosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * Time.deltaTime * 500f);
		float step = speed * Time.deltaTime;
        if (s_target != null)
        {
            if (transform.position == s_target)
            {
				explode();
				return;
            }

        }
	}

	public void setTarget(Vector3 target)
    {
		s_target = target;
    } 

	void explode()
    {
        if (collisionExplosion != null)
        {
			GameObject explosion = (GameObject)Instantiate(collisionExplosion, transform.position, transform.rotation);
			Destroy(this.gameObject);
			Destroy(explosion, 1f);
			//Destroy(s_target);
        }
    }

}
