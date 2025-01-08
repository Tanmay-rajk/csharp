// ############ Movement.cs
usingusingusingSystem.Data;
UnityEditor;
UnityEngine;
public class Movement : MonoBehaviour
{
Rigidbody2D rb;
bool isGrounded = true;
public float speed = 10f;
public float jumpheight = 100f;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
rb = GetComponent<Rigidbody2D>();
}
// Update is called once per frame
void Update()
{
float x= Input.GetAxisRaw("Horizontal");
if(x>0){
rb.Velocity = new Vector2(speed*Time.deltaTime,rb.Velocity.y);
}
else if (x<0){
rb.Velocity = new Vector2(-speed*Time.deltaTime,rb.Velocity.y);
}
if(Input.GetKeyDown(KeyCode.Space)&&isGrounded){
rb.Velocity = new Vector2(rb.Velocity.x,jumpheight*Time.deltaTime);
}
}
}
// ############ Coin.cs
using UnityEngine;
public class Playercoin : MonoBehaviour
{
int score = 10;
Gamemanager gm;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
gm = FindAnyObjectByType<Gamemanager>();
}
// Update is called once per frame
void OnTriggerEnter2D(Collider2D other){
if(other.tag == "Player"){
gm.AddCoin(score);
Destroy(gameObject);
}
}
}
// ############## Gamemanger.cs
usingusingusingusingusingUnityEngine;
System.Collections;
System.Collections.Generic;
System.IO;
UnityEditor.Overlays;
public class Gamemanager : MonoBehaviour
{
int score =0;
int old_score =10;
string json;
SaveDataval obj = new SaveDataval();
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
LoadData();
}
// Update is called once per frame
public void AddCoin(int value){
score = score +value;
Debug.Log(score);
SaveGameData();
}
}
void SaveGameData(){
obj.score = score;
json = JsonUtility.ToJson(obj);
Debug.Log(json);
File.WriteAllText(Application.dataPath+"Myfile.json",json);
Debug.Log(Application.dataPath.ToString());
}
void LoadData(){
string json = File.ReadAllText(Application.dataPath+"Myfile.json");
obj = JsonUtility.FromJson<SaveDataval>(json);
Debug.Log(old_score);
}
class SaveDataval{
public int score;
}
