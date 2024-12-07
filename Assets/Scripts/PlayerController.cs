using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController playerController;

    [SerializeField]
    private float playerSpeed = 10f;

    private float horizontalMovement, verticalMovement;

    private void Awake()
    {
        playerController = GetComponent<CharacterController>();
    }

   
    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        Vector3 playerDirection = Vector3.right * playerSpeed * Time.deltaTime * horizontalMovement
            + Vector3.forward * playerSpeed * verticalMovement * Time.deltaTime;
       // playerDirection.Normalize();
        playerController.Move(playerDirection);
        if (playerDirection.magnitude != 0)
        {
            transform.rotation = Quaternion.LookRotation(playerDirection);
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
