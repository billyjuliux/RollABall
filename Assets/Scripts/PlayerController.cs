using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

	public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

	private Rigidbody rb;
    private int count;
	private float movementX, movementY;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
    	Vector2 movementVector = movementValue.Get<Vector2>();

    	movementX = movementVector.x;
    	movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count : " + count.ToString();

        if (count >= 8){
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
    	Vector3 movement = new Vector3(movementX, 0.0f , movementY);
    	rb.AddForce(movement * speed);
    }

    // OnTriggerEnter dipanggil ketika ada "collision" dengan game object lain
    // Collider other mereferensikan "other" sebagai nama object yang berkolisi dengannya
    private void OnTriggerEnter(Collider other)
    {
        // mendeteksi yang berkolisi itu yang ada tag "PickUp", jadi kalau nyentuh wall ga ngaruh
        if (other.gameObject.CompareTag("PickUp")){     
            other.gameObject.SetActive(false);          // disabling gameObject after collision with the ball
            count += 1;

            SetCountText();
        }
    }

}
