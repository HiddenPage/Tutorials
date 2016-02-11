using UnityEngine;
using System.Collections;

public class SpawnOnButton : MonoBehaviour
{
    public GameObject bullet;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //when the user presses the fire button, Unity creates a bullet object
	if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
