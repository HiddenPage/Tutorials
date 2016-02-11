using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour
{
    //This sets a speed that can be changed in unity properties
    public float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //This moves an object left or right on input
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //transform.position += Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime;
    }
}
