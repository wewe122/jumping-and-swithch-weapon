using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover: MonoBehaviour {
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float speed = 3.5f;
    [SerializeField] float gravity = 9.81f;

    [SerializeField] float jumpforce = 6;
    
    //public bool isGround;
    private CharacterController cc;
    private float directionY;
    void Start() {
        cc = GetComponent<CharacterController>();

        //isGround = true;
    }

    Vector3 velocity;

    void Update()  {
        
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            velocity.x = x * speed;
            velocity.z = z * speed;
        
            
        
        
        if(cc.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            directionY = jumpforce;
        }

        directionY -= gravity*Time.deltaTime;
        velocity.y =directionY;
        // Move in the direction you look:
        velocity = transform.TransformDirection(velocity);

        cc.Move(velocity * Time.deltaTime);


        
    }


}
