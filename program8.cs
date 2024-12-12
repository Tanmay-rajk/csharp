using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class GameManager : MonoBehaviour
{
// Start is called before the first frame update
int score=0;
int old_score=0;
SaveDataval obj = new SaveDataval();
string json;
void Start()
{
LoadData();
}
public void AddCoin(int value)
{
score=score+value;
Debug.Log($"New score: {score}");
SaveGameData();
}
void SaveGameData()
{
obj.score = score;
//to create Json
json = JsonUtility.ToJson(obj);
Debug.Log(json);//to display json in log
File.WriteAllText(Application.dataPath + "MyJsonFile.json",
json);
Debug.Log(Application.dataPath.ToString());
}
void LoadData()
{
string json =
File.ReadAllText(Application.dataPath+"MyJsonFile.json");
obj = JsonUtility.FromJson<SaveDataval>(json);
old_score = obj.score;
Debug.Log($"Old score: {old_score}");
}
class SaveDataval
{
public int score;
}
}
