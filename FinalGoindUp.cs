
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGoindUp : MonoBehaviour
{
    
    public int i = 0;
    public GameObject cube;
    public Material blue;
    
    public void Metod()
    {
        Debug.Log(2);
        if (i<500) {
             this.transform.Translate(0, 0, -0.01F);
            Invoke("Metod", 0.1F);
            i = i + 1 ;
    }
    }


    public void Colour()
    {
        cube.GetComponent<Renderer>().material = blue;
        
        
    }
}
