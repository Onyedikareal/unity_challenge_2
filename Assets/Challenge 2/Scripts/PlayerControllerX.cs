using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval = 1.0f;
    private float previousEventTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
            if (previousEventTime == 0.0 | Time.time - previousEventTime > timeInterval)
            {
                previousEventTime = Time.time;

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            }

        
        
    }
}
