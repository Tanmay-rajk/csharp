using UnityEditor;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
Rigidbody2D rb;
public float speed=10.0f;
public float jumpHeight=20f;
void Start()
{
rb=GetComponent<Rigidbody2D>();
Debug.Log("Strart");
}
// Update is called once per frame
void Update()
{
float x=Input.GetAxisRaw("Horizontal");
if(x>0)
{
rb.velocity=new Vector2(speed*Time.deltaTime,rb.velocity.y);
}
else if(x<0)
{
rb.velocity=new Vector2(-speed*Time.deltaTime,rb.velocity.y);
}
else
{
if(Input.GetKeyDown(KeyCode.Space))
{
rb.velocity=new Vector2(rb.velocity.x,jumpHeight);
}
}
}
}
