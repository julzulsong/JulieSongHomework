using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2 : MonoBehaviour
{
    public int total;
    public GameObject[] spheres;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        spheres = new GameObject[total];
        Vector3 position = Vector3.zero;
        for (int i = 0; i < total; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            position.x = i * 4f;
            sphere.transform.position = position;
            spheres[i] = sphere;

        }
    }

    // Update is called once per frame
    void Update()
    {

        spheres[index].GetComponent<Renderer>().material.color(Random.value, Random.value, Random.value);
        index = (index + 3) % spheres.Length;
    }
}
