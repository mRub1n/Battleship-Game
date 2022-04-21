using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider : MonoBehaviour
{
    LaunchProjectile missileObject;

    // Start is called before the first frame update
    void Start()
    {
        missileObject = FindObjectOfType<LaunchProjectile>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        missileObject.detection = true;
        Destroy(gameObject);
    }
}
