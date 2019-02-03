using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour {

    


    public void ChangeScene(int nu)
    {
        
        switch (nu)
        {
            case 1:
                SceneManager.LoadScene("L1", LoadSceneMode.Single);
                break;
            case 2:
                SceneManager.LoadScene("L2", LoadSceneMode.Single);
                break;
            case 3:
                SceneManager.LoadScene("L3", LoadSceneMode.Single);
                break;
            case 4:
                SceneManager.LoadScene("L4", LoadSceneMode.Single);
                break;
            case 5:
                SceneManager.LoadScene("L5", LoadSceneMode.Single);
                break;
            case 6:
                SceneManager.LoadScene("L6", LoadSceneMode.Single);
                break;
            case 7:
                SceneManager.LoadScene("L7", LoadSceneMode.Single);
                break;
            case 8:
                SceneManager.LoadScene("L8", LoadSceneMode.Single);
                break;
            case 9:
                SceneManager.LoadScene("L9", LoadSceneMode.Single);
                break;
            case 10:
                SceneManager.LoadScene("L10", LoadSceneMode.Single);
                break;
            case 11:
                SceneManager.LoadScene("L11", LoadSceneMode.Single);
                break;
            case 12:
                SceneManager.LoadScene("L12", LoadSceneMode.Single);
                break;
            case 13:
                SceneManager.LoadScene("L13", LoadSceneMode.Single);
                break;
            case 14:
                SceneManager.LoadScene("L14", LoadSceneMode.Single);
                break;
            case 15:
                SceneManager.LoadScene("L15", LoadSceneMode.Single);
                break;
            case 16:
                SceneManager.LoadScene("L16", LoadSceneMode.Single);
                break;
            case 177:
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                break;
            case 200:
                SceneManager.LoadScene("Levels", LoadSceneMode.Single);
                break;
            default:
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                break;
        }


    }
}