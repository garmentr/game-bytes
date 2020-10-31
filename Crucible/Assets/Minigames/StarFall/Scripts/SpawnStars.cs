using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{   
    public GameObject Star;
    public int spawnRate = 30;
    public float disappearTimer = 5f;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count / spawnRate == 0)
            {
                GameObject newStars = GameObject.Instantiate(Star);
                newStars.transform.position = new Vector3(Random.Range(-10f, 10f), 6f, 0f);
                Destroy(newStars, disappearTimer);
            }
        count = count + 1;
        
    }
}
