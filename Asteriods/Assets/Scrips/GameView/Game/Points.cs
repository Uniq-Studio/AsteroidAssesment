using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int score = 0;
    public Text TextView;

    // Update is called once per frame
    void Update()
    {
        TextView.text = score.ToString();
    }

    public void AsteroidPoints(int scoreX)
    {
        score += scoreX;
    }
}
