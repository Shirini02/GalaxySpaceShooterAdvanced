using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripleshotandpowerup : MonoBehaviour
{
    [SerializeField]
    private float trippleshotpowerup = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * trippleshotpowerup);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Collided with" + collision.name);
        //access the player and make tripleshot to true
        if(collision.tag=="Player")
        {
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            if (player != null)
            {
                player.trippleshotpowerup();
            }
            
            Destroy(this.gameObject);

        }
    }
}
