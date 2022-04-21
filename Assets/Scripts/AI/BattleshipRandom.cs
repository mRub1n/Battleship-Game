using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleshipRandom : MonoBehaviour
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
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, -39.1f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, -39.1f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, -39.1f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, -39.1f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, -39.1f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, -39.1f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, -39.1f);
                }
            }
            if (filePicker == 1)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, -29.3f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, -29.3f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, -29.3f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, -29.3f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, -29.3f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, -29.3f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, -29.3f);
                }
            }
            if (filePicker == 2)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, -18.3f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, -18.3f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, -18.3f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, -18.3f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, -18.3f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, -18.3f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, -18.3f);
                }
            }
            if (filePicker == 3)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, -6.5f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, -6.5f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, -6.5f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, -6.5f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, -6.5f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, -6.5f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, -6.5f);
                }
            }
            if (filePicker == 4)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 4.9f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 4.9f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 4.9f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 4.9f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 4.9f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 4.9f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 4.9f);
                }
            }
            if (filePicker == 5)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 16.7f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 16.7f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 16.7f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 16.7f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 16.7f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 16.7f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 16.7f);
                }
            }
            if (filePicker == 6)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 28.1f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 28.1f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 28.1f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 28.1f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 28.1f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 28.1f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 28.1f);
                }
            }
            if (filePicker == 7)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 39.9f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 39.9f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 39.9f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 39.9f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 39.9f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 39.9f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 39.9f);
                }
            }
            if (filePicker == 8)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 50.6f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 50.6f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 50.6f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 50.6f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 50.6f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 50.6f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 50.6f);
                }
            }
            if (filePicker == 9)
            {
                int rankPicker = Random.Range(0, 7);

                if (rankPicker == 0)
                {
                    gameObject.transform.position = new Vector3(169.7f, 4.9f, 61.4f);
                }
                if (rankPicker == 1)
                {
                    gameObject.transform.position = new Vector3(159.9f, 4.9f, 61.4f);
                }
                if (rankPicker == 2)
                {
                    gameObject.transform.position = new Vector3(149.4f, 4.9f, 61.4f);
                }
                if (rankPicker == 3)
                {
                    gameObject.transform.position = new Vector3(139.9f, 4.9f, 61.4f);
                }
                if (rankPicker == 4)
                {
                    gameObject.transform.position = new Vector3(129f, 4.9f, 61.4f);
                }
                if (rankPicker == 5)
                {
                    gameObject.transform.position = new Vector3(119.7f, 4.9f, 61.4f);
                }
                if (rankPicker == 6)
                {
                    gameObject.transform.position = new Vector3(109.1f, 4.9f, 61.4f);
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
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(195.9f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 1)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(186f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 2)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(176.5f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 3)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(166.9f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 4)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(156.8f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 5)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(146.8f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 6)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(136.9f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 7)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(127f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 8)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(116f, 4.9f, 56.6f);
                }
            }
            if (rankPicker == 9)
            {
                int filePicker = Random.Range(0, 7);

                if (filePicker == 0)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, -11.2f);
                }
                if (filePicker == 1)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, -0.4f);
                }
                if (filePicker == 2)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, 11.3f);
                }
                if (filePicker == 3)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, 23.6f);
                }
                if (filePicker == 4)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, 34.2f);
                }
                if (filePicker == 5)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, 45.9f);
                }
                if (filePicker == 6)
                {
                    gameObject.transform.position = new Vector3(105.6f, 4.9f, 56.6f);
                }
            }
        }
    }
}
