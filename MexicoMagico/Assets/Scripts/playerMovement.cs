using UnityEngine;

public class script : MonoBehaviour
{
    // Variables
    private Rigidbody2D body;
    [SerializeField]private float speed;

    //Methods
    private void Awake(){
        body= GetComponent<Rigidbody2D>();
    }

    private void Update(){
     body.velocity= new Vector2(Input.GetAxis("Horizontal")*speed,body.velocity.y);   //left & right

     if(Input.GetKey(KeyCode.Space))
        body.velocity= new Vector2(body.velocity.x, speed); // jump
    }
}
