using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPlacer : MonoBehaviour
{

    public MeshRenderer PlayArea;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Renderer boatRend;
        boatRend = GetComponent<Renderer>();

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            bool RightCheck1 = PlayArea.bounds.Contains(boatRend.bounds.min - new Vector3(0, 0, 11.25f));
            bool RightCheck2 = PlayArea.bounds.Contains(boatRend.bounds.max - new Vector3(0, 0, 11.25f));

            if (RightCheck1 && RightCheck2)
            {
                transform.position -= new Vector3(0, 0, 11.25f);
            }
        } 

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            bool LeftCheck1 = PlayArea.bounds.Contains(boatRend.bounds.min + new Vector3(0, 0, 11.25f));
            bool LeftCheck2 = PlayArea.bounds.Contains(boatRend.bounds.max + new Vector3(0, 0, 11.25f));

            if (LeftCheck1 && LeftCheck2)
            {
                transform.position += new Vector3(0, 0, 11.25f);
            }
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
            {
                bool UpCheck_Rotated1 = PlayArea.bounds.Contains(boatRend.bounds.min + new Vector3(9.75f, 0, 0));
                bool UpCheck_Rotated2 = PlayArea.bounds.Contains(boatRend.bounds.max + new Vector3(9.75f, 0, 0));

                if (UpCheck_Rotated1 && UpCheck_Rotated2)
                {
                    transform.position += new Vector3(9.75f, 0, 0);
                }
            }

            else
            {
                bool UpCheck1 = PlayArea.bounds.Contains(boatRend.bounds.min + new Vector3(10, 0, 0));
                bool UpCheck2 = PlayArea.bounds.Contains(boatRend.bounds.max + new Vector3(10, 0, 0));

                if (UpCheck1 && UpCheck2)
                {
                    transform.position += new Vector3(10, 0, 0);
                }
            }


        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
            {
                bool DownCheck_Rotated1 = PlayArea.bounds.Contains(boatRend.bounds.min - new Vector3(9.75f, 0, 0));
                bool DownCheck_Rotated2 = PlayArea.bounds.Contains(boatRend.bounds.max - new Vector3(9.75f, 0, 0));

                if (DownCheck_Rotated1 && DownCheck_Rotated2)
                {
                    transform.position -= new Vector3(9.75f, 0, 0);
                }
            }

            else
            {
                bool DownCheck1 = PlayArea.bounds.Contains(boatRend.bounds.min - new Vector3(10, 0, 0));
                bool DownCheck2 = PlayArea.bounds.Contains(boatRend.bounds.max - new Vector3(10, 0, 0));

                if (DownCheck1 && DownCheck2)
                {
                    transform.position -= new Vector3(10, 0, 0);
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.R))
        {

            if (gameObject.name == "Blue Carrier Boat")
            {

                //gameObject.transform.Rotate(0, 0, 90);
                if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
                {
                    transform.position = new Vector3(38.4f, 4, 61.5f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }
                else
                {
                    transform.position = new Vector3(5.3f, 4, 25.2f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
                }
            }

            if (gameObject.name == "Blue Battleship Boat")
            {
                if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
                {
                    transform.position = new Vector3(31.1f, 5.6f, 60.9f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }
                else
                {
                    transform.position = new Vector3(5.1f, 5.6f, 32.8f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
                }
            }

            if (gameObject.name == "Blue Destroyer Boat")
            {
                if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
                {
                    transform.position = new Vector3(22.4f, 5, 61.4f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }
                else
                {
                    transform.position = new Vector3(5, 5, 42.9f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
                }
            }

            if (gameObject.name == "Blue Sub Boat")
            {
                if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
                {
                    transform.position = new Vector3(22.4f, 5, 61.4f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }
                else
                {
                    transform.position = new Vector3(5, 5, 42.9f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
                }
            }

            if (gameObject.name == "Blue Patrol Boat")
            {
                if (gameObject.transform.rotation == Quaternion.Euler(-90, 0, 90))
                {
                    transform.position = new Vector3(14, 4.1f, 61.3f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }
                else
                {
                    transform.position = new Vector3(4.7f, 4.1f, 52.6f);
                    gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
                }
            }
        }
    }

    public void PlaceBoat()
    {
        Destroy(this);
    }

}