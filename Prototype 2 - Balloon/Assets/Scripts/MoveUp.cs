using UnityEngine;

public class MoveUp : MonoBehaviour
{


    public float speed = 3.0f;


    void Start()
    {
    
}


    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // move balloon up on y axis
}





}
