using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour
{

    public void ChangeScene() {

        SceneManager.LoadScene("L1", LoadSceneMode.Single);
    }
}