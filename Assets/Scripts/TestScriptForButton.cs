using UnityEngine;
using UnityEngine.UI;



public class TestScriptForButton : MonoBehaviour
{
    public Button yourButton;
    public Rigidbody rb;

    public float Forward = 500f;
    public float Side = 500f;
    public float Jump = 1000f;

    void Start()
    {
        


    }
    void TaskOnClick()
    {
        rb.AddForce(-Side * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
}
