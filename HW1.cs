using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{
    public int total;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = Vector3.zero;
        for(int i = 0; i < total; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            position.x = i * 4f;
            sphere.transform.position = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
