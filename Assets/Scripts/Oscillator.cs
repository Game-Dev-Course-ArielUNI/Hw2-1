using UnityEngine;

public class Oscillator : MonoBehaviour

{
    [Tooltip("Direction of oscillation, e.g., Vector3.right for horizontal.")]
    public Vector3 oscillationDirection = Vector3.right;

    [SerializeField]
    [Tooltip("The start location for the airplane.")]
    private Vector3 StartPosition;

    [SerializeField]
    [Tooltip("Maximum distance for the airplane to move right or left.")]
    private float Maxdistance = 3;

    [SerializeField]
    [Tooltip("Speed for the airplane to move right or left.")]
    private float speed = 1f;

    private float phase = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = StartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        phase += Time.deltaTime * speed;

      
        float offset = Mathf.Sin(phase) * Maxdistance;

      
        transform.position = StartPosition + oscillationDirection.normalized * offset;
    }
}
