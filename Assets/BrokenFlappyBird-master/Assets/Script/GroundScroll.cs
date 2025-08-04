using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetPositionX; 
    public float startPositionX; 

    private Vector2 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x <= resetPositionX)
        {
            float offset = transform.position.x - resetPositionX;
            Vector2 newPos = new Vector2(startPositionX + offset, transform.position.y);
            transform.position = newPos;
        }
    }
}
