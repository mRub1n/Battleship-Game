using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject BoxParent;
    public float yLaunchVelocity = 700f;
    public GameObject targetCube;
    public float launchVelocityScale = 1.0f;
    public float launchAngle = 40.0f;
    public float platformOffset = 0.0f;
    public bool detection = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Change square colors 

        //Debug.Log(detection);

        if (detection == true)
        {
            MeshRenderer targetHit = targetCube.GetComponent<MeshRenderer>();
            targetHit.enabled = true;
            detection = false;
        }
    }

    public void Launch()
    {
        //Debug.Log("Fire pressed!");

        GameObject missile = Instantiate(projectile, transform.position, transform.rotation);

        missile.transform.LookAt(targetCube.transform.position);


        /*
        Vector3 dirToTarget = targetCube.transform.position - transform.position;
        Vector3 launchVelocity = launchVelocityScale * dirToTarget;
        launchVelocity.y *= yLaunchVelocity;
        launchVelocity.y = Mathf.Abs(launchVelocity.y);

        //Vector3 launchVelocity = new Vector3(0, yLaunchVelocity, 0);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddRelativeForce(launchVelocity);
        }
        */

        Vector3 ballPosXZ = missile.transform.position;
        Vector3 targetCubeXZ = targetCube.transform.position;

        float heightDifference = targetCubeXZ.y - ballPosXZ.y;

        ballPosXZ.y = 0.0f;
        targetCubeXZ.y = 0.0f;

        // shorthands for the formula
        float R = Vector3.Distance(ballPosXZ, targetCubeXZ);
        float G = Physics.gravity.y;
        float tanAlpha = Mathf.Tan(launchAngle * Mathf.Deg2Rad);
        float H = (targetCube.transform.position.y + platformOffset) - missile.transform.position.y;

        // calculate initial speed required to land the projectile on the target object 
        float Vz = Mathf.Sqrt(G * R * R / (2.0f * (H - R * tanAlpha)));
        float Vy = tanAlpha * Vz;

        // create the velocity vector in local space and get it in global space
        Vector3 localVelocity = new Vector3(0f, Vy, Vz);
        Vector3 globalVelocity = missile.transform.TransformDirection(localVelocity);

        Debug.Log(globalVelocity);

        Rigidbody rb = missile.GetComponent<Rigidbody>();

        //Debug.Log(rb);

        if (rb != null)
        {
            rb.velocity = globalVelocity;
            //rb.AddRelativeForce(localVelocity);
        }
    }

    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, targetCube.transform.position);
    }

    public void LockInput(InputField input)
    {
        string userGuess = input.text;
        char firstLetter = userGuess[0];
        string pathToChildBox = firstLetter + "/" + userGuess;


        Transform result = BoxParent.transform.Find(pathToChildBox);

        if (result != null)
        {
            targetCube = result.gameObject;
            //Debug.Log("Transform.Find() result: " + result);

        }
        else
        {
            Debug.Log("Transform.Find() result: " + result);
        }
    }
}
