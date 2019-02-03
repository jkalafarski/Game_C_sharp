using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{

    public void ChangeScene(string LevelName)
    {
        SceneManager.LoadScene(LevelName,LoadSceneMode.Single);

    }
}