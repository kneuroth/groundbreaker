using UnityEngine;

public class Player : MonoBehaviour
{

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    public GameObject Ground;
    public GameObject World;

    private Rigidbody2D rigidbody;
    private BoxCollider2D boxcolliderplayer;

    
    

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxcolliderplayer = GetComponent<BoxCollider2D>();
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
     
        
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        
        

    }
    
  

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        GameObject go = collision.gameObject;
        if (go.tag == "Ground")
        {
            if (Mathf.Abs(rigidbody.velocity.y) < 0.001f)
            {
                Destroy(go);
                rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
    }




    private void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            if (GameManager.instance.GroundCollected != 0)
            {
                Instantiate(Ground, new Vector3(worldPosition[0], worldPosition[1], 1), Quaternion.identity);
                GameManager.instance.DecreaseGround();
            }
        }


    }
}
