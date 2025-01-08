// ############# Movement.cs
usingusingusingSystem.Data;
UnityEditor;
UnityEngine;
public class Movement : MonoBehaviour
{
Rigidbody2D rb;
bool isGrounded = true;
public float speed = 10f;
public float jumpheight = 100f;
public GameObject EndUI;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
rb = GetComponent<Rigidbody2D>();
Debug.Log("Start");
EndUI.SetActive(false);
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
void OnTriggerEnter2D(Collider2D other){
if(other.gameObject.tag == "Obstacle"){
Destroy(gameObject);
EndUI.SetActive(true);
}
}
}
// ################# Gamemanager.cs
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Overlays;
using TMPro;
public class Gamemanager : MonoBehaviour
{
int score =0;
int old_score =10;
string json;
SaveDataval obj = new SaveDataval();
public TextMeshProUGUI txt_old,txt_new;
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
txt_new.text = score.ToString();
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
txt_old.text = old_score.ToString();
}
class SaveDataval{
public int score;
}
// ################ UIManager.cs
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
// Start is called once before the first execution of Update after the MonoBehaviour is created
public void Restart(){
SceneManager.LoadScene(0);
}
public void Quit(){
Application.Quit();
UnityEditor.EditorApplication.isPlaying=false;
}
}
Coin.cs
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
