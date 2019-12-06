using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float Forward = 300f;
    public float Side = 300f;
    public float Jump = 1000f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello WORld!");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
        rb.AddForce(0, 0, Forward * Time.deltaTime);

        }

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

    }
}
