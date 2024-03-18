using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax
{
    public static float speed = 2f;
}
public class Parallex : MonoBehaviour
{
    public Transform[] tiles;

    public float left = -19;
    public Vector3 right = new Vector3(19f, 0f, 0f);

    public float rate = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.speed * rate;

            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
