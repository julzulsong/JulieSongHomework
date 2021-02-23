using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HW4_JUL : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;

    private Vector3 targetPosition;
    public Vector3[] targetPositions;
    private int index = 8;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        getTargetPosition();

        
    }

    // Update is called once per frame
    void Update()
    {
   

        Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        rb.MovePosition(newPosition);

        if((transform.position - targetPosition).sqrMagnitude < .05f){
            Debug.Log("Here!");
        

        }
        
    }

    void getTargetPosition(){
        targetPosition = targetPositions[index];
        targetPosition.y = transform.localScale.y / 2;
        index++;
        index %= targetPositions.Length;
    }
}
