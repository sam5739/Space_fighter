using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    float speed = 5.5f;
    public int health;
    public int MaxHealth;
    public GameObject deathPanel;

    public HealthBar hb;

    // Start is called before the first frame update    
    void Start()
    {
        health = MaxHealth;
        hb.setMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(new Vector3(Input.GetAxis("Horizontal")*3* Time.deltaTime, 0, 0));
        if (health == 0)
            death();
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health -= 2; //health=heath-2

        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 2; //health=heath-2
            hb.setHealth(health);

        }

        if (collision.gameObject.tag == "UFO_Enemy")
        {
            print("Shot");
            Destroy(this.gameObject);
        }
            
    }

    public void death()
    {
        
        deathPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
