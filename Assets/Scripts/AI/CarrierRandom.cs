using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrierRandom : MonoBehaviour
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
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, -38.9f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, -38.9f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, -38.9f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, -38.9f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, -38.9f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, -38.9f);
                }
            }
            if (filePicker == 1)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, -29.2f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, -29.2f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, -29.2f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, -29.2f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, -29.2f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, -29.2f);
                }
            }
            if (filePicker == 2)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, -18f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, -18f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, -18f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, -18f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, -18f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, -18f);
                }
            }
            if (filePicker == 3)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, -6.8f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, -6.8f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, -6.8f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, -6.8f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, -6.8f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, -6.8f);
                }
            }
            if (filePicker == 4)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 5f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 5f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 5f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 5f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 5f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 5f);
                }
            }
            if (filePicker == 5)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 16.6f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 16.6f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 16.6f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 16.6f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 16.6f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 16.6f);
                }
            }
            if (filePicker == 6)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 28f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 28f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 28f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 28f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 28f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 28f);
                }
            }
            if (filePicker == 7)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 39.2f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 39.2f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 39.2f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 39.2f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 39.2f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 39.2f);
                }
            }
            if (filePicker == 8)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 50.2f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 50.2f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 50.2f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 50.2f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 50.2f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 50.2f);
                }
            }
            if (filePicker == 9)
            {
                int rankPicker = Random.Range(0, 6);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(162.3f, 4.9f, 60.7f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(152.6f, 4.9f, 60.7f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(143.3f, 4.9f, 60.7f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(133f, 4.9f, 60.7f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(123.1f, 4.9f, 60.7f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(112.3f, 4.9f, 60.7f);
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
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(195.5f, 4.9f, 25f);
                }
            }
            if (rankPicker == 1)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(185.8f, 4.9f, 25f);
                }
            }
            if (rankPicker == 2)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(176.3f, 4.9f, 25f);
                }
            }
            if (rankPicker == 3)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(166.6f, 4.9f, 25f);
                }
            }
            if (rankPicker == 4)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 25f);
                }
            }
            if (rankPicker == 5)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(146.6f, 4.9f, 25f);
                }
            }
            if (rankPicker == 6)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(137f, 4.9f, 25f);
                }
            }
            if (rankPicker == 7)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 25f);
                }
            }
            if (rankPicker == 8)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(116.6f, 4.9f, 25f);
                }
            }
            if (rankPicker == 9)
            {
                int filePicker = Random.Range(0, 6);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, -31.8f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, -20.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, -8.9f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, 2.1f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, 13.1f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(106.2f, 4.9f, 25f);
                }
            }
        }
    }
}
