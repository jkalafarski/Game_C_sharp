using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoingUp : MonoBehaviour
{
    public bool aaa = true;
    public int i = 0;
    void Start()
    {

        this.transform.Translate(0, 0, 10);
    }


    void Update()
    {

        if (this.transform.position.z > -5.9F)
            this.transform.Translate(0, 0, -0.05F);

    }
    public void Metod()
    {
        Debug.Log(2);
        if (i < 500)
        {
            this.transform.Translate(0, 0, -0.01F);
            Invoke("Metod", 0.1F);
            i = i + 1;
        }
    }
}
