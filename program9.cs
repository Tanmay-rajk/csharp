using UnityEngine;
using TMPro;
public class Gamemanager : MonoBehaviour
{
public TextMeshProUGUI txt;
int score=0;
// Start is called before the first frame update
void Start()
{
txt.text=score.ToString();
}
public void AddCoin(int val)
{
score=score+val;
Debug.Log(score);
txt.text=score.ToString();
}
}

#################

Step 1: Add Panel by Rightclick->UI
Step 2: Add two ButtonMesh Pro and set it in Game
Step 3: Name button as Quit and Restart
Step 4 : Edit Gamemanager script to display UI and handle button
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{//code for score
public TextMeshProUGUI txt;
int score=0;
// Start is called before the first frame update
void Start()
{
txt.text=score.ToString();
}
public void AddCoin(int val)
{
score=score+val;
Debug.Log(score);
txt.text=score.ToString();
}
//Code for button
public void Restart()
{
SceneManager.LoadScene(0);
}
public void Quit()
{
Application.Quit();
}
}
