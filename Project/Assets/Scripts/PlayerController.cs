using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 range;
    private Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("swim", true);
            Vector2 moveinput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            range = moveinput * speed;
        }
        else
        {
            anim.SetBool("swim", false);
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + range * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //nie po tagach i stringach
        if (collision.tag == "Finish")
        {
            SceneManager.LoadScene(1);
        }
    }
}