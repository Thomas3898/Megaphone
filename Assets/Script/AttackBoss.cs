using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoss : MonoBehaviour
{
    [SerializeField]
    public Vector3 direction;

    public Vector3 position;
    public GameObject bullet;
    [SerializeField]
    [Header("Attack1")]
    public TargetData[] startData;
    public GameObject[] startPosition;
    [Header("Attack2")]
    public TargetData[] startPoint2;
    [Header("Attack3")]
    public TargetData[] startPoint3;
    public Rigidbody bulletRb;

    // Start is called before the first frame update
    private void Awake()
    {
       
        
    }
    void Start()
    {
        Attack1Wave1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack1Wave1()
    {
        for (int i = 0; i < startData.Length; i++)
        {
            if(startData[i].activate == true)
            {
                GameObject bulletInstance;
                bulletInstance = Instantiate(bullet, startPosition[i].transform.position, startPosition[i].transform.rotation);
                bulletRb = bulletInstance.gameObject.GetComponent<Rigidbody>();
                bulletRb.velocity = startPosition[i].transform.TransformDirection(Vector3.forward * startData[i].speed);
            }
        }
    }

    void Attack2Wave1()
    {

    }

    void Attack3Wave1()
    {

    }

    
}
