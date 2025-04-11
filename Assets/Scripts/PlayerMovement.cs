using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forcafrontal = 0f;

    public float forcalateral = 0f;

    public PlayerMovement movement;

    bool canJump = true;
    public float jumpForce = 500;
    public int pulos = 3;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forcafrontal * Time.deltaTime); //Adiciona uma força no eixo z

        if(Input.GetKey("d")){
            rb.AddForce(forcalateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-forcalateral*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -5f)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().FimJogo();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    void jump()
    {
        if (canJump == true && pulos > 0)
        {
            canJump = false;
            rb.AddForce(this.gameObject.transform.up * jumpForce);
            pulos--;
        }
    }

    void OnCollisionEnter(Collision collidingObject)
    {
        if (collidingObject.gameObject.layer == 8)
        {
            canJump = true;
        }
    }
}
