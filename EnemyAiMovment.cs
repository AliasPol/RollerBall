using UnityEngine;
using System.Collections;

public class EnemyAiMovment : MonoBehaviour {



    private int z = 0, x = 1;
    private int enemySpeed = 6;
    private Vector3 currentPosition;
    private int Licznik = 0;


    // Use this for initialization
    void Start()
    {

        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        Move();

        if (transform.position == currentPosition)
        {
            z = z * -1;
            x = x * -1;
        }
        currentPosition = transform.position;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {


            if (x != 0)
            {
                x = 0;
                z = ChangeMove(z);

            }
            else if (z != 0)
            {
                z = 0;
                x = ChangeMove(x);
            }



        }
    }


    void Move()
    {

        Licznik++;

        if (Licznik == 100)
        {
            if (x != 0)
            {
                x = 0;
                z = ChangeMove(z);

            }
            else if (z != 0)
            {
                z = 0;
                x = ChangeMove(x);
            }
            Licznik = 1;
        }

        Vector3 movment = new Vector3(x, 0.0f, z);
        transform.Translate(movment * enemySpeed * Time.deltaTime);

    }

    int ChangeMove(int a)
    {
        a = Random.Range(-1, 1);

        if (a == 0)
        {
            a = a + 1;
        }

        return a;
    }

}
