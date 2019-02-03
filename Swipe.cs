using UnityEngine.SceneManagement;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    GameObject LeftTop, RightTop, LeftBottom, RightBottom, Up;
    GameObject[] CubeRed;
    ColorChangeing s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;

    public float timeLeft = 5;
    public bool alive = true;
    //Var that carries bounds of moveArea
    public float xL, xR, yT, yB, movementScale = 4f;
    void Start() { Begin(); }
    void Begin()
    {
        dragDistance = Screen.height * 6 / 100; //dragDistance is 15% height of the screen

        CubeRed = GameObject.FindGameObjectsWithTag("Red");

        LeftTop = GameObject.FindGameObjectWithTag("LeftTop");
        RightBottom = GameObject.FindGameObjectWithTag("RightBottom");
        Up = GameObject.FindGameObjectWithTag("Up");

        xL = LeftTop.transform.position.x;
        xR = RightBottom.transform.position.x;
        yT = RightBottom.transform.position.y;
        yB = LeftTop.transform.position.y;
                Debug.Log(xL);
                Debug.Log(xR);
                Debug.Log(yT);
                Debug.Log(yB);
    }

    void Update()
    {
        if (alive)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
                if (Input.touchCount == 1) // user is touching the screen with a single touch
                {
                    Touch touch = Input.GetTouch(0); // get the touch
                    if (touch.phase == TouchPhase.Began) //check for the first touch
                    {
                        fp = touch.position;
                        lp = touch.position;
                    }
                    else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
                    {
                        lp = touch.position;
                    }
                    else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
                    {
                        lp = touch.position;  //last touch position. Ommitted if you use list

                        //Check if drag distance is greater than 15% of the screen height
                        if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                        {//It's a drag
                         //check if the drag is vertical or horizontal
                            if ((lp.x - fp.x) > 0 && (lp.y - fp.y) > 0)
                            {
                                if (transform.position.x < xR)//Right swipe
                                    this.transform.Translate(1 * movementScale, 0, 0);
                            }
                            if ((lp.x - fp.x) < 0 && (lp.y - fp.y) > 0)
                            {//lewo

                                if (transform.position.y < yT)// Debug.Log("Up Swipe");
                                    this.transform.Translate(0, 1 * movementScale, 0);

                            }
                            if ((lp.x - fp.x) > 0 && (lp.y - fp.y) < 0)
                            {//gora
                                if (transform.position.y > yB)// Debug.Log("Down Swipe");
                                    this.transform.Translate(0, -1 * movementScale, 0);



                            }
                            if ((lp.x - fp.x) < 0 && (lp.y - fp.y) < 0)
                            {//dol
                                if (transform.position.x > xL) // Debug.Log("Left Swipe");
                                    this.transform.Translate(-1 * movementScale, 0, 0);

                            }


                        }
                        else
                        {   //It's a tap as the drag distance is less than 20% of the screen height
                            //Here we can make tap.postion as desiredPostion to move object rounded to the nearest block
                            //Debug.Log("Tap");
                        }
                    }
                }
            foreach (GameObject red in CubeRed)
            {
                if (red.transform.position.x == transform.position.x && red.transform.position.y == transform.position.y)
                {
                    Bomb();
                    alive = false;
                }
            }
            if (transform.position.y == yT && transform.position.x == xR)
            {
                RightBottom.GetComponent<FinalGoindUp>().Colour();
                RightBottom.GetComponent<FinalGoindUp>().Metod();
                Up.GetComponent<MoveGoingUp>().Metod();
                Invoke("next", 2);
            }
        }
    }
    public void Bomb()
    {
        
        foreach (GameObject red in CubeRed)
        {
            red.GetComponent<Kolor>().RedBoxSteped();
            Invoke("reload", 4);
            Invoke("death", 1);

        }
    }
    public void death()
    {
        Destroy(Up);
    }
    public void next()
    {
        string scene = SceneManager.GetActiveScene().name;
        switch (scene)
        {
            case "L1":
                SceneManager.LoadScene("L2", LoadSceneMode.Single);
                break;
            case "L2":
                SceneManager.LoadScene("L3", LoadSceneMode.Single);
                break;
            case "L3":
                SceneManager.LoadScene("L4", LoadSceneMode.Single);
                break;
            case "L4":
                SceneManager.LoadScene("L5", LoadSceneMode.Single);
                break;
            case "L5":
                SceneManager.LoadScene("L6", LoadSceneMode.Single);
                break;
            case "L6":
                SceneManager.LoadScene("L7", LoadSceneMode.Single);
                break;
            case "L7":
                SceneManager.LoadScene("L8", LoadSceneMode.Single);
                break;
            case "L8":
                SceneManager.LoadScene("L9", LoadSceneMode.Single);
                break;
            case "L9":
                SceneManager.LoadScene("L10", LoadSceneMode.Single);
                break;
            case "L10":
                SceneManager.LoadScene("L11", LoadSceneMode.Single);
                break;
            case "L11":
                SceneManager.LoadScene("L12", LoadSceneMode.Single);
                break;
            case "L12":
                SceneManager.LoadScene("L13", LoadSceneMode.Single);
                break;
            case "L13":
                SceneManager.LoadScene("L14", LoadSceneMode.Single);
                break;
            case "L14":
                SceneManager.LoadScene("L15", LoadSceneMode.Single);
                break;
            case "L15":
                SceneManager.LoadScene("L16", LoadSceneMode.Single);
                break;
            case "L16":
                SceneManager.LoadScene("L17", LoadSceneMode.Single);
                break;
            case "L17":
                SceneManager.LoadScene("L18", LoadSceneMode.Single);
                break;
            case "L18":
                SceneManager.LoadScene("L19", LoadSceneMode.Single);
                break;
            case "L19":
                SceneManager.LoadScene("L20", LoadSceneMode.Single);
                break;
            default:
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
                break;
        }



    }
    public void reload()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}