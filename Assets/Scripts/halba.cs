using UnityEngine;

public class halba : MonoBehaviour
{
    public float lifeTime = 0.2f;
    public float direction;
    // Start is called before the first frame update
    void Start()
    {
        float rand = Random.Range(0, 1.0f);
        if (rand <= 0.5f)
            direction = 0.1f;
        else
            direction = -0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (lifeTime >= 0)
        {
            Vector3 pos = transform.position;
            pos.x += direction;
            pos.y += 0.1f;
            transform.position = pos;
            lifeTime -= Time.deltaTime;
        }
        if (lifeTime <= 0)
            Destroy(gameObject);
    }
}
