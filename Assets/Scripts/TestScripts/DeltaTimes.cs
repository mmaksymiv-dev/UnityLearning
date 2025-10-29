using UnityEngine;

public class DeltaTimes : MonoBehaviour
{
    /// <summary>
    /// FPS = Frames Per Second
    /// Better PC = Less time between frames
    /// Time.deltaTime = 1 / Framerate
    /// </summary>

    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.Translate(new Vector2(0f, 5f));

    //        // PC 1 20 FPS
    //        // Which means we move 100 units per second!
    //        // transform.Translate(20 * new Vector2(0f, 5f));

    //        // PC 2 100 FPS
    //        // Which means we move 500 units per second!
    //        // transform.Translate(100 * new Vector2(0f, 5f));
    //    }
    //}

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0f, 5f) * Time.deltaTime);

            // PC 1 20 FPS
            // Which means we move 5 units per second!
            // Time.deltaTime = 1/20 = 0.05
            // transform.Translate(20 * new Vector2(0f, 5f) * 0.05f);

            // PC 2 100 FPS
            // Which means we move 5 units per second!
            // Time.deltaTime = 1/100 = 0.01
            // transform.Translate(100 * new Vector2(0f, 5f) * 0.01f);
        }
    }
}
 