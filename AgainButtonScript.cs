
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgainButtonScript : MonoBehaviour {

	public void OnClick()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}