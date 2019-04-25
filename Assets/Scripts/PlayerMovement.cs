using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform pos;

    public KeyCode rightKey, leftKey, upKey, downKey, jumpKey;

    public float speed, jumpSpeed;

    private bool isGrounded;
    private Vector3 jump;
    
    void Start()
    {
        jump = new Vector3(0, jumpSpeed, 0);
    }

    void FixedUpdate()
    {
        if(pos.position.y < -5)
        {
            if(gameObject.name == "Blue")
            {
                RedPoint();
            }

            if (gameObject.name == "Red")
            {
                BluePoint();
            }

            RestartLevel();
        }

        if (Input.GetKey(rightKey))
        {
            rb.velocity += new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            rb.velocity += new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey(upKey))
        {
            rb.velocity += new Vector3(0, 0, speed);
        }

        if (Input.GetKey(downKey))
        {
            rb.velocity += new Vector3(0, 0, -speed);
        }

        if (Input.GetKey(jumpKey) && isGrounded)
        {
            rb.AddForce(jump*2, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void RedPoint()
    {
        Score.red++;
    }

    void BluePoint()
    {
        Score.blue++;
    }
}
