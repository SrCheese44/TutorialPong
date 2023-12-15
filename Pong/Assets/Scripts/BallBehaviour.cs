using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;

    [SerializeField]
    GameScoreUI score;

    [SerializeField]
    float ballSpeedInitial = 2.0f;
    float BallSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0f, 1f) < 0.5f)
        {
            direction = Vector3.right;
        }
        else
        {
            direction = Vector3.left;
        }

        direction.y = Random.Range(-1f, 1f);

        BallSpeed = ballSpeedInitial;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * BallSpeed * Time.deltaTime;

       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            direction.y = Random.Range(-1f, 1f);
            BallSpeed += 0.4f;
        }
        else if (collision.gameObject.CompareTag("Border"))
        {
           direction.y = -direction.y;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoalZone1"))
        {
            ResetBall();
            score.goalPlayerTwo();
        }
        if (collision.gameObject.CompareTag("GoalZone1"))
        {

            ResetBall();
            score.goalPlayerOne();
        }

    }
    private void ResetBall()
    {
        transform.position = Vector3.zero;
        BallSpeed = ballSpeedInitial;
        direction.x = -direction.x;
        direction.y = Random.Range(-1f, 1f);
    }


}
