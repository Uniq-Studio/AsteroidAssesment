using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int pointOverall;
    public Text TextView;

    void Update()
    {
        TextView.text = pointOverall.ToString();
    }
    public void AddPoint(int pointX)
    {
        pointOverall += pointX;
        Debug.Log(pointOverall);
    }

}
