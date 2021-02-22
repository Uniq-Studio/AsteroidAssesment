using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    //TODO (1): Create a int thats staic so it doesnt get wiped when changing scenes
    public static int pointOverall;
    //TODO (2); Create a textView link
    public Text TextView;

    void Update()
    {
        //TODO (4): Display the points
        TextView.text = pointOverall.ToString();
    }
    //TODO (3): Create a meathod aasking for paramaters of points and adding to overall
    public void AddPoint(int pointX)
    {
        pointOverall += pointX;
    }

}
