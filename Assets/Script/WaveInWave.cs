using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class WaveInWave
{
    public float time;
    [Header("ForAllSettings")]
    public bool activateAll;
    public bool lookAllAtPlayer;
    public float generalSpeedToAll;
    public bool turn;
    public bool stylishEffect;
    public float timeTurn;
    public bool useAnimationOnAll;
    public AnimationClip animation;
    [Header("1On2")]
    public bool activateHalf1On2;
    public bool lookHalf1On2AtPlayer;
    public float generalSpeedToHalf1On2;
    public bool useAnimationOnHalf1On2;
    public AnimationClip animation1On2;
    public TargetData[] targetData = new TargetData[20];
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
