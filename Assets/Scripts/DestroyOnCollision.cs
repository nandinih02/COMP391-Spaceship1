using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Create an explosion
        Instantiate(explosion, transform.position, transform.rotation);
        //Destroy Other game object
        Destroy(other.gameObject);
        //Destroy this game object
        Destroy(this.gameObject);
    }
}
