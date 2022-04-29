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
    
    
    public GameObject[] startPosition;
    public WaveInWave[] waveAttack;
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
        StartCoroutine(Attack1Wave1());
        Attack1Wave1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Attack1Wave1()
    {
        
        for (int i = 0; i < waveAttack.Length; i++)
        {
            WaitForSeconds wait = new WaitForSeconds(waveAttack[i].time);
            
            for (int t = 0; t < waveAttack[i].targetData.Length; t++)
            {
                if (waveAttack[i].targetData[t].activate == true)
                {
                    GameObject bulletInstance;
                    bulletInstance = Instantiate(bullet, startPosition[t].transform.position, startPosition[t].transform.rotation);
                    bulletRb = bulletInstance.gameObject.GetComponent<Rigidbody>();
                    bulletRb.velocity = startPosition[i].transform.TransformDirection(Vector3.forward * waveAttack[i].targetData[t].speed);
                }
            }
            yield return wait;
        }
    }

    void Attack2Wave1()
    {

    }

    void Attack3Wave1()
    {

    }

    
}
