using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_ : MonoBehaviour
{
   public void ChangeScenes(int sceneNumber)
   {
       SceneManager.LoadScene(sceneNumber);
   }

   public void Exit()
   {
       Application.Quit();
   }
}
