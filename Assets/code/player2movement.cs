using UnityEngine;

public class player2movement : MonoBehaviour
{
//deplacement p1

//deplacement p2
public float vitesseDeplacement2 = 1f;


// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{

}



// Update is called once per frame
void Update()
{


    // deplacement 1
    transform.Translate(Deplacement() * vitesseDeplacement2 * Time.deltaTime);


}

Vector3 Deplacement()
{
    Vector3 direction = Vector3.zero;

    //gauche droite
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        direction += Vector3.left;
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
        direction += Vector3.right;
    }

    //haut bas
    if (Input.GetKey(KeyCode.UpArrow))
    {
        direction += Vector3.up;
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
        direction += Vector3.down;
    }

    return direction;
}

}
