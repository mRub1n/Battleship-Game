using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolRandom : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Randomize()
    {
        int rotatePicker = Random.Range(0, 2);
        Debug.Log(rotatePicker);

        if (rotatePicker == 0)
        {
            int filePicker = Random.Range(0, 10);
            Debug.Log(filePicker);

            if (filePicker == 0)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, -39.2f);
                    Debug.Log("rotation = 0 : file = 0 : rank = 8");
                }

            }
            if (filePicker == 1)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, -29.3f);
                    Debug.Log("rotation = 0 : file = 1 : rank = 8");
                }
            }
            if (filePicker == 2)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, -18.2f);
                    Debug.Log("rotation = 0 : file = 2 : rank = 8");
                }
            }
            if (filePicker == 3)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, -6.6f);
                    Debug.Log("rotation = 0 : file = 3 : rank = 8");
                }
            }
            if (filePicker == 4)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 5f);
                    Debug.Log("rotation = 0 : file = 4 : rank = 8");
                }
            }
            if (filePicker == 5)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 16.8f);
                    Debug.Log("rotation = 0 : file = 5 : rank = 8");
                }
            }
            if (filePicker == 6)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 28.5f);
                    Debug.Log("rotation = 0 : file = 6 : rank = 8");
                }
            }
            if (filePicker == 7)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 39.6f);
                    Debug.Log("rotation = 0 : file = 7 : rank = 8");
                }
            }
            if (filePicker == 8)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 50.7f);
                    Debug.Log("rotation = 0 : file = 8 : rank = 8");
                }
            }
            if (filePicker == 9)
            {
                int rankPicker = Random.Range(0, 9);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(187.3f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 0");
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(177.6f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 1");
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(167.4f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 2");
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(158.4f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 3");
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(148.1f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 4");
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(138f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 5");
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(128.1f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 6");
                }
                if (rankPicker == 7)
                {
                    gameObject.transform.position = new Vector3(117.7f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 7");
                }
                if (rankPicker == 8)
                {
                    gameObject.transform.position = new Vector3(107f, 4.9f, 61.4f);
                    Debug.Log("rotation = 0 : file = 9 : rank = 8");
                }
            }
        }
        if (rotatePicker == 1)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 90, 0);
            int rankPicker = Random.Range(0, 10);
            Debug.Log(rankPicker);

            if (rankPicker == 0)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 0");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 0");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 0");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 0");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 0");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 0");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 0");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 0");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(196f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 0");
                }
            }
            if (rankPicker == 1)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 1");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 1");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 1");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 1");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 1");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 1");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 1");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 1");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(186.3f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 1");
                }
            }
            if (rankPicker == 2)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 2");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 2");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 2");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 2");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 2");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 2");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 2");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 2");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 2");
                }
            }
            if (rankPicker == 3)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 3");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 3");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 3");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 3");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 3");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 3");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 3");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 3");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 3");
                }
            }
            if (rankPicker == 4)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 4");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 4");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 4");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 4");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 4");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 4");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 4");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 4");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(156.6f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 4");
                }
            }
            if (rankPicker == 5)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 5");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 5");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 5");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 5");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 5");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 5");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 5");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 5");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(146.7f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 5");
                }
            }
            if (rankPicker == 6)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 6");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 6");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 6");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 6");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 6");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 6");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 6");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 6");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(137.3f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 6");
                }
            }
            if (rankPicker == 7)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 7");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 7");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 7");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 7");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 7");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 7");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 7");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 7");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(127.1f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 7");
                }
            }
            if (rankPicker == 8)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 8");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 8");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 8");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 8");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 8");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 8");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 8");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 8");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(116.2f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 8");
                }
            }
            if (rankPicker == 9)
            {
                int filePicker = Random.Range(0, 9);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, -37.9f);
                    Debug.Log("rotation = 1 : file = 0 : rank = 9");
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, -27.3f);
                    Debug.Log("rotation = 1 : file = 1 : rank = 9");
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, -16f);
                    Debug.Log("rotation = 1 : file = 2 : rank = 9");
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, -5.3f);
                    Debug.Log("rotation = 1 : file = 3 : rank = 9");
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, 6.8f);
                    Debug.Log("rotation = 1 : file = 4 : rank = 9");
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, 18.9f);
                    Debug.Log("rotation = 1 : file = 5 : rank = 9");
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, 29.8f);
                    Debug.Log("rotation = 1 : file = 6 : rank = 9");
                }
                if (filePicker == 7)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, 41.2f);
                    Debug.Log("rotation = 1 : file = 7 : rank = 9");
                }
                if (filePicker == 8)
                {
                    gameObject.transform.position = new Vector3(105.9f, 4.9f, 51.6f);
                    Debug.Log("rotation = 1 : file = 8 : rank = 9");
                }
            }
        }
    }
}
