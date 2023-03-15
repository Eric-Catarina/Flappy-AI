using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);

        if (collider.tag != "flappy" && collider.tag != "pipe_goal")
        {
            Destroy(gameObject);

        }
        if(collider.tag == "pipe_goal")
        {
            
            Debug.Log("Pontos ++");
        }
    }

}
