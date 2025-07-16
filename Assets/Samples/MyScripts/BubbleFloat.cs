using UnityEngine;

public class BubbleFloat : MonoBehaviour
{
    public float floatSpeed = 0.5f;
    public float floatHeight = 0.2f;
    private Vector3 startPos;

    void Start() => startPos = transform.position;

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = startPos + new Vector3(0, yOffset, 0);
    }
}
