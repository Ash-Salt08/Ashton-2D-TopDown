using UnityEngine;

public class myPlayerCpntroller : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If key "A" pressed
        if (Input.GetKey(KeyCode.A))
        {
            //move player left by "speed"
            rb.AddForce(Vector2.left * speed);

        }
        //If key "D" pressed
        if (Input.GetKey(KeyCode.D))
        {
            //move player right by "speed"
            rb.AddForce(Vector2.right * speed);

        }
        //If key "W" pressed
        if (Input.GetKey(KeyCode.W))
        {
            //move player up by "speed"
            rb.AddForce(Vector2.up * speed);
        }
        //IF key "S" pressed
        if (Input.GetKey(KeyCode.S))
        {
            //move player down by "speed"
            rb.AddForce(Vector2.down * speed);
        }


    }

    //Collision Detect
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coinPickup")
        {
            //Destroy objects
            Destroy(col.gameObject);

        }

    }
}
