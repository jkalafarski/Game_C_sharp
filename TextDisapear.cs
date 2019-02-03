using UnityEngine.UI;
using UnityEngine;

public class TextDisapear : MonoBehaviour {

    public int timeToStart = 5;
    Text text;
    private bool erase = true;
    
	void Start() {
        text = GetComponent<Text>();
       // Invoke("Reduce", 1);
       // Invoke("Reduce", 2);
       // Invoke("Reduce", 3);
      //  Invoke("Reduce", 4);
       // Invoke("Reduce", 5);
        Invoke("Erase", 5);
    }
    private void Update()
    {
        if (erase) { }
        else
            text.text = "";


            }
    public void Reduce() { timeToStart--; }
    public void Erase() { erase = false; }
}
