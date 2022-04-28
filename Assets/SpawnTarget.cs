using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class SpawnTarget : MonoBehaviour
{
    public GameObject spawnableObject;
    private void Awake()
    {
        Debug.Log("please");
        float radius = 7f;
        for (int i = 0; i < 20; i++)
        {
            float angle = i * Mathf.PI * 2f / 20;
            Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 3.5f , Mathf.Sin(angle) * radius);
            GameObject go = Instantiate(spawnableObject, newPos, Quaternion.identity);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateTarget()
    {
        
    }
}
