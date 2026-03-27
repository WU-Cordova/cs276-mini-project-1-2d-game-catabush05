using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float minSize = 0.5f;
    [SerializeField] float maxSize = 2.0f;

    Rigidbody2D rb;

    [SerializeField] float minSpeed = 50f;
    [SerializeField] float maxSpeed = 150f;

    [SerializeField] float maxSpinSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSize;
        Vector2 randomDirection = Random.insideUnitCircle;
        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);

        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(randomDirection * randomSpeed);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
