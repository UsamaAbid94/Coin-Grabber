using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController player; // This is player controller

    public float moveSpeed = 10f; //This is player speed


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.Move(Vector3.forward * moveSpeed * Time.deltaTime);  //this is player forward 

        if(Input.GetKey(KeyCode.RightArrow)) //This is condition for right arrow
        {
            //Player is moving right
            player.Move(Vector3.right * moveSpeed * Time.deltaTime);
           
        }
        else if(Input.GetKey(KeyCode.LeftArrow))//This is condition for left arrow
        {
            //Player is moving left
            player.Move(Vector3.left * moveSpeed * Time.deltaTime);
            
        }
    }
}
