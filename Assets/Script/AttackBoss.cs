using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoss : MonoBehaviour
{
    [SerializeField]
    public Vector3 direction;
    public GameObject player;
    public Animation anim;
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
            Debug.Log(waveAttack[i].time);
          //ForALL  
            for (int t = 0; t < waveAttack[i].targetData.Length; t++)
            {
                if (waveAttack[i].activateAll == true)
                {
                    waveAttack[i].targetData[t].activate = true;

                }

                if (waveAttack[i].lookAllAtPlayer == true)
                {
                    waveAttack[i].targetData[t].lookAtPlayer = true;
                }

                if (waveAttack[i].generalSpeedToAll != 0f)
                {
                    waveAttack[i].targetData[t].speed = waveAttack[i].generalSpeedToAll;
                }

                if (waveAttack[i].useAnimationOnAll == true)
                {
                    waveAttack[i].targetData[t].useAnimation = true;

                    waveAttack[i].targetData[t].animation = waveAttack[i].animation;
                }

                    //ForHalf1On2
                    if (waveAttack[i].activateHalf1On2 == true)
                {
                    if(t % 2 == 0)
                    {
                        waveAttack[i].targetData[t].activate = true;
                    }
                    else
                    {
                        waveAttack[i].targetData[t].activate = false;
                    }

                    
                }

                    if (waveAttack[i].lookHalf1On2AtPlayer == true)
                    {
                        if (t % 2 == 0)
                        {
                            waveAttack[i].targetData[t].lookAtPlayer = true;
                        }
                    }

                if (waveAttack[i].generalSpeedToHalf1On2 != 0f)
                {
                    if (t % 2 == 0)
                    {
                        waveAttack[i].targetData[t].speed = waveAttack[i].generalSpeedToHalf1On2;
                    }
                    
                }

                if (waveAttack[i].useAnimationOnHalf1On2 == true)
                {
                    if (t % 2 == 0)
                    {
                        waveAttack[i].targetData[t].useAnimation = true;
                    }
                    else
                    {
                        waveAttack[i].targetData[t].useAnimation = false;
                    }
                    

                    waveAttack[i].targetData[t].animation = waveAttack[i].animation1On2;
                }


                if (waveAttack[i].targetData[t].activate == true)
                {
                    if (waveAttack[i].targetData[t].lookAtPlayer == true)
                    {
                        startPosition[t].transform.LookAt(player.transform.position);
                    }

                    

                    if (waveAttack[i].turn == true)
                    {
                        WaitForSeconds waitTurn = new WaitForSeconds(waveAttack[i].timeTurn);
                        Shoot(t, i);
                        yield return waitTurn;
                    }
                    else
                    {
                        Shoot(t, i);
                    }

                    //Shoot(t,i);
                    /*GameObject bulletInstance;
                    bulletInstance = Instantiate(bullet, startPosition[t].transform.position, startPosition[t].transform.rotation);
                    bulletRb = bulletInstance.gameObject.GetComponent<Rigidbody>();
                    bulletRb.velocity = startPosition[i].transform.TransformDirection((startPosition[t].transform.forward * -1) * waveAttack[i].targetData[t].speed);*/
                    
                }
            }
            yield return wait;
        }
    }

    void Shoot(int x, int y)
    {
        GameObject bulletInstance;
        bulletInstance = Instantiate(bullet, startPosition[x].transform.position, startPosition[x].transform.rotation);
        bulletRb = bulletInstance.gameObject.transform.GetComponent<Rigidbody>();
        bulletRb.velocity = startPosition[y].transform.TransformDirection((startPosition[x].transform.forward * -1) * waveAttack[y].targetData[x].speed);
        if (waveAttack[y].targetData[x].useAnimation == true)
        {
            anim = bulletInstance.gameObject.transform.GetChild(0).GetComponent<Animation>();
            anim.clip = waveAttack[y].targetData[x].animation;
            anim.Play();
        }
    }

    void Attack2Wave1()
    {

    }

    void Attack3Wave1()
    {

    }

    
}
