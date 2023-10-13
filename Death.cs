using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<=-3f)
        {
            Die();

        }
       
    }
    private void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Player>().enabled = false;
        Invoke(nameof(Restart), 2f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy_Body"))
        {
            Die();
        }
    }

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("Enemy_Head"))
            {
                Destroy(collision.gameObject.transform.parent.gameObject);
                rb.AddForce(new Vector3(0, 5f, 0));
        }
        }
   
        
           
        

    
}

    

    