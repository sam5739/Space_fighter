using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Generate : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject ufo;
    int x_pos;
    int ufo_pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generate());
        for (int i = 0; i < 6; i++)
            generateUfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator generate()
    {
        while (true) {
            x_pos = Random.Range(-10, 10);
            yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(asteroid, new Vector3(x_pos, -0.5f, 50), Quaternion.identity);
        }
       
    }

    public void generateUfo()
    {
        ufo_pos = Random.Range(-15, 15);
        Instantiate(ufo, new Vector3(ufo_pos, 0, 17), Quaternion.identity);
    }
}
