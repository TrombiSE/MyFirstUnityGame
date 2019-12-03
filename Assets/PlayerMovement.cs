using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float Forward = 300f;
    public float Side = 300f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello WORld!");

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, Forward * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(Side * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Side * Time.deltaTime, 0, 0);
        }
    }
}
