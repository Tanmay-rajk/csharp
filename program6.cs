usingusingusingSystem.Data;
UnityEditor;
UnityEngine;
public class Movement : MonoBehaviour
{
Rigidbody2D rb;
bool isGrounded = true;
public float speed=10f;
public float jumpHeight=100f;
// Start is called before the first frame update
void Start()
{
rb=GetComponent<Rigidbody2D>();
}
// Update is called once per frame
void Update()
{
float x=Input.GetAxisRaw("Horizontal");
if(x>0)
{
rb.linearVelocity=new Vector2(speed*Time.deltaTime,rb.linearVelocity.y);
}
else if(x<0)
{
rb.linearVelocity=new Vector2(-speed*Time.deltaTime,rb.linearVelocity.y);
}
if(Input.GetKeyDown(KeyCode.Space)&&isGrounded)
{
rb.linearVelocity=new Vector2(rb.linearVelocity.x,jumpHeight*Time.deltaTime);
}
}
}
