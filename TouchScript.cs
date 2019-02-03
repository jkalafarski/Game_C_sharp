using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TouchScript : MonoBehaviour {
	private Touch initialTouch = new Touch();
	private float distance = 0;
	public float timeLeft = 5;
	public bool alive = true;
	private bool hasSwiped = false;
	GameObject CubeRed1,CubeRed2,CubeRed3;
	ColorChangeing cubeRed1Script,cubeRed2Script,cubeRed3Script;

	void Start(){
		//wystarczy jeden tag i ten sam skrypt do zmiany koloru dla wszystkich cube.
		CubeRed1 = GameObject.FindGameObjectWithTag ("Red1");
		CubeRed2 = GameObject.FindGameObjectWithTag ("Red2");
		CubeRed3 = GameObject.FindGameObjectWithTag ("Red3");
		cubeRed1Script = CubeRed1.GetComponent<ColorChangeing>();
		cubeRed2Script = CubeRed2.GetComponent<ColorChangeing>();
		cubeRed3Script = CubeRed3.GetComponent<ColorChangeing>();
	}	



	void FixedUpdate()
	{
		if (alive) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < -1)
				foreach (Touch t in Input.touches) {
					if (t.phase == TouchPhase.Began) {
						initialTouch = t;
					} else if (t.phase == TouchPhase.Moved && !hasSwiped) {
						float deltaX = initialTouch.position.x - t.position.x;
						//Debug.Log(deltaX);
						//Debug.Log(message:deltaX);
						float deltaY = initialTouch.position.y - t.position.y;
						//Debug.Log (deltaY);
						//Debug.Log(message:deltaY);
						distance = Mathf.Sqrt ((deltaX * deltaX) + (deltaY * deltaY));
						//Debug.Log(distance);
						//Debug.Log(message:distance);
						bool swipedSideways = Mathf.Abs (deltaX) > Mathf.Abs (deltaY);
						//Debug.Log (swipedSideways);
				
						if (distance > 10f) {
							if (swipedSideways && deltaX > 0) { //swiped left
								if (transform.position.x > -7) {
									this.transform.Translate (-4, 0, 0);
								}//this.transform.Rotate(new Vector3(0, -50f, 0));
							} else if (swipedSideways && deltaX <= 0) { //swiped right
								if (transform.position.x < 9) {
									this.transform.Translate (4, 0, 0);
								}
							} else if (!swipedSideways && deltaY > 0) { //swiped down
								if (transform.position.y > -8) {
									this.transform.Translate (0, -4, 0);
								}//this.transform.Rotate(new Vector3(5, 180f, 0));
							} else if (!swipedSideways && deltaY <= 0) {  //swiped up
								if (transform.position.y < 8) {
									this.transform.Translate (0, 4, 0);
								}//this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, 0, this.GetComponent<Rigidbody>().velocity.z);
								//this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100f, 0));
							}

							hasSwiped = true;
						}


					} else if (t.phase == TouchPhase.Ended) {
						initialTouch = new Touch ();
						hasSwiped = false;
					}
				}
			if (transform.position.x == -3 && transform.position.y == 0 ||
				transform.position.x == 9 && transform.position.y == 0  ||
				transform.position.x == 5 && transform.position.y == -4)
				 {

				cubeRed1Script.RedBoxStepped ();
				cubeRed2Script.RedBoxStepped ();
				cubeRed3Script.RedBoxStepped ();

				alive = false;

				Invoke ("next", 5);
	
			} else if (transform.position.x == -3 && transform.position.y == 0) {
				SceneManager.LoadScene ("Level6", LoadSceneMode.Single);
			
			}
		}
	}
	void next()
    {
		SceneManager.LoadScene ("Level2", LoadSceneMode.Single);
	}
}

