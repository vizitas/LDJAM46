using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Transform PlayerTransform;
    // Start is called before the first frame update 
    public GameObject bullet;
    public float variance = 0.1f;
    public float gunSpeed = 0.2f;
    public float magazineSize = 10;
    public float reloadTime = 3;
    public float bulletSpeed = 5;
    void Start()
    {
    }
    private void OnEnable()
    {
        InvokeRepeating("FireMagazine", 0, reloadTime);
    }

    void FireMagazine()
    {
        for(int n = 0; n< magazineSize; n++)
        {
            Invoke("Fire", n* gunSpeed);
        }
    }

    // Update is called once per frame
    void Fire()
    {
        var instance = Instantiate(bullet);
        instance.transform.position = transform.position;
        var body = instance.GetComponent<Rigidbody>();
        var target = new Vector3( PlayerTransform.position.x + Random.Range(-1*variance,variance),
            PlayerTransform.position.y + Random.Range(-1 * variance/2, variance/2),
            PlayerTransform.position.z + Random.Range(-1 * variance, variance)
            );

        body.velocity =  (target - transform.position)* bulletSpeed;
        Destroy(instance, 3);
    }
}
