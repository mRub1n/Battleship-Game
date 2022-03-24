using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox : MonoBehaviour
{

    //public bool BoundBreaker;
    //public bool CanMove;

    public MeshRenderer PlayArea;
    Renderer boatRend;

    void Start()
    {
        boatRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        Vector3 boatSize = boatRend.bounds.size;
        Vector3 PlaySpace = PlayArea.bounds.size; 
        PlaySpace.y += 1.0f;

        // Boat Bounding Box

        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(boatRend.bounds.center, boatSize);

        // Grid Bounding Box

        Gizmos.color = new Color(1, 0, 1, 0.5f);
        Gizmos.DrawCube(PlayArea.bounds.center, PlaySpace);

        // Bounds Detection

        bool is_boat_min_in_bounds = PlayArea.bounds.Contains(boatRend.bounds.min);
        bool is_boat_max_in_bounds = PlayArea.bounds.Contains(boatRend.bounds.max);

        //Debug.Log(is_boat_min_in_bounds);
        //Debug.Log(is_boat_max_in_bounds);


        if (is_boat_min_in_bounds == true && is_boat_max_in_bounds == true)
        {
            Gizmos.color = new Color(1, 1, 1, 1);
            Gizmos.DrawSphere(boatRend.bounds.min, 2);
            Gizmos.DrawSphere(boatRend.bounds.max, 2);
            //BoundBreaker = true;
            //SavePos = true;
        }
        else
        {
            Gizmos.color = new Color(0, 1, 1, 1);
            Gizmos.DrawSphere(boatRend.bounds.min, 2);
            Gizmos.DrawSphere(boatRend.bounds.max, 2);
            //BoundBreaker = false;
            //SavePos = false;
        }
    }
}
