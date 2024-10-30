using UnityEngine;

public class EnvironmentMove : MonoBehaviour
{
    [SerializeField] float lowestPoint;
    [SerializeField] float highestPoint;
    [SerializeField] float speed;

    private void Update()
    {
        if(gameObject.transform.position.y<=lowestPoint)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, highestPoint, transform.position.z);
        }
        Move();
    }

    private void Move()
    {
        transform.Translate(0, -speed, 0);
    }
}
