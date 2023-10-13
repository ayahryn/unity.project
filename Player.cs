using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private float _jump = 10f;
    public Text coincounter;
    public Transform groundcheck;
    public LayerMask ground;
    public Rigidbody rb;
    public int coincount = 0;

    // Start is called before the first frame update
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Jump();
        coincounter.text = "Coin:" + coincount;
    }
    private void Move()
    {

        transform.Translate(_speed *- Time.deltaTime * Input.GetAxis("Horizontal"), 0, _speed * Time.deltaTime *- Input.GetAxis("Vertical"));

    }
    private void Jump()
    { //space pressed = jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded())
        {
            rb.AddForce(new Vector3(0, _jump, 0));
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) ;
        {
            Destroy(other.gameObject);
            coincount++;
        }
    }
    public bool grounded()
    {
        return Physics.CheckSphere(groundcheck.position, .1f, ground);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}



