using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileLauncher : MonoBehaviour
{
    public GameObject BoxParent;
    public GameObject projectile;
    public float forwardVelocity = 2100f;
    public float upwardVelocity = 1000f;

    // launch variables
    [SerializeField] private Transform TargetObject;
    [Range(1.0f, 6.0f)] public float TargetRadius;
    [Range(20.0f, 75.0f)] public float LaunchAngle;

    // state
    private bool bTargetReady;

    // cache
    private Rigidbody rigid;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LockInput(InputField input)
    {
        string userGuess = input.text;
        char firstLetter = userGuess[0];
        string pathToChildBox = firstLetter + "/" + userGuess;


        Transform result = BoxParent.transform.Find(pathToChildBox);

        if (result != null)
        {
            GameObject targetCube = result.gameObject;
            //Debug.Log("Transform.Find() result: " + result);

            // Change square colors 

            MeshRenderer targetHit = targetCube.GetComponent<MeshRenderer>();
            targetHit.enabled = true;

            // Firing missile

            GameObject missile = Instantiate(projectile, transform.position, transform.rotation);
            missile.GetComponent<Rigidbody>().isKinematic = false;
            missile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, upwardVelocity, forwardVelocity));

        }
        else
        {
            Debug.Log("Transform.Find() result: " + result);
        }
    }

    // launches the object towards the TargetObject with a given LaunchAngle
    void Launch()
    {

    }
}
