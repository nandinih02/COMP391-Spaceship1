using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed;
    public float minX, minY, maxX, maxY;
    public GameObject laser, laserSpawn;
    public float fireRate = 0.25f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        Vector2 newVelocity = new Vector2(horiz, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;
        //Debug.Log("H: "+horiz + ",V: " + vert);

        //Restrict Player on Screen
        float newX, newY;
        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY); 

        // Add laser fire codde
        //Check if the "Fire1" button is pressed
        if(Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            //if yes, spawn the laser
            //Instantiation: What is instantiated? Where? What is its rotation?
            GameObject gObj;
            gObj = GameObject.Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            gObj.transform.Rotate(new Vector3(0, 0, 90));

            // reset timer
            timer = 0;



        }

        timer += Time.deltaTime; //Timer = Time.deltaTime;


    }
}
