using UnityEngine;
public class Gamemanager : MonoBehaviour
{
int score=0;
public void AddCoin(int val)
{
score=score+val;
Debug.Log(score);
}
}

############
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class coin : MonoBehaviour
{
Gamemanager gm;
int score=10;
void Start()
{
gm=FindObjectOfType<Gamemanager>();
}
void OnTriggerEnter2D(Collider2D other)
{
if(other.tag=="Player")
{
gm.AddCoin(score);
Destroy(gameObject);
}
}
}
