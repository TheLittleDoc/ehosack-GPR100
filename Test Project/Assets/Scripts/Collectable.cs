using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{
    public ScoreScript score;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RepositionCollectible();
        score.AddScore();
    }

    void RepositionCollectible()
    {
        float newX = Random.Range(-5, 5);
        float newY = Random.Range(-3, 3);
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }
}
