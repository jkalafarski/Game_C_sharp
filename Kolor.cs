
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kolor : MonoBehaviour {
    
    public GameObject cube;
    public Material rock;
    public Material red;


    void Start () {
        Invoke("Colour", 5);
    }

	void Update () {
		
	}
    public void Colour() {
        cube.GetComponent<Renderer>().material = rock;
        
    }
    public void RedBoxSteped()
    {
        cube.GetComponent<Renderer>().material = red;
        
        Invoke("Reload",2);
    }
    public void Reload() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
