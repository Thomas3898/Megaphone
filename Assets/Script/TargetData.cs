using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TargetData
{
    [SerializeField]
    public Vector3 Direction;
    
    [SerializeField]
    public bool activate = false;
    [SerializeField]
    public float speed = 1.0f;
    [SerializeField]
    public bool lookAtPlayer = false;
    public bool useAnimation;
    public AnimationClip animation;


    // Start is called before the first frame update

}

public class Target : MonoBehaviour
{
    public GameObject beginPoint;
}
