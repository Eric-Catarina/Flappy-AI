using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject pipes;

    private float spawnCooldown = 2f;
    private float maxYPosition = 6f;
    private float minYPosition = 0.75f;
    private float currentTime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= spawnCooldown)
        {
            currentTime = 0;
            spawnPipe();
        }
    }

    float spawnPipe()
    {
        float pipeRotation = Random.Range(0, 180f);
        
        float pipesYPosition = Random.Range(minYPosition, maxYPosition);
        Vector3 pipesPosition = new Vector3(10, pipesYPosition, 60.6f);
        GameObject currentPipes = Instantiate(pipes, pipesPosition, Quaternion.identity);
        currentPipes.transform.GetChild(0).transform.Rotate(0,0,pipeRotation);
        currentPipes.transform.GetChild(1).transform.Rotate(0,0,pipeRotation);
        
        return pipesYPosition;
    }
}
