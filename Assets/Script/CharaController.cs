using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharaController : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;
    public Vector3 moveInput;
    private PlayerControl playerControl;
    public Vector2 controlForV3;
    public bool held = false;

    // Start is called before the first frame update
    void Awake()
    {
        playerControl = new PlayerControl();
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        playerControl.Player.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        /*if (held)
        {
            
        }*/
        Debug.Log(controlForV3);
        
        
        
    }

    void Movement()
    {
        controlForV3 = playerControl.Player.Move.ReadValue<Vector2>();
        moveInput = new Vector3(controlForV3.x, 0, controlForV3.y);
        rb.velocity = moveInput * speed;
    }

    /*public void Move(InputAction.CallbackContext value)
    {

        controlForV3 = value.ReadValue<Vector2>();


        if (value.performed || value.started)
        {
            held = true;
            
        }
        else if (value.canceled)
        {
            held = false;
        }
            
        
    }*/
}
