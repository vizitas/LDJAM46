using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtileryField : MonoBehaviour
{
    public GameObject ArtileryHit;
    public float Frequency = 1f;
    public float probabilty = 50f;
    private Collider field;
    // Update is called once per frame
    void Start()
    {
        field = GetComponent<Collider>();
        InvokeRepeating("Hit", 0, Frequency);

    }
    void Hit()
    {
        if (Random.Range(0, 100) <= probabilty)
        {
            Vector3 location = new Vector3(
                transform.position.x + Random.Range(field.bounds.extents.x * -1, field.bounds.extents.x),
                transform.position.y,
                transform.position.z + Random.Range(field.bounds.extents.z * -1, field.bounds.extents.z));
            var hit = Instantiate(ArtileryHit);
            hit.transform.position = location;
        }
    }
}
