using UnityEngine;

public class MoveUp : MonoBehaviour
{


    public float speed = 3.0f;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager; //reference to score manager
    public Balloon balloon; //reference to balloon script

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }


    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // move balloon up on y axis

        if (transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }





}
