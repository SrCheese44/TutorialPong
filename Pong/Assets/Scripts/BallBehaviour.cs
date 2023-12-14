using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;

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

        if (Random.Range(0f, 1f) < 0.5f)
        {
          //  direction += Vector3.up;
        }
        else
        {
            //direction += Vector3.down;
        }


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            direction.y = Random.Range(-1f, 1f);
        }
    }
}
