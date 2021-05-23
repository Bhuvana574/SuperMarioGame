
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    Rigidbody2D playerRB;
    GameObject Maincam;
    public GameObject SecondCam;
    GameObject player;

    public float playerspeed;

    public float jumpVelocity;
    SpriteRenderer playerSprite;
    public GameObject FinishPanel;
   //public GameObject GameoverPanel;
     RepeatBackGround background;


    public static int s;
  

    bool Grounded;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        background = GameObject.Find("BackGround").GetComponent<RepeatBackGround>();
        //scoremanager = FindObjectOfType<Score>();

        //coin = FindObjectOfType<coins>();
    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        float playerdirection = Input.GetAxis("Horizontal");
        Debug.Log(playerdirection);
        //animator.SetTrigger("Idle");
        if (playerdirection < 0f)
        {
            // animator.SetTrigger("Idle");
            Moveplayer(movement);
            playerSprite.flipX = true;
            // animator.SetBool("Run", true);
            animator.SetTrigger("Run");
            background.xoffset = -0.25f;

        }

        else if (playerdirection > 0f)
        {
            Moveplayer(movement);
            playerSprite.flipX = false;
            //  animator.SetBool("Run", true);
            animator.SetTrigger("Run");
           background.xoffset = 0.25f;
        }

        if (playerdirection == 0f)
        {
            // animator.SetBool("Idle", true);
            animator.SetTrigger("Idle");
           //background.xoffset = 0;
            //  animator.SetTrigger("Idle");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded)
            {
                Jump();
                animator.SetTrigger("Jump");
                animator.SetTrigger("Idle");
                // SecondCam.SetActive(true);
                //player.transform.position = new Vector3(0, 0, 0);
            }

        }
       
    }
    private void Jump()
    {
        Grounded = false;
        playerRB.velocity = new Vector2(0, jumpVelocity);
    }
    private void Moveplayer(Vector3 movement)
    {
        transform.position += movement * Time.deltaTime * playerspeed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }


        if (collision.gameObject.tag == "Enemy")
        {
            animator.SetTrigger("Dead");
            SceneManager.LoadScene(2);

        }
        if (collision.gameObject.tag == "End")

        {
            Debug.Log("end");
            FinishPanel.SetActive(true);




        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coins")
        {

            Destroy(collision.gameObject);
            //scoremanager.IncrementScore();
        }
    }



}

