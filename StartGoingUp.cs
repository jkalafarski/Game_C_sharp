using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGoingUp : MonoBehaviour {

	 
	void Start () {
        this.transform.Translate(0, 0, 9.9F);
    }

    void Update() {
        if (this.transform.position.z > 0)
            this.transform.Translate(0, 0,-0.05F);
    }
}
