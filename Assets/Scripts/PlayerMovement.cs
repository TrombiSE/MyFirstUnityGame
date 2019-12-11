using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float Forward = 500f;
    public float Side = 500f;
    public float Jump = 1000f;
    public float horizontal;
    private bool leftmove;
    private bool rightmove;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        leftmove = false;
        rightmove = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (leftmove)
        {
            rb.AddForce(-Side * Time.deltaTime, 0, 0);
        }
        if (rightmove)
        {
            rb.AddForce(Side * Time.deltaTime, 0, 0);
        }
        rb.AddForce(0, 0, Forward * Time.deltaTime);


        if (Input.GetKey("d")) 
        {
            rb.AddForce(Side * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Side * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Forward * Time.deltaTime);
        }

        if (Input.GetKey("space")){
            rb.AddForce(0, Jump * Time.deltaTime, 0);

        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<MyGameManager>().EndGame();
        }

    }
    public void leftpress()
    {
        leftmove = true;
        rightmove = false;
    }
    public void rightpress() 
    {
        leftmove = false;
        rightmove = true;
    }
    public void leftstop()
    {
        leftmove = false;
    }
    public void rightstop()
    {
        rightmove = false;
    }


}
