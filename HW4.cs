using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW4 : MonoBehaviour
{
    private Vector3 targetPosition;
    public Vector3[] positions;
    private int index = 0;
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = positions[index];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        transform.position = newPosition;
        float sqDistance = (transform.position - targetPosition).sqrMagnitude;
        if(sqDistance < .05f){
            transform.position = targetPosition;
            targetPosition = positions[index];
            index++;
            index %= positions.Length;
        }
    }
}
