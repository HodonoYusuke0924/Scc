using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Use Unity's scene management program

public class MoveScene2 : MonoBehaviour
{
//Declare a no-argument function named change_button
public void change_button(){
	SceneManager.LoadScene("StartScene21"); //Calling Scene1 by using the SceneManager reader program
}
}