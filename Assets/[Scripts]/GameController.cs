using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Rect screen;
    public Rect safeArea;

    public Rect backButton;

    // Start is called before the first frame update
    void Start()
    {
        Rect screenRect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        screen = screenRect;
        safeArea = Screen.safeArea;

        CheckOrientation();
    }

    private void CheckOrientation()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeLeft:
                break;
            case ScreenOrientation.LandscapeRight:
                break;
            case ScreenOrientation.Portrait:
                break;
            default:
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Rect screenRect = new Rect(0.0f, 0.0f, Screen.width, screen.height);
        screen = screenRect;
        safeArea = Screen.safeArea;


        CheckOrientation();


    }

}
